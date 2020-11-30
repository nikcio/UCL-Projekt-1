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
            this.UdskrivSolgte = new System.Windows.Forms.Button();
            this.UdskrivTilSalg = new System.Windows.Forms.Button();
            this.UdskrivArea = new System.Windows.Forms.Button();
            this.Area = new System.Windows.Forms.TextBox();
            this.AreaText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UdskrivSolgte
            // 
            this.UdskrivSolgte.Location = new System.Drawing.Point(545, 87);
            this.UdskrivSolgte.Name = "UdskrivSolgte";
            this.UdskrivSolgte.Size = new System.Drawing.Size(201, 50);
            this.UdskrivSolgte.TabIndex = 0;
            this.UdskrivSolgte.Text = "Udskriv solgte huse";
            this.UdskrivSolgte.UseVisualStyleBackColor = true;
            this.UdskrivSolgte.Click += new System.EventHandler(this.UdskrivSolgte_Click);
            // 
            // UdskrivTilSalg
            // 
            this.UdskrivTilSalg.Location = new System.Drawing.Point(545, 156);
            this.UdskrivTilSalg.Name = "UdskrivTilSalg";
            this.UdskrivTilSalg.Size = new System.Drawing.Size(201, 50);
            this.UdskrivTilSalg.TabIndex = 1;
            this.UdskrivTilSalg.Text = "Udskriv aktive huse";
            this.UdskrivTilSalg.UseVisualStyleBackColor = true;
            this.UdskrivTilSalg.Click += new System.EventHandler(this.UdskrivTilSalg_Click);
            // 
            // UdskrivArea
            // 
            this.UdskrivArea.Location = new System.Drawing.Point(545, 234);
            this.UdskrivArea.Name = "UdskrivArea";
            this.UdskrivArea.Size = new System.Drawing.Size(201, 50);
            this.UdskrivArea.TabIndex = 2;
            this.UdskrivArea.Text = "Udskriv område huse";
            this.UdskrivArea.UseVisualStyleBackColor = true;
            this.UdskrivArea.Click += new System.EventHandler(this.UdskrivArea_Click);
            // 
            // Area
            // 
            this.Area.Location = new System.Drawing.Point(419, 262);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(100, 22);
            this.Area.TabIndex = 3;
            // 
            // AreaText
            // 
            this.AreaText.AutoSize = true;
            this.AreaText.Location = new System.Drawing.Point(419, 239);
            this.AreaText.Name = "AreaText";
            this.AreaText.Size = new System.Drawing.Size(59, 17);
            this.AreaText.TabIndex = 4;
            this.AreaText.Text = "Område";
            // 
            // UdskrivingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 748);
            this.Controls.Add(this.AreaText);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.UdskrivArea);
            this.Controls.Add(this.UdskrivTilSalg);
            this.Controls.Add(this.UdskrivSolgte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UdskrivingsForm";
            this.Text = "UdskrivingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UdskrivSolgte;
        private System.Windows.Forms.Button UdskrivTilSalg;
        private System.Windows.Forms.Button UdskrivArea;
        private System.Windows.Forms.TextBox Area;
        private System.Windows.Forms.Label AreaText;
    }
}