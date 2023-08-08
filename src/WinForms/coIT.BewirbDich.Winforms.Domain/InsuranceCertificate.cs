using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace coIT.BewirbDich.Winforms.Domain;

public class InsuranceCertificate
{
    public Guid Id { get; }

    [DisplayName("Zertifikat-Typ")]
    public DocumentType documentType { get; set; }

    [DisplayName("Art der Berechnung")]
    public CalculationType calculationType { get; set; }
    public CalculationBase calculationBase { get; set; }
    [DisplayName("Basis Beitrag")]
    public decimal CalculationBaseValueToDisplay
    {
        get
        {
            return calculationBase?.baseVolume ?? 0;
        }
    }

    [DisplayName("Zusatzschutz mit einbeziehen")]
    public bool shouldConsiderAdditionalProtection { get; set; }
    [DisplayName("Kosten Zusatzschutz")]
    public float additionalProtection { get; set; }

    //only for companies with a calculation Type via sales volume
    [DisplayName("Webshop")]
    public bool hasWebshop { get; set; }
    [DisplayName("Risiko Faktor")]
    public RiskFactor riskFactor { get; set; }
    [DisplayName("Mitgliedsbeitrag")]
    public decimal membershipFee { get; set; }
    [DisplayName("Zertifikat wurde ausgestellt")]
    public bool isCertificateIssued { get; set; }
    [DisplayName("Versicherungssumme")]
    public decimal sumInsured { get; set; }

    public InsuranceCertificate()
    {
        Id = Guid.NewGuid();
    }
}