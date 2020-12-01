namespace UCL_Projekt_1 {
    partial class MæglerTemplateForm {
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
            this.Mægler = new System.Windows.Forms.Panel();
            this.Navn = new System.Windows.Forms.Label();
            this.Ejendomsmægler = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Tlf = new System.Windows.Forms.Label();
            this.RedigerMægler = new System.Windows.Forms.Button();
            this.Mægler.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mægler
            // 
            this.Mægler.Controls.Add(this.RedigerMægler);
            this.Mægler.Controls.Add(this.Tlf);
            this.Mægler.Controls.Add(this.Email);
            this.Mægler.Controls.Add(this.Ejendomsmægler);
            this.Mægler.Controls.Add(this.Navn);
            this.Mægler.Location = new System.Drawing.Point(229, 131);
            this.Mægler.Name = "Mægler";
            this.Mægler.Size = new System.Drawing.Size(400, 346);
            this.Mægler.TabIndex = 0;
            // 
            // Navn
            // 
            this.Navn.AutoSize = true;
            this.Navn.Location = new System.Drawing.Point(57, 60);
            this.Navn.Name = "Navn";
            this.Navn.Size = new System.Drawing.Size(41, 17);
            this.Navn.TabIndex = 0;
            this.Navn.Text = "Navn";
            // 
            // Ejendomsmægler
            // 
            this.Ejendomsmægler.AutoSize = true;
            this.Ejendomsmægler.Location = new System.Drawing.Point(60, 96);
            this.Ejendomsmægler.Name = "Ejendomsmægler";
            this.Ejendomsmægler.Size = new System.Drawing.Size(118, 17);
            this.Ejendomsmægler.TabIndex = 1;
            this.Ejendomsmægler.Text = "Ejendomsmægler";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(60, 132);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(50, 17);
            this.Email.TabIndex = 2;
            this.Email.Text = "EMaiol";
            // 
            // Tlf
            // 
            this.Tlf.AutoSize = true;
            this.Tlf.Location = new System.Drawing.Point(60, 171);
            this.Tlf.Name = "Tlf";
            this.Tlf.Size = new System.Drawing.Size(24, 17);
            this.Tlf.TabIndex = 3;
            this.Tlf.Text = "Tlf";
            // 
            // RedigerMægler
            // 
            this.RedigerMægler.Location = new System.Drawing.Point(63, 203);
            this.RedigerMægler.Name = "RedigerMægler";
            this.RedigerMægler.Size = new System.Drawing.Size(115, 45);
            this.RedigerMægler.TabIndex = 4;
            this.RedigerMægler.Text = "Rediger mægler";
            this.RedigerMægler.UseVisualStyleBackColor = true;
            this.RedigerMægler.Click += new System.EventHandler(this.RedigerMægler_Click);
            // 
            // MæglerTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 606);
            this.Controls.Add(this.Mægler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MæglerTemplateForm";
            this.Text = "MæglerTemplateForm";
            this.Mægler.ResumeLayout(false);
            this.Mægler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Mægler;
        private System.Windows.Forms.Button RedigerMægler;
        private System.Windows.Forms.Label Tlf;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Ejendomsmægler;
        private System.Windows.Forms.Label Navn;
    }
}