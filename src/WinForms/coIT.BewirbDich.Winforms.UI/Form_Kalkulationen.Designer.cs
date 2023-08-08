namespace coIT.BewirbDich.Winforms.UI;

partial class CertificationOverviewForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.ctrNewCalculation = new System.Windows.Forms.Button();
            this.ctrlCalculationLists = new System.Windows.Forms.DataGridView();
            this.ctrlSave = new System.Windows.Forms.Button();
            this.ctrAcceptOffer = new System.Windows.Forms.Button();
            this.ctrIssueCertificate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCalculationLists)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrNewCalculation
            // 
            this.ctrNewCalculation.Location = new System.Drawing.Point(12, 12);
            this.ctrNewCalculation.Name = "ctr_NeueKalkulation";
            this.ctrNewCalculation.Size = new System.Drawing.Size(75, 41);
            this.ctrNewCalculation.TabIndex = 0;
            this.ctrNewCalculation.Text = "+ NEU";
            this.ctrNewCalculation.UseVisualStyleBackColor = true;
            this.ctrNewCalculation.Click += new System.EventHandler(this.ctr_NewCalculation_Click);
            // 
            // ctrlCalculationLists
            // 
            this.ctrlCalculationLists.AllowUserToOrderColumns = true;
            this.ctrlCalculationLists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlCalculationLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctrlCalculationLists.Location = new System.Drawing.Point(12, 79);
            this.ctrlCalculationLists.Name = "ctrl_ListeKalkulationen";
            this.ctrlCalculationLists.RowTemplate.Height = 25;
            this.ctrlCalculationLists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctrlCalculationLists.Size = new System.Drawing.Size(1184, 359);
            this.ctrlCalculationLists.TabIndex = 1;
            this.ctrlCalculationLists.SelectionChanged += new System.EventHandler(this.ctrl_CalculationList_SelectionChanged);
            // 
            // ctrlSave
            // 
            this.ctrlSave.Location = new System.Drawing.Point(1111, 12);
            this.ctrlSave.Name = "ctrl_Speichern";
            this.ctrlSave.Size = new System.Drawing.Size(75, 41);
            this.ctrlSave.TabIndex = 2;
            this.ctrlSave.Text = "Speichern";
            this.ctrlSave.UseVisualStyleBackColor = true;
            this.ctrlSave.Click += new System.EventHandler(this.ctrl_Save_Click);
            // 
            // ctrl_AngebotAnnehmen
            // 
            this.ctrAcceptOffer.Enabled = false;
            this.ctrAcceptOffer.Location = new System.Drawing.Point(93, 12);
            this.ctrAcceptOffer.Name = "ctrl_AngebotAnnehmen";
            this.ctrAcceptOffer.Size = new System.Drawing.Size(94, 41);
            this.ctrAcceptOffer.TabIndex = 3;
            this.ctrAcceptOffer.Text = "Annehmen 👍";
            this.ctrAcceptOffer.UseVisualStyleBackColor = true;
            this.ctrAcceptOffer.Click += new System.EventHandler(this.ctrlAcceptOffer_Click);
            // 
            // ctrlIssueCertificate
            // 
            this.ctrIssueCertificate.Enabled = false;
            this.ctrIssueCertificate.Location = new System.Drawing.Point(193, 12);
            this.ctrIssueCertificate.Name = "ctrlIssueCertificate";
            this.ctrIssueCertificate.Size = new System.Drawing.Size(94, 41);
            this.ctrIssueCertificate.TabIndex = 4;
            this.ctrIssueCertificate.Text = "Ausstellen 🖨";
            this.ctrIssueCertificate.UseVisualStyleBackColor = true;
            this.ctrIssueCertificate.Click += new System.EventHandler(this.ctrl_VersicherungsscheinAusstellen_Click);
            // 
            // CertificationOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 450);
            this.Controls.Add(this.ctrIssueCertificate);
            this.Controls.Add(this.ctrAcceptOffer);
            this.Controls.Add(this.ctrlSave);
            this.Controls.Add(this.ctrlCalculationLists);
            this.Controls.Add(this.ctrNewCalculation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CertificationOverviewForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Versicherungsschein-Assistant";
            this.Load += new System.EventHandler(this.CertificationOverviewLoad);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCalculationLists)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private Button ctrNewCalculation;
    private DataGridView ctrlCalculationLists;
    private Button ctrlSave;
    private Button ctrAcceptOffer;
    private Button ctrIssueCertificate;
}