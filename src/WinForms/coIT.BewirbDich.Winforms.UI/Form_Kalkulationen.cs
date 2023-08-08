using coIT.BewirbDich.Winforms.Domain;
using coIT.BewirbDich.Winforms.Infrastructure;
using System.Windows.Forms;

namespace coIT.BewirbDich.Winforms.UI;

public partial class CertificationOverviewForm : Form
{
    private readonly IRepository _repo;

    private BindingSource _kalkulationen;

    public CertificationOverviewForm()
    {
        InitializeComponent();
        _repo = new JsonRepository("database.json");
    }

    private void ctr_NewCalculation_Click(object sender, EventArgs e)
    {
        var newCertificationForm = new CreateNewCertificate_Form(new InsuranceCertificate());

        var dialog = newCertificationForm.ShowDialog();
        if (dialog == DialogResult.OK)
        {
            var newCalculation = newCertificationForm.Certificate;
            _repo.Add(newCalculation);
            _kalkulationen.ResetBindings(false);
        }

    }

    private void ctrl_Save_Click(object sender, EventArgs e)
    {
        _repo.Save();
        MessageBox.Show("Daten gespeichert.", "Vorgang", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void ctrl_CalculationList_SelectionChanged(object sender, EventArgs e)
    {
        var selectedRow = getSelectedRow();

        if (selectedRow == null)
            return;

        showOptions(selectedRow);
    }

    private void showOptions(InsuranceCertificate calculation)
    {
        ctrIssueCertificate.Enabled = false;
        ctrAcceptOffer.Enabled = false;

        switch (calculation.documentType)
        {
            case DocumentType.Angebot:
                ctrAcceptOffer.Enabled = true;
                break;
            case DocumentType.Versicherungsschein:
                if (!calculation.isCertificateIssued)
                    ctrIssueCertificate.Enabled = true;
                break;
            default: throw new InvalidDataException("Unbekannter Dokumenttyp");
        }
    }

    private void ctrlAcceptOffer_Click(object sender, EventArgs e)
    {
        var selectedRow = getSelectedRow();
        if (selectedRow == null)
            return;

        selectedRow.documentType = DocumentType.Versicherungsschein;

        showOptions(selectedRow);
        _kalkulationen.ResetBindings(false);
    }

    private void ctrl_VersicherungsscheinAusstellen_Click(object sender, EventArgs e)
    {
        var selectedRow = getSelectedRow();
        if (selectedRow == null)
            return;

        selectedRow.isCertificateIssued = true;

        showOptions(selectedRow);

        MessageBox.Show("Der Versicherungsschein wurde an den Versicherungsnehmer verschickt.", "Vorgang", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private InsuranceCertificate? getSelectedRow()
    {
        var rowCount = ctrlCalculationLists.SelectedRows.Count;
        if (rowCount == 0 || rowCount > 1) return null;

        var selectedRow = ctrlCalculationLists.SelectedRows[0];
        if (selectedRow == null) return null;

        return (InsuranceCertificate)selectedRow.DataBoundItem;
    }

    private void CertificationOverviewLoad(object sender, EventArgs e)
    {
        _kalkulationen = new BindingSource
        {
            DataSource = _repo.List()
        };

        ctrlCalculationLists.DataSource = _kalkulationen;

        ctrlCalculationLists.ColumnHeadersVisible = true;
        ctrlCalculationLists.AutoGenerateColumns = true;
        ctrlCalculationLists.Columns["Id"].Visible = false;
        ctrlCalculationLists.Columns["calculationBase"].Visible = false;
        ctrlCalculationLists.Columns["membershipFee"].DefaultCellStyle.Format = "c";
        ctrlCalculationLists.Columns["sumInsured"].DefaultCellStyle.Format = "c";
        ctrlCalculationLists.AutoResizeColumns();
        ctrlCalculationLists.AutoSize = true;

        _kalkulationen.ResetBindings(false);
    }
}