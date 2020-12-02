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
            this.Søg = new System.Windows.Forms.TextBox();
            this.Adresse = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.BoligId = new System.Windows.Forms.TextBox();
            this.BoligIdValidation = new System.Windows.Forms.Label();
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
            // Søg
            // 
            this.Søg.Location = new System.Drawing.Point(337, 12);
            this.Søg.Name = "Søg";
            this.Søg.Size = new System.Drawing.Size(261, 22);
            this.Søg.TabIndex = 1;
            this.Søg.TextChanged += new System.EventHandler(this.Søg_TextChanged);
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.Location = new System.Drawing.Point(271, 12);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(60, 17);
            this.Adresse.TabIndex = 2;
            this.Adresse.Text = "Adresse";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(660, 12);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(19, 17);
            this.Id.TabIndex = 3;
            this.Id.Text = "Id";
            // 
            // BoligId
            // 
            this.BoligId.Location = new System.Drawing.Point(704, 12);
            this.BoligId.Name = "BoligId";
            this.BoligId.Size = new System.Drawing.Size(100, 22);
            this.BoligId.TabIndex = 4;
            this.BoligId.TextChanged += new System.EventHandler(this.BoligId_TextChanged);
            // 
            // BoligIdValidation
            // 
            this.BoligIdValidation.AutoSize = true;
            this.BoligIdValidation.ForeColor = System.Drawing.Color.Red;
            this.BoligIdValidation.Location = new System.Drawing.Point(701, 37);
            this.BoligIdValidation.Name = "BoligIdValidation";
            this.BoligIdValidation.Size = new System.Drawing.Size(0, 17);
            this.BoligIdValidation.TabIndex = 5;
            // 
            // BoligerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1520, 748);
            this.Controls.Add(this.BoligIdValidation);
            this.Controls.Add(this.BoligId);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.Adresse);
            this.Controls.Add(this.Søg);
            this.Controls.Add(this.FlowLayout);
            this.Controls.Add(this.TilføjBolig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BoligerForm";
            this.Text = "BoligerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TilføjBolig;
        private System.Windows.Forms.FlowLayoutPanel FlowLayout;
        private System.Windows.Forms.TextBox Søg;
        private System.Windows.Forms.Label Adresse;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox BoligId;
        private System.Windows.Forms.Label BoligIdValidation;
    }
}