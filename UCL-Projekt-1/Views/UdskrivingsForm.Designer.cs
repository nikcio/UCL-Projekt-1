﻿namespace UCL_Projekt_1 {
    partial class UdskrivingsForm {
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
            this.UdskrivInformation = new System.Windows.Forms.Button();
            this.FlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.Område_tb = new System.Windows.Forms.TextBox();
            this.Område = new System.Windows.Forms.Label();
            this.Solgt_checkBox = new System.Windows.Forms.CheckBox();
            this.Startdato = new System.Windows.Forms.TextBox();
            this.Slutdato = new System.Windows.Forms.TextBox();
            this.Startdato_label = new System.Windows.Forms.Label();
            this.Slutdato_label = new System.Windows.Forms.Label();
            this.Søg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UdskrivInformation
            // 
            this.UdskrivInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(224)))));
            this.UdskrivInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UdskrivInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.UdskrivInformation.ForeColor = System.Drawing.Color.White;
            this.UdskrivInformation.Location = new System.Drawing.Point(13, 12);
            this.UdskrivInformation.Margin = new System.Windows.Forms.Padding(2, 2, 15, 2);
            this.UdskrivInformation.Name = "UdskrivInformation";
            this.UdskrivInformation.Size = new System.Drawing.Size(180, 41);
            this.UdskrivInformation.TabIndex = 5;
            this.UdskrivInformation.Text = "Udskriv information";
            this.UdskrivInformation.UseVisualStyleBackColor = false;
            this.UdskrivInformation.Click += new System.EventHandler(this.UdskrivInformation_Click);
            // 
            // FlowLayout
            // 
            this.FlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowLayout.AutoScroll = true;
            this.FlowLayout.Location = new System.Drawing.Point(9, 68);
            this.FlowLayout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FlowLayout.Name = "FlowLayout";
            this.FlowLayout.Size = new System.Drawing.Size(1263, 529);
            this.FlowLayout.TabIndex = 6;
            // 
            // Område_tb
            // 
            this.Område_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Område_tb.Location = new System.Drawing.Point(356, 17);
            this.Område_tb.Margin = new System.Windows.Forms.Padding(2, 7, 15, 2);
            this.Område_tb.Name = "Område_tb";
            this.Område_tb.Size = new System.Drawing.Size(76, 28);
            this.Område_tb.TabIndex = 7;
            // 
            // Område
            // 
            this.Område.AutoSize = true;
            this.Område.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Område.Location = new System.Drawing.Point(276, 20);
            this.Område.Margin = new System.Windows.Forms.Padding(2, 10, 2, 0);
            this.Område.Name = "Område";
            this.Område.Size = new System.Drawing.Size(76, 22);
            this.Område.TabIndex = 8;
            this.Område.Text = "Adresse";
            // 
            // Solgt_checkBox
            // 
            this.Solgt_checkBox.AutoSize = true;
            this.Solgt_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Solgt_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Solgt_checkBox.Location = new System.Drawing.Point(449, 17);
            this.Solgt_checkBox.Margin = new System.Windows.Forms.Padding(2, 7, 15, 2);
            this.Solgt_checkBox.Name = "Solgt_checkBox";
            this.Solgt_checkBox.Size = new System.Drawing.Size(70, 26);
            this.Solgt_checkBox.TabIndex = 10;
            this.Solgt_checkBox.Text = "Solgt";
            this.Solgt_checkBox.UseVisualStyleBackColor = true;
            this.Solgt_checkBox.CheckedChanged += new System.EventHandler(this.Solgt_checkBox_CheckedChanged);
            // 
            // Startdato
            // 
            this.Startdato.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Startdato.Location = new System.Drawing.Point(623, 17);
            this.Startdato.Margin = new System.Windows.Forms.Padding(2, 7, 15, 2);
            this.Startdato.Name = "Startdato";
            this.Startdato.Size = new System.Drawing.Size(76, 28);
            this.Startdato.TabIndex = 11;
            // 
            // Slutdato
            // 
            this.Slutdato.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Slutdato.Location = new System.Drawing.Point(796, 17);
            this.Slutdato.Margin = new System.Windows.Forms.Padding(2, 7, 15, 2);
            this.Slutdato.Name = "Slutdato";
            this.Slutdato.Size = new System.Drawing.Size(76, 28);
            this.Slutdato.TabIndex = 12;
            // 
            // Startdato_label
            // 
            this.Startdato_label.AutoSize = true;
            this.Startdato_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Startdato_label.Location = new System.Drawing.Point(536, 20);
            this.Startdato_label.Margin = new System.Windows.Forms.Padding(2, 10, 2, 0);
            this.Startdato_label.Name = "Startdato_label";
            this.Startdato_label.Size = new System.Drawing.Size(83, 22);
            this.Startdato_label.TabIndex = 13;
            this.Startdato_label.Text = "Startdato";
            // 
            // Slutdato_label
            // 
            this.Slutdato_label.AutoSize = true;
            this.Slutdato_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Slutdato_label.Location = new System.Drawing.Point(716, 20);
            this.Slutdato_label.Margin = new System.Windows.Forms.Padding(2, 10, 2, 0);
            this.Slutdato_label.Name = "Slutdato_label";
            this.Slutdato_label.Size = new System.Drawing.Size(76, 22);
            this.Slutdato_label.TabIndex = 14;
            this.Slutdato_label.Text = "Slutdato";
            // 
            // Søg
            // 
            this.Søg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(157)))), ((int)(((byte)(224)))));
            this.Søg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Søg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Søg.ForeColor = System.Drawing.Color.White;
            this.Søg.Location = new System.Drawing.Point(1135, 12);
            this.Søg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Søg.Name = "Søg";
            this.Søg.Size = new System.Drawing.Size(71, 41);
            this.Søg.TabIndex = 15;
            this.Søg.Text = "Søg";
            this.Søg.UseVisualStyleBackColor = false;
            this.Søg.Click += new System.EventHandler(this.Søg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(210, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 10, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Filter:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.UdskrivInformation);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.Område);
            this.flowLayoutPanel1.Controls.Add(this.Område_tb);
            this.flowLayoutPanel1.Controls.Add(this.Solgt_checkBox);
            this.flowLayoutPanel1.Controls.Add(this.Startdato_label);
            this.flowLayoutPanel1.Controls.Add(this.Startdato);
            this.flowLayoutPanel1.Controls.Add(this.Slutdato_label);
            this.flowLayoutPanel1.Controls.Add(this.Slutdato);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.Søg);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(11, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1263, 62);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(889, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 10, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Salgsbeløb";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox1.Location = new System.Drawing.Point(992, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 7, 15, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 28);
            this.textBox1.TabIndex = 17;
            // 
            // UdskrivingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1283, 608);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.FlowLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UdskrivingsForm";
            this.Text = "UdskrivingsForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UdskrivInformation;
        private System.Windows.Forms.FlowLayoutPanel FlowLayout;
        private System.Windows.Forms.TextBox Område_tb;
        private System.Windows.Forms.Label Område;
        private System.Windows.Forms.CheckBox Solgt_checkBox;
        private System.Windows.Forms.TextBox Startdato;
        private System.Windows.Forms.TextBox Slutdato;
        private System.Windows.Forms.Label Startdato_label;
        private System.Windows.Forms.Label Slutdato_label;
        private System.Windows.Forms.Button Søg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}