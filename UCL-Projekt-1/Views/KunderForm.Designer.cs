namespace UCL_Projekt_1 {
    partial class KunderForm {
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
            this.TilføjKunde = new System.Windows.Forms.Button();
            this.FlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.NavnValidering = new System.Windows.Forms.Label();
            this.Søg = new System.Windows.Forms.Button();
            this.Filtre = new System.Windows.Forms.Label();
            this.Adresse = new System.Windows.Forms.Label();
            this.Navn_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TilføjKunde
            // 
            this.TilføjKunde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(224)))));
            this.TilføjKunde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TilføjKunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TilføjKunde.ForeColor = System.Drawing.Color.White;
            this.TilføjKunde.Location = new System.Drawing.Point(13, 12);
            this.TilføjKunde.Margin = new System.Windows.Forms.Padding(2, 2, 15, 2);
            this.TilføjKunde.Name = "TilføjKunde";
            this.TilføjKunde.Size = new System.Drawing.Size(145, 38);
            this.TilføjKunde.TabIndex = 0;
            this.TilføjKunde.Text = "Tilføj kunde";
            this.TilføjKunde.UseVisualStyleBackColor = false;
            this.TilføjKunde.Click += new System.EventHandler(this.TilføjKunde_Click);
            // 
            // FlowLayout
            // 
            this.FlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowLayout.AutoScroll = true;
            this.FlowLayout.Location = new System.Drawing.Point(9, 122);
            this.FlowLayout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FlowLayout.Name = "FlowLayout";
            this.FlowLayout.Size = new System.Drawing.Size(1122, 476);
            this.FlowLayout.TabIndex = 1;
            // 
            // NavnValidering
            // 
            this.NavnValidering.AutoSize = true;
            this.NavnValidering.BackColor = System.Drawing.Color.Transparent;
            this.NavnValidering.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavnValidering.ForeColor = System.Drawing.Color.Red;
            this.NavnValidering.Location = new System.Drawing.Point(286, 0);
            this.NavnValidering.Name = "NavnValidering";
            this.NavnValidering.Size = new System.Drawing.Size(0, 13);
            this.NavnValidering.TabIndex = 21;
            // 
            // Søg
            // 
            this.Søg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(224)))));
            this.Søg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Søg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Søg.ForeColor = System.Drawing.Color.White;
            this.Søg.Location = new System.Drawing.Point(539, 12);
            this.Søg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Søg.Name = "Søg";
            this.Søg.Size = new System.Drawing.Size(80, 38);
            this.Søg.TabIndex = 20;
            this.Søg.Text = "Søg";
            this.Søg.UseVisualStyleBackColor = false;
            this.Søg.Click += new System.EventHandler(this.Søg_Click);
            // 
            // Filtre
            // 
            this.Filtre.AutoSize = true;
            this.Filtre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Filtre.Location = new System.Drawing.Point(175, 20);
            this.Filtre.Margin = new System.Windows.Forms.Padding(2, 10, 2, 0);
            this.Filtre.Name = "Filtre";
            this.Filtre.Size = new System.Drawing.Size(62, 22);
            this.Filtre.TabIndex = 19;
            this.Filtre.Text = "Filtre:";
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Adresse.Location = new System.Drawing.Point(241, 20);
            this.Adresse.Margin = new System.Windows.Forms.Padding(2, 10, 2, 0);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(52, 22);
            this.Adresse.TabIndex = 18;
            this.Adresse.Text = "Navn";
            // 
            // Navn_tb
            // 
            this.Navn_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Navn_tb.Location = new System.Drawing.Point(297, 17);
            this.Navn_tb.Margin = new System.Windows.Forms.Padding(2, 7, 15, 2);
            this.Navn_tb.Name = "Navn_tb";
            this.Navn_tb.Size = new System.Drawing.Size(225, 28);
            this.Navn_tb.TabIndex = 17;
            this.Navn_tb.TextChanged += new System.EventHandler(this.Navn_tb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kunde id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(160, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Navn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(400, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(532, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "Email";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.TilføjKunde);
            this.flowLayoutPanel1.Controls.Add(this.Filtre);
            this.flowLayoutPanel1.Controls.Add(this.Adresse);
            this.flowLayoutPanel1.Controls.Add(this.Navn_tb);
            this.flowLayoutPanel1.Controls.Add(this.Søg);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(11, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1140, 69);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label6.Location = new System.Drawing.Point(828, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 26);
            this.label6.TabIndex = 26;
            this.label6.Text = "Sælger";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(760, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 26);
            this.label5.TabIndex = 25;
            this.label5.Text = "Køber";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.NavnValidering);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(8, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 48);
            this.panel1.TabIndex = 28;
            // 
            // KunderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 608);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.FlowLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KunderForm";
            this.Text = "KunderForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TilføjKunde;
        private System.Windows.Forms.FlowLayoutPanel FlowLayout;
        private System.Windows.Forms.Label NavnValidering;
        private System.Windows.Forms.Button Søg;
        private System.Windows.Forms.Label Filtre;
        private System.Windows.Forms.Label Adresse;
        private System.Windows.Forms.TextBox Navn_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}