using coIT.BewirbDich.Winforms.Domain;

namespace coIT.BewirbDich.Winforms.UI
{
    public partial class CreateNewCertificate_Form : Form
    {
        public Domain.InsuranceCertificate Certificate { get; set; }

        public CreateNewCertificate_Form(InsuranceCertificate certificate)
        {
            Certificate = certificate;
            InitializeComponent();
        }

        private void ctrl_cancle_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ctrl_calculateCertificate_Click(object sender, EventArgs e)
        {
            var certificate = new InsuranceCertificate();
            certificate.documentType = DocumentType.Angebot;
            certificate.calculationType = (CalculationType)Enum.Parse(typeof(CalculationType), ctrl_CertificationType.Text);
            certificate.calculationBase = new CalculationBase();
            certificate.riskFactor = (RiskFactor)Enum.Parse(typeof(RiskFactor), ctrl_RiskFactor.Text);
            certificate.shouldConsiderAdditionalProtection = ctrl_IncludeAdditionalProtection.Checked;
            if (float.TryParse(ctrl_AdditionalProtectionValue.Text.Replace("%", string.Empty), out var zuschlag))
                certificate.additionalProtection = zuschlag;
            else
                certificate.additionalProtection = 0;
            certificate.hasWebshop = ctrl_HasWebshop.Checked;
            certificate.sumInsured = decimal.Parse(ctrl_InsuredValue.Text);

            Certificate = calculateCertificate(certificate);

            DialogResult = DialogResult.OK;
            Close();
        }

        private InsuranceCertificate calculateCertificate(InsuranceCertificate certificate)
        {
            //Versicherungsnehmer, die nach Haushaltssumme versichert werden (primär Vereine) stellen immer ein mittleres Risiko da
            if (certificate.calculationType == CalculationType.HousholdBudget)
            {
                ctrl_RiskFactor.SelectedText = Enum.GetName(typeof(RiskFactor), RiskFactor.Moderate);
                certificate.riskFactor = RiskFactor.Moderate;
            }

            //Versicherungsnehmer, die nach Anzahl Mitarbeiter abgerechnet werden und mehr als 5 Mitarbeiter haben, können kein Lösegeld absichern
            if (certificate.calculationType == CalculationType.employeeCount)
                if (certificate.calculationBase.baseVolume > 5)
                {
                    certificate.shouldConsiderAdditionalProtection = false;
                    certificate.additionalProtection = 0;
                    ctrl_AdditionalProtectionValue.Visible = false;
                    ctrl_IncludeAdditionalProtection.Checked = false;
                }

            //Versicherungsnehmer, die nach Umsatz abgerechnet werden, mehr als 100.000€ ausweisen und Lösegeld versichern, haben immer mittleres Risiko
            if (certificate.calculationType == CalculationType.salesVolume)
                if (certificate.sumInsured > 100000m && certificate.shouldConsiderAdditionalProtection)
                {
                    ctrl_RiskFactor.SelectedText = Enum.GetName(typeof(RiskFactor), RiskFactor.Moderate);
                    certificate.riskFactor = RiskFactor.Moderate;
                }

            decimal membershipFee;
            switch (certificate.calculationType)
            {
                case CalculationType.salesVolume:
                    certificate.calculationBase.setBaseVolume((decimal) Math.Pow((double)certificate.sumInsured, 0.25d));
                    membershipFee = 1.1m * certificate.calculationBase.baseVolume;
                    if (certificate.hasWebshop) //Webshop gibt es nur bei Unternehmen, die nach Umsatz abgerechnet werden
                        membershipFee *= 2;
                    break;
                case CalculationType.HousholdBudget:
                    certificate.calculationBase.setBaseVolume((decimal)Math.Log10((double) certificate.sumInsured));
                    membershipFee = 1.0m * certificate.calculationBase.baseVolume + 100m;
                    break;
                case CalculationType.employeeCount:
                    certificate.calculationBase.setBaseVolume(certificate.sumInsured / 1000);

                    if (certificate.calculationBase.baseVolume < 4)
                        membershipFee = certificate.calculationBase.baseVolume * 250m;
                    else
                        membershipFee = certificate.calculationBase.baseVolume * 200m;

                    break;
                default:
                    throw new Exception();
            }

            if (certificate.shouldConsiderAdditionalProtection)
                membershipFee *= 1.0m + (decimal) certificate.additionalProtection / 100.0m;

            if (certificate.riskFactor == RiskFactor.Moderate)
            {
                if (certificate.calculationType is CalculationType.HousholdBudget or CalculationType.salesVolume)
                    membershipFee *= 1.2m;
                else
                    membershipFee *= 1.3m;
            }

            certificate.calculationBase.setBaseVolume(Math.Round(certificate.calculationBase.baseVolume, 2));
            certificate.membershipFee = Math.Round(membershipFee, 2);
            return certificate;
        }

        private void Form_NeueKalkulation_Load(object sender, EventArgs e)
        {
            var berechnungsarten = Enum.GetNames(typeof(CalculationType));
            ctrl_CertificationType.Items.AddRange(berechnungsarten);

            var risiken = Enum.GetNames(typeof(RiskFactor));
            ctrl_RiskFactor.Items.AddRange(risiken);
        }

        private void ctrl_InkludiereZusatzschutz_CheckedChanged(object sender, EventArgs e)
        {
            ctrl_AdditionalProtectionValue.Visible = ctrl_IncludeAdditionalProtection.Checked;
        }
    }
}
