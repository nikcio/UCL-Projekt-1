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
            this.RedigerKunde = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.Label();
            this.Tlf = new System.Windows.Forms.Label();
            this.Navn = new System.Windows.Forms.Label();
            this.KundeId = new System.Windows.Forms.Label();
            this.Køber = new System.Windows.Forms.CheckBox();
            this.Sælger = new System.Windows.Forms.CheckBox();
            this.Kunde.SuspendLayout();
            this.SuspendLayout();
            // 
            // Kunde
            // 
            this.Kunde.Controls.Add(this.Sælger);
            this.Kunde.Controls.Add(this.Køber);
            this.Kunde.Controls.Add(this.RedigerKunde);
            this.Kunde.Controls.Add(this.Email);
            this.Kunde.Controls.Add(this.Tlf);
            this.Kunde.Controls.Add(this.Navn);
            this.Kunde.Controls.Add(this.KundeId);
            this.Kunde.Location = new System.Drawing.Point(40, 82);
            this.Kunde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Kunde.Name = "Kunde";
            this.Kunde.Size = new System.Drawing.Size(1100, 74);
            this.Kunde.TabIndex = 0;
            // 
            // RedigerKunde
            // 
            this.RedigerKunde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(224)))));
            this.RedigerKunde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedigerKunde.Font = new System.Drawing.Font("Roboto Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.RedigerKunde.ForeColor = System.Drawing.Color.White;
            this.RedigerKunde.Location = new System.Drawing.Point(932, 18);
            this.RedigerKunde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RedigerKunde.Name = "RedigerKunde";
            this.RedigerKunde.Size = new System.Drawing.Size(156, 38);
            this.RedigerKunde.TabIndex = 5;
            this.RedigerKunde.Text = "Rediger kunde";
            this.RedigerKunde.UseVisualStyleBackColor = false;
            this.RedigerKunde.Click += new System.EventHandler(this.RedigerKunde_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Roboto Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Email.Location = new System.Drawing.Point(531, 25);
            this.Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(195, 24);
            this.Email.TabIndex = 1;
            this.Email.Text = "nikolajgive@gmail.com";
            // 
            // Tlf
            // 
            this.Tlf.AutoSize = true;
            this.Tlf.Font = new System.Drawing.Font("Roboto Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tlf.Location = new System.Drawing.Point(400, 25);
            this.Tlf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Tlf.Name = "Tlf";
            this.Tlf.Size = new System.Drawing.Size(105, 24);
            this.Tlf.TabIndex = 2;
            this.Tlf.Text = "12 34 56 78";
            // 
            // Navn
            // 
            this.Navn.AutoSize = true;
            this.Navn.Font = new System.Drawing.Font("Roboto Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Navn.Location = new System.Drawing.Point(160, 25);
            this.Navn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Navn.Name = "Navn";
            this.Navn.Size = new System.Drawing.Size(179, 24);
            this.Navn.TabIndex = 1;
            this.Navn.Text = "Nikolaj Brask-Nielsen";
            // 
            // KundeId
            // 
            this.KundeId.AutoSize = true;
            this.KundeId.Font = new System.Drawing.Font("Roboto Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.KundeId.Location = new System.Drawing.Point(20, 25);
            this.KundeId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.KundeId.Name = "KundeId";
            this.KundeId.Size = new System.Drawing.Size(80, 24);
            this.KundeId.TabIndex = 0;
            this.KundeId.Text = "Kunde id";
            // 
            // Køber
            // 
            this.Køber.AutoSize = true;
            this.Køber.Font = new System.Drawing.Font("Roboto Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Køber.Location = new System.Drawing.Point(796, 31);
            this.Køber.Name = "Køber";
            this.Køber.Size = new System.Drawing.Size(15, 14);
            this.Køber.TabIndex = 1;
            this.Køber.UseVisualStyleBackColor = true;
            // 
            // Sælger
            // 
            this.Sælger.AutoSize = true;
            this.Sælger.Font = new System.Drawing.Font("Roboto Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Sælger.Location = new System.Drawing.Point(860, 31);
            this.Sælger.Name = "Sælger";
            this.Sælger.Size = new System.Drawing.Size(15, 14);
            this.Sælger.TabIndex = 6;
            this.Sælger.UseVisualStyleBackColor = true;
            // 
            // KundeTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 505);
            this.Controls.Add(this.Kunde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KundeTemplateForm";
            this.Text = "KundeTemplateForm";
            this.Kunde.ResumeLayout(false);
            this.Kunde.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Kunde;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Tlf;
        private System.Windows.Forms.Label Navn;
        private System.Windows.Forms.Label KundeId;
        private System.Windows.Forms.Button RedigerKunde;
        private System.Windows.Forms.CheckBox Sælger;
        private System.Windows.Forms.CheckBox Køber;
    }
}