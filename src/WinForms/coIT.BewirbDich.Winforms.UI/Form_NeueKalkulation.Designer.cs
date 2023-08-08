namespace coIT.BewirbDich.Winforms.UI
{
    partial class CreateNewCertificate_Form
    {
        private ComboBox ctrl_CertificationType;
        private Label label_CerificateType;
        private Label label_RiskFactor;
        private ComboBox ctrl_RiskFactor;
        private RadioButton ctrl_HasWebshop;
        private TextBox ctrl_InsuredValue;
        private Label label_InsuredValue;
        private Button ctrl_Calculate;
        private Button ctrl_Cancle;
        private CheckBox ctrl_IncludeAdditionalProtection;
        private ComboBox ctrl_AdditionalProtectionValue;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrl_CertificationType = new System.Windows.Forms.ComboBox();
            this.label_CerificateType = new System.Windows.Forms.Label();
            this.label_RiskFactor = new System.Windows.Forms.Label();
            this.ctrl_RiskFactor = new System.Windows.Forms.ComboBox();
            this.ctrl_HasWebshop = new System.Windows.Forms.RadioButton();
            this.ctrl_InsuredValue = new System.Windows.Forms.TextBox();
            this.label_InsuredValue = new System.Windows.Forms.Label();
            this.ctrl_Calculate = new System.Windows.Forms.Button();
            this.ctrl_Cancle = new System.Windows.Forms.Button();
            this.ctrl_IncludeAdditionalProtection = new System.Windows.Forms.CheckBox();
            this.ctrl_AdditionalProtectionValue = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ctrl_Berechnungsart
            // 
            this.ctrl_CertificationType.FormattingEnabled = true;
            this.ctrl_CertificationType.Location = new System.Drawing.Point(165, 12);
            this.ctrl_CertificationType.Name = "ctrl_Berechnungsart";
            this.ctrl_CertificationType.Size = new System.Drawing.Size(231, 23);
            this.ctrl_CertificationType.TabIndex = 0;
            // 
            // label1
            // 
            this.label_CerificateType.AutoSize = true;
            this.label_CerificateType.Location = new System.Drawing.Point(21, 15);
            this.label_CerificateType.Name = "label1";
            this.label_CerificateType.Size = new System.Drawing.Size(90, 15);
            this.label_CerificateType.TabIndex = 1;
            this.label_CerificateType.Text = "Berechnungsart";
            // 
            // label2
            // 
            this.label_RiskFactor.AutoSize = true;
            this.label_RiskFactor.Location = new System.Drawing.Point(21, 60);
            this.label_RiskFactor.Name = "label2";
            this.label_RiskFactor.Size = new System.Drawing.Size(38, 15);
            this.label_RiskFactor.TabIndex = 3;
            this.label_RiskFactor.Text = "Risiko";
            // 
            // ctrl_Risiko
            // 
            this.ctrl_RiskFactor.FormattingEnabled = true;
            this.ctrl_RiskFactor.Location = new System.Drawing.Point(165, 58);
            this.ctrl_RiskFactor.Name = "ctrl_Risiko";
            this.ctrl_RiskFactor.Size = new System.Drawing.Size(231, 23);
            this.ctrl_RiskFactor.TabIndex = 2;
            // 
            // ctrl_HatWebshop
            // 
            this.ctrl_HasWebshop.Appearance = System.Windows.Forms.Appearance.Button;
            this.ctrl_HasWebshop.Location = new System.Drawing.Point(21, 177);
            this.ctrl_HasWebshop.Name = "ctrl_HatWebshop";
            this.ctrl_HasWebshop.Size = new System.Drawing.Size(375, 47);
            this.ctrl_HasWebshop.TabIndex = 6;
            this.ctrl_HasWebshop.TabStop = true;
            this.ctrl_HasWebshop.Text = "Hat Webshop";
            this.ctrl_HasWebshop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ctrl_HasWebshop.UseVisualStyleBackColor = true;
            // 
            // ctrl_Versicherungssumme
            // 
            this.ctrl_InsuredValue.Location = new System.Drawing.Point(165, 104);
            this.ctrl_InsuredValue.Name = "ctrl_Versicherungssumme";
            this.ctrl_InsuredValue.Size = new System.Drawing.Size(231, 23);
            this.ctrl_InsuredValue.TabIndex = 7;
            this.ctrl_InsuredValue.Text = "100000";
            this.ctrl_InsuredValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label_InsuredValue.AutoSize = true;
            this.label_InsuredValue.Location = new System.Drawing.Point(21, 107);
            this.label_InsuredValue.Name = "label3";
            this.label_InsuredValue.Size = new System.Drawing.Size(120, 15);
            this.label_InsuredValue.TabIndex = 8;
            this.label_InsuredValue.Text = "Versicherungssumme";
            // 
            // ctrl_Kalkuliere
            // 
            this.ctrl_Calculate.Location = new System.Drawing.Point(218, 261);
            this.ctrl_Calculate.Name = "ctrl_Kalkuliere";
            this.ctrl_Calculate.Size = new System.Drawing.Size(178, 44);
            this.ctrl_Calculate.TabIndex = 9;
            this.ctrl_Calculate.Text = "Kalkulieren";
            this.ctrl_Calculate.UseVisualStyleBackColor = true;
            this.ctrl_Calculate.Click += new System.EventHandler(this.ctrl_calculateCertificate_Click);
            // 
            // ctrl_Abbrechen
            // 
            this.ctrl_Cancle.Location = new System.Drawing.Point(21, 261);
            this.ctrl_Cancle.Name = "ctrl_Abbrechen";
            this.ctrl_Cancle.Size = new System.Drawing.Size(178, 44);
            this.ctrl_Cancle.TabIndex = 10;
            this.ctrl_Cancle.Text = "Abbrechen";
            this.ctrl_Cancle.UseVisualStyleBackColor = true;
            this.ctrl_Cancle.Click += new System.EventHandler(this.ctrl_cancle_Click);
            // 
            // ctrl_InkludiereZusatzschutz
            // 
            this.ctrl_IncludeAdditionalProtection.AutoSize = true;
            this.ctrl_IncludeAdditionalProtection.Location = new System.Drawing.Point(21, 152);
            this.ctrl_IncludeAdditionalProtection.Name = "ctrl_InkludiereZusatzschutz";
            this.ctrl_IncludeAdditionalProtection.Size = new System.Drawing.Size(94, 19);
            this.ctrl_IncludeAdditionalProtection.TabIndex = 11;
            this.ctrl_IncludeAdditionalProtection.Text = "Zusatzschutz";
            this.ctrl_IncludeAdditionalProtection.UseVisualStyleBackColor = true;
            this.ctrl_IncludeAdditionalProtection.CheckedChanged += new System.EventHandler(this.ctrl_IncludeAdditionalProtection_CheckedChanged);
            // 
            // ctrl_ZusatzschutzAufschlag
            // 
            this.ctrl_AdditionalProtectionValue.FormattingEnabled = true;
            this.ctrl_AdditionalProtectionValue.Items.AddRange(new object[] {
            "10%",
            "20%",
            "25%"});
            this.ctrl_AdditionalProtectionValue.Location = new System.Drawing.Point(165, 148);
            this.ctrl_AdditionalProtectionValue.Name = "ctrl_ZusatzschutzAufschlag";
            this.ctrl_AdditionalProtectionValue.Size = new System.Drawing.Size(231, 23);
            this.ctrl_AdditionalProtectionValue.TabIndex = 12;
            this.ctrl_AdditionalProtectionValue.Visible = false;
            // 
            // Form_NeueKalkulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 362);
            this.Controls.Add(this.ctrl_AdditionalProtectionValue);
            this.Controls.Add(this.ctrl_IncludeAdditionalProtection);
            this.Controls.Add(this.ctrl_Cancle);
            this.Controls.Add(this.ctrl_Calculate);
            this.Controls.Add(this.label_InsuredValue);
            this.Controls.Add(this.ctrl_InsuredValue);
            this.Controls.Add(this.ctrl_HasWebshop);
            this.Controls.Add(this.label_RiskFactor);
            this.Controls.Add(this.ctrl_RiskFactor);
            this.Controls.Add(this.label_CerificateType);
            this.Controls.Add(this.ctrl_CertificationType);
            this.Name = "Form_NeueKalkulation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neue Kalkulation";
            this.Load += new System.EventHandler(this.Form_NewCalculation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}