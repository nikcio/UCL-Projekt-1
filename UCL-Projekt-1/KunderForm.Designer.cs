﻿namespace UCL_Projekt_1 {
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
            this.SuspendLayout();
            // 
            // TilføjKunde
            // 
            this.TilføjKunde.Location = new System.Drawing.Point(12, 12);
            this.TilføjKunde.Name = "TilføjKunde";
            this.TilføjKunde.Size = new System.Drawing.Size(121, 37);
            this.TilføjKunde.TabIndex = 0;
            this.TilføjKunde.Text = "Tilføj kunde";
            this.TilføjKunde.UseVisualStyleBackColor = true;
            this.TilføjKunde.Click += new System.EventHandler(this.TilføjKunde_Click);
            // 
            // KunderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 748);
            this.Controls.Add(this.TilføjKunde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KunderForm";
            this.Text = "KunderForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TilføjKunde;
    }
}