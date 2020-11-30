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
            // MæglerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 748);
            this.Controls.Add(this.TilføjMægler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MæglerForm";
            this.Text = "MæglerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TilføjMægler;
    }
}