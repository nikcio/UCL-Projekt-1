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
            this.RedigerMægler = new System.Windows.Forms.Button();
            this.Tlf = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Ejendomsmægler = new System.Windows.Forms.Label();
            this.Navn = new System.Windows.Forms.Label();
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
            this.Mægler.Location = new System.Drawing.Point(163, 113);
            this.Mægler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Mægler.Name = "Mægler";
            this.Mægler.Size = new System.Drawing.Size(275, 181);
            this.Mægler.TabIndex = 0;
            // 
            // RedigerMægler
            // 
            this.RedigerMægler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(224)))));
            this.RedigerMægler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedigerMægler.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.RedigerMægler.ForeColor = System.Drawing.Color.White;
            this.RedigerMægler.Location = new System.Drawing.Point(63, 132);
            this.RedigerMægler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RedigerMægler.Name = "RedigerMægler";
            this.RedigerMægler.Size = new System.Drawing.Size(141, 37);
            this.RedigerMægler.TabIndex = 4;
            this.RedigerMægler.Text = "Rediger mægler";
            this.RedigerMægler.UseVisualStyleBackColor = false;
            this.RedigerMægler.Click += new System.EventHandler(this.RedigerMægler_Click);
            // 
            // Tlf
            // 
            this.Tlf.AutoSize = true;
            this.Tlf.Font = new System.Drawing.Font("Roboto Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tlf.Location = new System.Drawing.Point(6, 101);
            this.Tlf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Tlf.Name = "Tlf";
            this.Tlf.Size = new System.Drawing.Size(110, 19);
            this.Tlf.TabIndex = 3;
            this.Tlf.Text = "Tlf: 12 34 56 78";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Roboto Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Email.Location = new System.Drawing.Point(6, 70);
            this.Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(202, 19);
            this.Email.TabIndex = 2;
            this.Email.Text = "Email: nikolajgive@gmail.com";
            // 
            // Ejendomsmægler
            // 
            this.Ejendomsmægler.AutoSize = true;
            this.Ejendomsmægler.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Ejendomsmægler.Location = new System.Drawing.Point(5, 38);
            this.Ejendomsmægler.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ejendomsmægler.Name = "Ejendomsmægler";
            this.Ejendomsmægler.Size = new System.Drawing.Size(133, 22);
            this.Ejendomsmægler.TabIndex = 1;
            this.Ejendomsmægler.Text = "Ejendomsmægler";
            // 
            // Navn
            // 
            this.Navn.AutoSize = true;
            this.Navn.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Navn.Location = new System.Drawing.Point(2, 0);
            this.Navn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Navn.Name = "Navn";
            this.Navn.Size = new System.Drawing.Size(221, 29);
            this.Navn.TabIndex = 0;
            this.Navn.Text = "Nikolaj Brask-Nielsen";
            // 
            // MæglerTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 492);
            this.Controls.Add(this.Mægler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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