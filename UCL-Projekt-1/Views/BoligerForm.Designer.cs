namespace UCL_Projekt_1 {
    partial class BoligerForm {
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
            this.TilføjBolig = new System.Windows.Forms.Button();
            this.FlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.Adresse_tb = new System.Windows.Forms.TextBox();
            this.Adresse = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.BoligId = new System.Windows.Forms.TextBox();
            this.BoligIdValidation = new System.Windows.Forms.Label();
            this.Filtre = new System.Windows.Forms.Label();
            this.Søg = new System.Windows.Forms.Button();
            this.AdresseValidering = new System.Windows.Forms.Label();
            this.HeaderMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.HeaderMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TilføjBolig
            // 
            this.TilføjBolig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(224)))));
            this.TilføjBolig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TilføjBolig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TilføjBolig.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.TilføjBolig.ForeColor = System.Drawing.Color.White;
            this.TilføjBolig.Location = new System.Drawing.Point(8, 12);
            this.TilføjBolig.Margin = new System.Windows.Forms.Padding(2, 2, 15, 2);
            this.TilføjBolig.Name = "TilføjBolig";
            this.TilføjBolig.Size = new System.Drawing.Size(145, 38);
            this.TilføjBolig.TabIndex = 0;
            this.TilføjBolig.Text = "Tilføj Bolig";
            this.TilføjBolig.UseVisualStyleBackColor = false;
            this.TilføjBolig.Click += new System.EventHandler(this.TilføjBolig_Click);
            // 
            // FlowLayout
            // 
            this.FlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowLayout.AutoScroll = true;
            this.FlowLayout.Location = new System.Drawing.Point(9, 72);
            this.FlowLayout.Margin = new System.Windows.Forms.Padding(2);
            this.FlowLayout.Name = "FlowLayout";
            this.FlowLayout.Size = new System.Drawing.Size(1122, 526);
            this.FlowLayout.TabIndex = 0;
            // 
            // Adresse_tb
            // 
            this.Adresse_tb.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Adresse_tb.Location = new System.Drawing.Point(469, 17);
            this.Adresse_tb.Margin = new System.Windows.Forms.Padding(2, 7, 15, 2);
            this.Adresse_tb.Name = "Adresse_tb";
            this.Adresse_tb.Size = new System.Drawing.Size(225, 29);
            this.Adresse_tb.TabIndex = 1;
            this.Adresse_tb.TextChanged += new System.EventHandler(this.Adresse_tb_TextChanged);
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Adresse.Location = new System.Drawing.Point(399, 20);
            this.Adresse.Margin = new System.Windows.Forms.Padding(2, 10, 2, 0);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(66, 22);
            this.Adresse.TabIndex = 2;
            this.Adresse.Text = "Adresse";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(233, 20);
            this.Id.Margin = new System.Windows.Forms.Padding(2, 10, 2, 0);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(24, 22);
            this.Id.TabIndex = 3;
            this.Id.Text = "Id";
            // 
            // BoligId
            // 
            this.BoligId.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.BoligId.Location = new System.Drawing.Point(261, 17);
            this.BoligId.Margin = new System.Windows.Forms.Padding(2, 7, 15, 2);
            this.BoligId.Name = "BoligId";
            this.BoligId.Size = new System.Drawing.Size(121, 29);
            this.BoligId.TabIndex = 4;
            this.BoligId.TextChanged += new System.EventHandler(this.BoligId_TextChanged);
            // 
            // BoligIdValidation
            // 
            this.BoligIdValidation.AutoSize = true;
            this.BoligIdValidation.ForeColor = System.Drawing.Color.Red;
            this.BoligIdValidation.Location = new System.Drawing.Point(229, 10);
            this.BoligIdValidation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BoligIdValidation.Name = "BoligIdValidation";
            this.BoligIdValidation.Size = new System.Drawing.Size(0, 13);
            this.BoligIdValidation.TabIndex = 5;
            // 
            // Filtre
            // 
            this.Filtre.AutoSize = true;
            this.Filtre.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Filtre.Location = new System.Drawing.Point(170, 20);
            this.Filtre.Margin = new System.Windows.Forms.Padding(2, 10, 2, 0);
            this.Filtre.Name = "Filtre";
            this.Filtre.Size = new System.Drawing.Size(55, 22);
            this.Filtre.TabIndex = 6;
            this.Filtre.Text = "Filtre:";
            // 
            // Søg
            // 
            this.Søg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(224)))));
            this.Søg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Søg.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Søg.ForeColor = System.Drawing.Color.White;
            this.Søg.Location = new System.Drawing.Point(712, 13);
            this.Søg.Name = "Søg";
            this.Søg.Size = new System.Drawing.Size(80, 38);
            this.Søg.TabIndex = 7;
            this.Søg.Text = "Søg";
            this.Søg.UseVisualStyleBackColor = false;
            this.Søg.Click += new System.EventHandler(this.Søg_Click);
            // 
            // AdresseValidering
            // 
            this.AdresseValidering.AutoSize = true;
            this.AdresseValidering.BackColor = System.Drawing.Color.Transparent;
            this.AdresseValidering.ForeColor = System.Drawing.Color.Red;
            this.AdresseValidering.Location = new System.Drawing.Point(3, 10);
            this.AdresseValidering.Name = "AdresseValidering";
            this.AdresseValidering.Size = new System.Drawing.Size(0, 13);
            this.AdresseValidering.TabIndex = 8;
            // 
            // HeaderMenu
            // 
            this.HeaderMenu.Controls.Add(this.AdresseValidering);
            this.HeaderMenu.Controls.Add(this.TilføjBolig);
            this.HeaderMenu.Controls.Add(this.Filtre);
            this.HeaderMenu.Controls.Add(this.BoligIdValidation);
            this.HeaderMenu.Controls.Add(this.Id);
            this.HeaderMenu.Controls.Add(this.BoligId);
            this.HeaderMenu.Controls.Add(this.Adresse);
            this.HeaderMenu.Controls.Add(this.Adresse_tb);
            this.HeaderMenu.Controls.Add(this.Søg);
            this.HeaderMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderMenu.Location = new System.Drawing.Point(0, 0);
            this.HeaderMenu.Name = "HeaderMenu";
            this.HeaderMenu.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.HeaderMenu.Size = new System.Drawing.Size(1140, 56);
            this.HeaderMenu.TabIndex = 9;
            // 
            // BoligerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 608);
            this.Controls.Add(this.HeaderMenu);
            this.Controls.Add(this.FlowLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BoligerForm";
            this.Text = "BoligerForm";
            this.HeaderMenu.ResumeLayout(false);
            this.HeaderMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TilføjBolig;
        private System.Windows.Forms.FlowLayoutPanel FlowLayout;
        private System.Windows.Forms.TextBox Adresse_tb;
        private System.Windows.Forms.Label Adresse;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox BoligId;
        private System.Windows.Forms.Label BoligIdValidation;
        private System.Windows.Forms.Label Filtre;
        private System.Windows.Forms.Button Søg;
        private System.Windows.Forms.Label AdresseValidering;
        private System.Windows.Forms.FlowLayoutPanel HeaderMenu;
    }
}