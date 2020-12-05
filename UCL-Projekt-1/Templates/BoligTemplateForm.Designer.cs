namespace UCL_Projekt_1 {
    partial class BoligTemplateForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.SælgBolig = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SeBolig = new System.Windows.Forms.Button();
            this.Pris = new System.Windows.Forms.Label();
            this.By = new System.Windows.Forms.Label();
            this.Adresse = new System.Windows.Forms.Label();
            this.Bolig.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bolig
            // 
            this.Bolig.Controls.Add(this.label1);
            this.Bolig.Controls.Add(this.SælgBolig);
            this.Bolig.Controls.Add(this.panel1);
            this.Bolig.Controls.Add(this.SeBolig);
            this.Bolig.Controls.Add(this.Pris);
            this.Bolig.Controls.Add(this.By);
            this.Bolig.Controls.Add(this.Adresse);
            this.Bolig.Location = new System.Drawing.Point(37, 33);
            this.Bolig.Margin = new System.Windows.Forms.Padding(2);
            this.Bolig.Name = "Bolig";
            this.Bolig.Size = new System.Drawing.Size(275, 156);
            this.Bolig.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pris:";
            // 
            // SælgBolig
            // 
            this.SælgBolig.BackColor = System.Drawing.Color.Transparent;
            this.SælgBolig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SælgBolig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(154)))), ((int)(((byte)(224)))));
            this.SælgBolig.FlatAppearance.BorderSize = 2;
            this.SælgBolig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(154)))), ((int)(((byte)(224)))));
            this.SælgBolig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SælgBolig.Font = new System.Drawing.Font("Roboto Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SælgBolig.ForeColor = System.Drawing.Color.Black;
            this.SælgBolig.Location = new System.Drawing.Point(144, 73);
            this.SælgBolig.Margin = new System.Windows.Forms.Padding(2);
            this.SælgBolig.Name = "SælgBolig";
            this.SælgBolig.Size = new System.Drawing.Size(120, 30);
            this.SælgBolig.TabIndex = 5;
            this.SælgBolig.Text = "Sælg bolig";
            this.SælgBolig.UseVisualStyleBackColor = false;
            this.SælgBolig.Click += new System.EventHandler(this.SælgBolig_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(74)))), ((int)(((byte)(77)))));
            this.panel1.Location = new System.Drawing.Point(7, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 1);
            this.panel1.TabIndex = 4;
            // 
            // SeBolig
            // 
            this.SeBolig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(154)))), ((int)(((byte)(224)))));
            this.SeBolig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SeBolig.FlatAppearance.BorderSize = 0;
            this.SeBolig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(113)))), ((int)(((byte)(185)))));
            this.SeBolig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeBolig.Font = new System.Drawing.Font("Roboto Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SeBolig.ForeColor = System.Drawing.Color.White;
            this.SeBolig.Location = new System.Drawing.Point(7, 73);
            this.SeBolig.Margin = new System.Windows.Forms.Padding(2);
            this.SeBolig.Name = "SeBolig";
            this.SeBolig.Size = new System.Drawing.Size(120, 30);
            this.SeBolig.TabIndex = 3;
            this.SeBolig.Text = "Rediger bolig";
            this.SeBolig.UseVisualStyleBackColor = false;
            this.SeBolig.Click += new System.EventHandler(this.SeBolig_Click);
            // 
            // Pris
            // 
            this.Pris.AutoSize = true;
            this.Pris.Font = new System.Drawing.Font("Roboto Condensed", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Pris.Location = new System.Drawing.Point(59, 115);
            this.Pris.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Pris.Name = "Pris";
            this.Pris.Size = new System.Drawing.Size(150, 27);
            this.Pris.TabIndex = 2;
            this.Pris.Text = "400.000.000 kr.";
            // 
            // By
            // 
            this.By.AutoSize = true;
            this.By.Font = new System.Drawing.Font("Roboto Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.By.Location = new System.Drawing.Point(2, 39);
            this.By.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.By.Name = "By";
            this.By.Size = new System.Drawing.Size(93, 25);
            this.By.TabIndex = 1;
            this.By.Text = "7323 Give";
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Adresse.Location = new System.Drawing.Point(2, 0);
            this.Adresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(188, 29);
            this.Adresse.TabIndex = 0;
            this.Adresse.Text = "Vejlevej 251, Lønå";
            // 
            // BoligTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 484);
            this.Controls.Add(this.Bolig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BoligTemplateForm";
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SælgBolig;
    }
}