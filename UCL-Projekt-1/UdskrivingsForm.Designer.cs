namespace UCL_Projekt_1 {
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
            this.button1 = new System.Windows.Forms.Button();
            this.FlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.Område_tb = new System.Windows.Forms.TextBox();
            this.Område = new System.Windows.Forms.Label();
            this.Solgt_checkBox = new System.Windows.Forms.CheckBox();
            this.Startdato = new System.Windows.Forms.TextBox();
            this.Slutdato = new System.Windows.Forms.TextBox();
            this.Startdato_label = new System.Windows.Forms.Label();
            this.Slutdato_label = new System.Windows.Forms.Label();
            this.Søg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1245, 642);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 69);
            this.button1.TabIndex = 5;
            this.button1.Text = "Udskriv information";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FlowLayout
            // 
            this.FlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowLayout.AutoScroll = true;
            this.FlowLayout.Location = new System.Drawing.Point(12, 89);
            this.FlowLayout.Name = "FlowLayout";
            this.FlowLayout.Size = new System.Drawing.Size(1062, 622);
            this.FlowLayout.TabIndex = 6;
            // 
            // Område_tb
            // 
            this.Område_tb.Location = new System.Drawing.Point(102, 41);
            this.Område_tb.Name = "Område_tb";
            this.Område_tb.Size = new System.Drawing.Size(100, 22);
            this.Område_tb.TabIndex = 7;
            // 
            // Område
            // 
            this.Område.AutoSize = true;
            this.Område.Location = new System.Drawing.Point(37, 41);
            this.Område.Name = "Område";
            this.Område.Size = new System.Drawing.Size(59, 17);
            this.Område.TabIndex = 8;
            this.Område.Text = "Område";
            // 
            // Solgt_checkBox
            // 
            this.Solgt_checkBox.AutoSize = true;
            this.Solgt_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Solgt_checkBox.Location = new System.Drawing.Point(229, 40);
            this.Solgt_checkBox.Name = "Solgt_checkBox";
            this.Solgt_checkBox.Size = new System.Drawing.Size(62, 21);
            this.Solgt_checkBox.TabIndex = 10;
            this.Solgt_checkBox.Text = "Solgt";
            this.Solgt_checkBox.UseVisualStyleBackColor = true;
            // 
            // Startdato
            // 
            this.Startdato.Location = new System.Drawing.Point(387, 41);
            this.Startdato.Name = "Startdato";
            this.Startdato.Size = new System.Drawing.Size(100, 22);
            this.Startdato.TabIndex = 11;
            // 
            // Slutdato
            // 
            this.Slutdato.Location = new System.Drawing.Point(590, 41);
            this.Slutdato.Name = "Slutdato";
            this.Slutdato.Size = new System.Drawing.Size(100, 22);
            this.Slutdato.TabIndex = 12;
            // 
            // Startdato_label
            // 
            this.Startdato_label.AutoSize = true;
            this.Startdato_label.Location = new System.Drawing.Point(311, 41);
            this.Startdato_label.Name = "Startdato_label";
            this.Startdato_label.Size = new System.Drawing.Size(70, 17);
            this.Startdato_label.TabIndex = 13;
            this.Startdato_label.Text = "Start dato";
            // 
            // Slutdato_label
            // 
            this.Slutdato_label.AutoSize = true;
            this.Slutdato_label.Location = new System.Drawing.Point(520, 41);
            this.Slutdato_label.Name = "Slutdato_label";
            this.Slutdato_label.Size = new System.Drawing.Size(64, 17);
            this.Slutdato_label.TabIndex = 14;
            this.Slutdato_label.Text = "Slut dato";
            // 
            // Søg
            // 
            this.Søg.Location = new System.Drawing.Point(719, 41);
            this.Søg.Name = "Søg";
            this.Søg.Size = new System.Drawing.Size(75, 23);
            this.Søg.TabIndex = 15;
            this.Søg.Text = "Søg";
            this.Søg.UseVisualStyleBackColor = true;
            this.Søg.Click += new System.EventHandler(this.Søg_Click);
            // 
            // UdskrivingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 748);
            this.Controls.Add(this.Søg);
            this.Controls.Add(this.Slutdato_label);
            this.Controls.Add(this.Startdato_label);
            this.Controls.Add(this.Slutdato);
            this.Controls.Add(this.Startdato);
            this.Controls.Add(this.Solgt_checkBox);
            this.Controls.Add(this.Område);
            this.Controls.Add(this.Område_tb);
            this.Controls.Add(this.FlowLayout);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UdskrivingsForm";
            this.Text = "UdskrivingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel FlowLayout;
        private System.Windows.Forms.TextBox Område_tb;
        private System.Windows.Forms.Label Område;
        private System.Windows.Forms.CheckBox Solgt_checkBox;
        private System.Windows.Forms.TextBox Startdato;
        private System.Windows.Forms.TextBox Slutdato;
        private System.Windows.Forms.Label Startdato_label;
        private System.Windows.Forms.Label Slutdato_label;
        private System.Windows.Forms.Button Søg;
    }
}