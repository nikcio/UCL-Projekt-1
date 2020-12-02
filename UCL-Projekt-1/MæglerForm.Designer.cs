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
            this.SuspendLayout();
            // 
            // TilføjMægler
            // 
            this.TilføjMægler.Location = new System.Drawing.Point(22, 12);
            this.TilføjMægler.Name = "TilføjMægler";
            this.TilføjMægler.Size = new System.Drawing.Size(119, 52);
            this.TilføjMægler.TabIndex = 0;
            this.TilføjMægler.Text = "Tilføj mægler";
            this.TilføjMægler.UseVisualStyleBackColor = true;
            this.TilføjMægler.Click += new System.EventHandler(this.TilføjMægler_Click);
            // 
            // FlowLayout
            // 
            this.FlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowLayout.AutoScroll = true;
            this.FlowLayout.Location = new System.Drawing.Point(12, 70);
            this.FlowLayout.Name = "FlowLayout";
            this.FlowLayout.Size = new System.Drawing.Size(1496, 666);
            this.FlowLayout.TabIndex = 1;
            // 
            // MæglerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 748);
            this.Controls.Add(this.FlowLayout);
            this.Controls.Add(this.TilføjMægler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MæglerForm";
            this.Text = "MæglerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TilføjMægler;
        private System.Windows.Forms.FlowLayoutPanel FlowLayout;
    }
}