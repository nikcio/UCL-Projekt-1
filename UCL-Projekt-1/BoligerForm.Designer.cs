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
            this.SuspendLayout();
            // 
            // TilføjBolig
            // 
            this.TilføjBolig.Location = new System.Drawing.Point(26, 12);
            this.TilføjBolig.Name = "TilføjBolig";
            this.TilføjBolig.Size = new System.Drawing.Size(193, 47);
            this.TilføjBolig.TabIndex = 0;
            this.TilføjBolig.Text = "Tilføj Bolig";
            this.TilføjBolig.UseVisualStyleBackColor = true;
            this.TilføjBolig.Click += new System.EventHandler(this.TilføjBolig_Click);
            // 
            // FlowLayout
            // 
            this.FlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowLayout.AutoScroll = true;
            this.FlowLayout.Location = new System.Drawing.Point(12, 65);
            this.FlowLayout.Name = "FlowLayout";
            this.FlowLayout.Size = new System.Drawing.Size(1496, 671);
            this.FlowLayout.TabIndex = 0;
            // 
            // BoligerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1520, 748);
            this.Controls.Add(this.FlowLayout);
            this.Controls.Add(this.TilføjBolig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BoligerForm";
            this.Text = "BoligerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TilføjBolig;
        private System.Windows.Forms.FlowLayoutPanel FlowLayout;
    }
}