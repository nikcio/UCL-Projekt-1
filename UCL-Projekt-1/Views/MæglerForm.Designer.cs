namespace UCL_Projekt_1 {
    partial class MæglerForm {
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
            this.TilføjMægler = new System.Windows.Forms.Button();
            this.FlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.NavnValidering = new System.Windows.Forms.Label();
            this.Søg = new System.Windows.Forms.Button();
            this.Filtre = new System.Windows.Forms.Label();
            this.Adresse = new System.Windows.Forms.Label();
            this.Navn_tb = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TilføjMægler
            // 
            this.TilføjMægler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(224)))));
            this.TilføjMægler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TilføjMægler.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TilføjMægler.ForeColor = System.Drawing.Color.White;
            this.TilføjMægler.Location = new System.Drawing.Point(2, 12);
            this.TilføjMægler.Margin = new System.Windows.Forms.Padding(2, 2, 15, 2);
            this.TilføjMægler.Name = "TilføjMægler";
            this.TilføjMægler.Size = new System.Drawing.Size(145, 38);
            this.TilføjMægler.TabIndex = 0;
            this.TilføjMægler.Text = "Tilføj mægler";
            this.TilføjMægler.UseVisualStyleBackColor = false;
            this.TilføjMægler.Click += new System.EventHandler(this.TilføjMægler_Click);
            // 
            // FlowLayout
            // 
            this.FlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowLayout.AutoScroll = true;
            this.FlowLayout.Location = new System.Drawing.Point(9, 57);
            this.FlowLayout.Margin = new System.Windows.Forms.Padding(2);
            this.FlowLayout.Name = "FlowLayout";
            this.FlowLayout.Size = new System.Drawing.Size(1122, 541);
            this.FlowLayout.TabIndex = 1;
            // 
            // NavnValidering
            // 
            this.NavnValidering.AutoSize = true;
            this.NavnValidering.BackColor = System.Drawing.Color.Transparent;
            this.NavnValidering.ForeColor = System.Drawing.Color.Red;
            this.NavnValidering.Location = new System.Drawing.Point(369, 46);
            this.NavnValidering.Name = "NavnValidering";
            this.NavnValidering.Size = new System.Drawing.Size(0, 13);
            this.NavnValidering.TabIndex = 16;
            // 
            // Søg
            // 
            this.Søg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(224)))));
            this.Søg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Søg.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Søg.ForeColor = System.Drawing.Color.White;
            this.Søg.Location = new System.Drawing.Point(517, 13);
            this.Søg.Name = "Søg";
            this.Søg.Size = new System.Drawing.Size(80, 38);
            this.Søg.TabIndex = 15;
            this.Søg.Text = "Søg";
            this.Søg.UseVisualStyleBackColor = false;
            this.Søg.Click += new System.EventHandler(this.Søg_Click);
            // 
            // Filtre
            // 
            this.Filtre.AutoSize = true;
            this.Filtre.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Filtre.Location = new System.Drawing.Point(164, 20);
            this.Filtre.Margin = new System.Windows.Forms.Padding(2, 10, 2, 0);
            this.Filtre.Name = "Filtre";
            this.Filtre.Size = new System.Drawing.Size(55, 22);
            this.Filtre.TabIndex = 14;
            this.Filtre.Text = "Filtre:";
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Adresse.Location = new System.Drawing.Point(223, 20);
            this.Adresse.Margin = new System.Windows.Forms.Padding(2, 10, 2, 0);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(47, 22);
            this.Adresse.TabIndex = 10;
            this.Adresse.Text = "Navn";
            // 
            // Navn_tb
            // 
            this.Navn_tb.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Navn_tb.Location = new System.Drawing.Point(274, 17);
            this.Navn_tb.Margin = new System.Windows.Forms.Padding(2, 7, 15, 2);
            this.Navn_tb.Name = "Navn_tb";
            this.Navn_tb.Size = new System.Drawing.Size(225, 29);
            this.Navn_tb.TabIndex = 9;
            this.Navn_tb.TextChanged += new System.EventHandler(this.Navn_tb_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.TilføjMægler);
            this.flowLayoutPanel1.Controls.Add(this.Filtre);
            this.flowLayoutPanel1.Controls.Add(this.Adresse);
            this.flowLayoutPanel1.Controls.Add(this.Navn_tb);
            this.flowLayoutPanel1.Controls.Add(this.Søg);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1140, 55);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // MæglerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 608);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.NavnValidering);
            this.Controls.Add(this.FlowLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MæglerForm";
            this.Text = "MæglerForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TilføjMægler;
        private System.Windows.Forms.FlowLayoutPanel FlowLayout;
        private System.Windows.Forms.Label NavnValidering;
        private System.Windows.Forms.Button Søg;
        private System.Windows.Forms.Label Filtre;
        private System.Windows.Forms.Label Adresse;
        private System.Windows.Forms.TextBox Navn_tb;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}