namespace UCL_Projekt_1 {
    partial class TemplateForm {
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
            this.Bolig = new System.Windows.Forms.Panel();
            this.Adresse = new System.Windows.Forms.Label();
            this.By = new System.Windows.Forms.Label();
            this.Pris = new System.Windows.Forms.Label();
            this.SeBolig = new System.Windows.Forms.Button();
            this.Bolig.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bolig
            // 
            this.Bolig.Controls.Add(this.SeBolig);
            this.Bolig.Controls.Add(this.Pris);
            this.Bolig.Controls.Add(this.By);
            this.Bolig.Controls.Add(this.Adresse);
            this.Bolig.Location = new System.Drawing.Point(49, 41);
            this.Bolig.Name = "Bolig";
            this.Bolig.Size = new System.Drawing.Size(327, 208);
            this.Bolig.TabIndex = 0;
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.Location = new System.Drawing.Point(23, 25);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(125, 17);
            this.Adresse.TabIndex = 0;
            this.Adresse.Text = "Vejlevej 251, Lønå";
            // 
            // By
            // 
            this.By.AutoSize = true;
            this.By.Location = new System.Drawing.Point(26, 58);
            this.By.Name = "By";
            this.By.Size = new System.Drawing.Size(73, 17);
            this.By.TabIndex = 1;
            this.By.Text = "7323 Give";
            // 
            // Pris
            // 
            this.Pris.AutoSize = true;
            this.Pris.Location = new System.Drawing.Point(209, 152);
            this.Pris.Name = "Pris";
            this.Pris.Size = new System.Drawing.Size(80, 17);
            this.Pris.TabIndex = 2;
            this.Pris.Text = "400.000 kr.";
            // 
            // SeBolig
            // 
            this.SeBolig.Location = new System.Drawing.Point(29, 145);
            this.SeBolig.Name = "SeBolig";
            this.SeBolig.Size = new System.Drawing.Size(84, 32);
            this.SeBolig.TabIndex = 3;
            this.SeBolig.Text = "Se bolig";
            this.SeBolig.UseVisualStyleBackColor = true;
            // 
            // TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 596);
            this.Controls.Add(this.Bolig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TemplateForm";
            this.Text = "TemplateForm";
            this.Bolig.ResumeLayout(false);
            this.Bolig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Bolig;
        private System.Windows.Forms.Label By;
        private System.Windows.Forms.Label Adresse;
        private System.Windows.Forms.Button SeBolig;
        private System.Windows.Forms.Label Pris;
    }
}