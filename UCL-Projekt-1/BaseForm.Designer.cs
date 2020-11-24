namespace UCL_Projekt_1 {
    partial class BaseForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.MenuBar = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Button();
            this.CloseApp = new System.Windows.Forms.Button();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Boliger = new System.Windows.Forms.Button();
            this.Personale = new System.Windows.Forms.Button();
            this.Kunder = new System.Windows.Forms.Button();
            this.Body = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.MenuBar.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.AutoSize = true;
            this.MenuBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(74)))), ((int)(((byte)(77)))));
            this.MenuBar.Controls.Add(this.Minimize);
            this.MenuBar.Controls.Add(this.CloseApp);
            this.MenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Margin = new System.Windows.Forms.Padding(0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1920, 37);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuBar_OnMouseDown);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.BackgroundImage = global::UCL_Projekt_1.Properties.Resources.MinimizeIcon;
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(1733, 0);
            this.Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(93, 37);
            this.Minimize.TabIndex = 1;
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // CloseApp
            // 
            this.CloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseApp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(81)))), ((int)(((byte)(79)))));
            this.CloseApp.BackgroundImage = global::UCL_Projekt_1.Properties.Resources.CloseIcon;
            this.CloseApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseApp.FlatAppearance.BorderSize = 0;
            this.CloseApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.CloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseApp.ForeColor = System.Drawing.Color.White;
            this.CloseApp.Location = new System.Drawing.Point(1827, 0);
            this.CloseApp.Margin = new System.Windows.Forms.Padding(0);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(93, 37);
            this.CloseApp.TabIndex = 0;
            this.CloseApp.UseVisualStyleBackColor = false;
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // BodyPanel
            // 
            this.BodyPanel.AutoSize = true;
            this.BodyPanel.BackColor = System.Drawing.Color.White;
            this.BodyPanel.Controls.Add(this.flowLayoutPanel1);
            this.BodyPanel.Controls.Add(this.Body);
            this.BodyPanel.Controls.Add(this.button1);
            this.BodyPanel.Controls.Add(this.Logo);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 0);
            this.BodyPanel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(1920, 948);
            this.BodyPanel.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.Boliger);
            this.flowLayoutPanel1.Controls.Add(this.Personale);
            this.flowLayoutPanel1.Controls.Add(this.Kunder);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1443, 79);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(450, 68);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // Boliger
            // 
            this.Boliger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Boliger.AutoSize = true;
            this.Boliger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(154)))), ((int)(((byte)(224)))));
            this.Boliger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Boliger.FlatAppearance.BorderSize = 0;
            this.Boliger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boliger.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Boliger.ForeColor = System.Drawing.Color.White;
            this.Boliger.Location = new System.Drawing.Point(4, 4);
            this.Boliger.Margin = new System.Windows.Forms.Padding(4);
            this.Boliger.Name = "Boliger";
            this.Boliger.Size = new System.Drawing.Size(141, 58);
            this.Boliger.TabIndex = 2;
            this.Boliger.Text = "Boliger";
            this.Boliger.UseCompatibleTextRendering = true;
            this.Boliger.UseVisualStyleBackColor = false;
            this.Boliger.Click += new System.EventHandler(this.Boliger_Click);
            // 
            // Personale
            // 
            this.Personale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Personale.AutoSize = true;
            this.Personale.BackColor = System.Drawing.Color.Transparent;
            this.Personale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Personale.FlatAppearance.BorderSize = 0;
            this.Personale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Personale.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Personale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(74)))), ((int)(((byte)(77)))));
            this.Personale.Location = new System.Drawing.Point(153, 4);
            this.Personale.Margin = new System.Windows.Forms.Padding(4);
            this.Personale.Name = "Personale";
            this.Personale.Size = new System.Drawing.Size(143, 58);
            this.Personale.TabIndex = 3;
            this.Personale.Text = "Mæglere";
            this.Personale.UseCompatibleTextRendering = true;
            this.Personale.UseVisualStyleBackColor = false;
            this.Personale.Click += new System.EventHandler(this.Personale_Click);
            // 
            // Kunder
            // 
            this.Kunder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Kunder.AutoSize = true;
            this.Kunder.BackColor = System.Drawing.Color.Transparent;
            this.Kunder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Kunder.FlatAppearance.BorderSize = 0;
            this.Kunder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kunder.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Kunder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(74)))), ((int)(((byte)(77)))));
            this.Kunder.Location = new System.Drawing.Point(304, 4);
            this.Kunder.Margin = new System.Windows.Forms.Padding(4);
            this.Kunder.Name = "Kunder";
            this.Kunder.Size = new System.Drawing.Size(141, 58);
            this.Kunder.TabIndex = 4;
            this.Kunder.Text = "Kunder";
            this.Kunder.UseCompatibleTextRendering = true;
            this.Kunder.UseVisualStyleBackColor = false;
            this.Kunder.Click += new System.EventHandler(this.Kunder_Click);
            // 
            // Body
            // 
            this.Body.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Body.Location = new System.Drawing.Point(0, 196);
            this.Body.Margin = new System.Windows.Forms.Padding(4);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(1920, 748);
            this.Body.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(17, 79);
            this.Logo.Margin = new System.Windows.Forms.Padding(4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(400, 110);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(74)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1920, 985);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.BodyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1918, 985);
            this.Name = "BaseForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 37);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RealBolig A/S";
            this.MenuBar.ResumeLayout(false);
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MenuBar;
        private System.Windows.Forms.Button CloseApp;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Boliger;
        private System.Windows.Forms.Button Personale;
        private System.Windows.Forms.Button Kunder;
        private System.Windows.Forms.Panel Body;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

