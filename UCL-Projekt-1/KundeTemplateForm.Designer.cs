namespace UCL_Projekt_1 {
    partial class KundeTemplateForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Kunde = new System.Windows.Forms.Panel();
            this.KundeId = new System.Windows.Forms.Label();
            this.Navn = new System.Windows.Forms.Label();
            this.Tlf = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Sælger = new System.Windows.Forms.Label();
            this.Køber = new System.Windows.Forms.Label();
            this.Kunde.SuspendLayout();
            this.SuspendLayout();
            // 
            // Kunde
            // 
            this.Kunde.Controls.Add(this.Køber);
            this.Kunde.Controls.Add(this.Sælger);
            this.Kunde.Controls.Add(this.Email);
            this.Kunde.Controls.Add(this.Tlf);
            this.Kunde.Controls.Add(this.Navn);
            this.Kunde.Controls.Add(this.KundeId);
            this.Kunde.Location = new System.Drawing.Point(53, 101);
            this.Kunde.Name = "Kunde";
            this.Kunde.Size = new System.Drawing.Size(455, 91);
            this.Kunde.TabIndex = 0;
            // 
            // KundeId
            // 
            this.KundeId.AutoSize = true;
            this.KundeId.Location = new System.Drawing.Point(35, 37);
            this.KundeId.Name = "KundeId";
            this.KundeId.Size = new System.Drawing.Size(64, 17);
            this.KundeId.TabIndex = 0;
            this.KundeId.Text = "Kunde id";
            // 
            // Navn
            // 
            this.Navn.AutoSize = true;
            this.Navn.Location = new System.Drawing.Point(121, 37);
            this.Navn.Name = "Navn";
            this.Navn.Size = new System.Drawing.Size(41, 17);
            this.Navn.TabIndex = 1;
            this.Navn.Text = "Navn";
            // 
            // Tlf
            // 
            this.Tlf.AutoSize = true;
            this.Tlf.Location = new System.Drawing.Point(169, 37);
            this.Tlf.Name = "Tlf";
            this.Tlf.Size = new System.Drawing.Size(19, 17);
            this.Tlf.TabIndex = 2;
            this.Tlf.Text = "tlf";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(218, 37);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 17);
            this.Email.TabIndex = 1;
            this.Email.Text = "EMail";
            // 
            // Sælger
            // 
            this.Sælger.AutoSize = true;
            this.Sælger.Location = new System.Drawing.Point(297, 37);
            this.Sælger.Name = "Sælger";
            this.Sælger.Size = new System.Drawing.Size(54, 17);
            this.Sælger.TabIndex = 3;
            this.Sælger.Text = "Sælger";
            // 
            // Køber
            // 
            this.Køber.AutoSize = true;
            this.Køber.Location = new System.Drawing.Point(372, 37);
            this.Køber.Name = "Køber";
            this.Køber.Size = new System.Drawing.Size(46, 17);
            this.Køber.TabIndex = 4;
            this.Køber.Text = "Køber";
            // 
            // KundeTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 621);
            this.Controls.Add(this.Kunde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KundeTemplateForm";
            this.Text = "KundeTemplateForm";
            this.Kunde.ResumeLayout(false);
            this.Kunde.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Kunde;
        private System.Windows.Forms.Label Køber;
        private System.Windows.Forms.Label Sælger;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Tlf;
        private System.Windows.Forms.Label Navn;
        private System.Windows.Forms.Label KundeId;
    }
}