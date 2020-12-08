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
            this.TilføjMægler.Location = new System.Drawing.Point(18, 14);
            this.TilføjMægler.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.TilføjMægler.Name = "TilføjMægler";
            this.TilføjMægler.Size = new System.Drawing.Size(193, 47);
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
            this.FlowLayout.Location = new System.Drawing.Point(12, 70);
            this.FlowLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FlowLayout.Name = "FlowLayout";
            this.FlowLayout.Size = new System.Drawing.Size(1496, 666);
            this.FlowLayout.TabIndex = 1;
            // 
            // NavnValidering
            // 
            this.NavnValidering.AutoSize = true;
            this.NavnValidering.BackColor = System.Drawing.Color.Transparent;
            this.NavnValidering.ForeColor = System.Drawing.Color.Red;
            this.NavnValidering.Location = new System.Drawing.Point(492, 57);
            this.NavnValidering.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NavnValidering.Name = "NavnValidering";
            this.NavnValidering.Size = new System.Drawing.Size(0, 17);
            this.NavnValidering.TabIndex = 16;
            // 
            // Søg
            // 
            this.Søg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(224)))));
            this.Søg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Søg.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Søg.ForeColor = System.Drawing.Color.White;
            this.Søg.Location = new System.Drawing.Point(672, 16);
            this.Søg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Søg.Name = "Søg";
            this.Søg.Size = new System.Drawing.Size(107, 47);
            this.Søg.TabIndex = 15;
            this.Søg.Text = "Søg";
            this.Søg.UseVisualStyleBackColor = false;
            this.Søg.Click += new System.EventHandler(this.Søg_Click);
            // 
            // Filtre
            // 
            this.Filtre.AutoSize = true;
            this.Filtre.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Filtre.Location = new System.Drawing.Point(234, 24);
            this.Filtre.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.Filtre.Name = "Filtre";
            this.Filtre.Size = new System.Drawing.Size(55, 23);
            this.Filtre.TabIndex = 14;
            this.Filtre.Text = "Filtre:";
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Adresse.Location = new System.Drawing.Point(295, 24);
            this.Adresse.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(48, 23);
            this.Adresse.TabIndex = 10;
            this.Adresse.Text = "Navn";
            // 
            // Navn_tb
            // 
            this.Navn_tb.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Navn_tb.Location = new System.Drawing.Point(349, 21);
            this.Navn_tb.Margin = new System.Windows.Forms.Padding(3, 9, 20, 2);
            this.Navn_tb.Name = "Navn_tb";
            this.Navn_tb.Size = new System.Drawing.Size(299, 29);
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
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15, 12, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1520, 68);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // MæglerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1520, 748);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.NavnValidering);
            this.Controls.Add(this.FlowLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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