
namespace UCL_Projekt_1 {
    partial class RedigerKunderForm {
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
            this.Kunde_id = new System.Windows.Forms.Label();
            this.Navn = new System.Windows.Forms.Label();
            this.Telefon = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Køber = new System.Windows.Forms.Label();
            this.Kunde_id_tb = new System.Windows.Forms.TextBox();
            this.Kunde_navn_tb = new System.Windows.Forms.TextBox();
            this.Kunde_tlf_tb = new System.Windows.Forms.TextBox();
            this.Kunde_email_tb = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Sælger = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Opret_kunde = new System.Windows.Forms.Button();
            this.Find_kunde = new System.Windows.Forms.Button();
            this.Rediger_kunde = new System.Windows.Forms.Button();
            this.Slet_Kunde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Kunde_id
            // 
            this.Kunde_id.AutoSize = true;
            this.Kunde_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kunde_id.Location = new System.Drawing.Point(743, 146);
            this.Kunde_id.Name = "Kunde_id";
            this.Kunde_id.Size = new System.Drawing.Size(115, 29);
            this.Kunde_id.TabIndex = 0;
            this.Kunde_id.Text = "Kunde Id:";
            this.Kunde_id.Click += new System.EventHandler(this.Kunde_id_Click);
            // 
            // Navn
            // 
            this.Navn.AutoSize = true;
            this.Navn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Navn.Location = new System.Drawing.Point(61, 140);
            this.Navn.Name = "Navn";
            this.Navn.Size = new System.Drawing.Size(74, 29);
            this.Navn.TabIndex = 1;
            this.Navn.Text = "Navn:";
            this.Navn.Click += new System.EventHandler(this.Navn_Click);
            // 
            // Telefon
            // 
            this.Telefon.AutoSize = true;
            this.Telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefon.Location = new System.Drawing.Point(61, 192);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(47, 29);
            this.Telefon.TabIndex = 2;
            this.Telefon.Text = "Tlf:";
            this.Telefon.Click += new System.EventHandler(this.Telefon_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(61, 241);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(80, 29);
            this.Email.TabIndex = 3;
            this.Email.Text = "Email:";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // Køber
            // 
            this.Køber.AutoSize = true;
            this.Køber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Køber.Location = new System.Drawing.Point(61, 295);
            this.Køber.Name = "Køber";
            this.Køber.Size = new System.Drawing.Size(79, 29);
            this.Køber.TabIndex = 4;
            this.Køber.Text = "Køber";
            this.Køber.Click += new System.EventHandler(this.Køber_Click);
            // 
            // Kunde_id_tb
            // 
            this.Kunde_id_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kunde_id_tb.Location = new System.Drawing.Point(943, 146);
            this.Kunde_id_tb.Name = "Kunde_id_tb";
            this.Kunde_id_tb.Size = new System.Drawing.Size(165, 35);
            this.Kunde_id_tb.TabIndex = 5;
            this.Kunde_id_tb.TextChanged += new System.EventHandler(this.Kunde_id_tb_TextChanged);
            // 
            // Kunde_navn_tb
            // 
            this.Kunde_navn_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kunde_navn_tb.Location = new System.Drawing.Point(261, 144);
            this.Kunde_navn_tb.Name = "Kunde_navn_tb";
            this.Kunde_navn_tb.Size = new System.Drawing.Size(165, 35);
            this.Kunde_navn_tb.TabIndex = 6;
            this.Kunde_navn_tb.TextChanged += new System.EventHandler(this.Kunde_navn_tb_TextChanged);
            // 
            // Kunde_tlf_tb
            // 
            this.Kunde_tlf_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kunde_tlf_tb.Location = new System.Drawing.Point(261, 192);
            this.Kunde_tlf_tb.Name = "Kunde_tlf_tb";
            this.Kunde_tlf_tb.Size = new System.Drawing.Size(165, 35);
            this.Kunde_tlf_tb.TabIndex = 7;
            this.Kunde_tlf_tb.TextChanged += new System.EventHandler(this.Kunde_tlf_tb_TextChanged);
            // 
            // Kunde_email_tb
            // 
            this.Kunde_email_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kunde_email_tb.Location = new System.Drawing.Point(261, 235);
            this.Kunde_email_tb.Name = "Kunde_email_tb";
            this.Kunde_email_tb.Size = new System.Drawing.Size(165, 35);
            this.Kunde_email_tb.TabIndex = 8;
            this.Kunde_email_tb.TextChanged += new System.EventHandler(this.Kunde_email_tb_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(261, 289);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(156, 33);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Sælger
            // 
            this.Sælger.AutoSize = true;
            this.Sælger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sælger.Location = new System.Drawing.Point(61, 343);
            this.Sælger.Name = "Sælger";
            this.Sælger.Size = new System.Drawing.Size(92, 29);
            this.Sælger.TabIndex = 10;
            this.Sælger.Text = "Sælger";
            this.Sælger.Click += new System.EventHandler(this.Sælger_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(261, 337);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(156, 33);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Opret_kunde
            // 
            this.Opret_kunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opret_kunde.Location = new System.Drawing.Point(460, 146);
            this.Opret_kunde.Name = "Opret_kunde";
            this.Opret_kunde.Size = new System.Drawing.Size(208, 35);
            this.Opret_kunde.TabIndex = 12;
            this.Opret_kunde.Text = "Opret kunde";
            this.Opret_kunde.UseVisualStyleBackColor = true;
            this.Opret_kunde.Click += new System.EventHandler(this.Opret_kunde_Click);
            // 
            // Find_kunde
            // 
            this.Find_kunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Find_kunde.Location = new System.Drawing.Point(900, 209);
            this.Find_kunde.Name = "Find_kunde";
            this.Find_kunde.Size = new System.Drawing.Size(208, 35);
            this.Find_kunde.TabIndex = 13;
            this.Find_kunde.Text = "Find Kunde";
            this.Find_kunde.UseVisualStyleBackColor = true;
            this.Find_kunde.Click += new System.EventHandler(this.Find_kunde_Click);
            // 
            // Rediger_kunde
            // 
            this.Rediger_kunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rediger_kunde.Location = new System.Drawing.Point(900, 262);
            this.Rediger_kunde.Name = "Rediger_kunde";
            this.Rediger_kunde.Size = new System.Drawing.Size(208, 41);
            this.Rediger_kunde.TabIndex = 14;
            this.Rediger_kunde.Text = "Rediger kunde";
            this.Rediger_kunde.UseVisualStyleBackColor = true;
            this.Rediger_kunde.Click += new System.EventHandler(this.Rediger_kunde_Click);
            // 
            // Slet_Kunde
            // 
            this.Slet_Kunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slet_Kunde.Location = new System.Drawing.Point(900, 324);
            this.Slet_Kunde.Name = "Slet_Kunde";
            this.Slet_Kunde.Size = new System.Drawing.Size(208, 37);
            this.Slet_Kunde.TabIndex = 15;
            this.Slet_Kunde.Text = "Slet kunde";
            this.Slet_Kunde.UseVisualStyleBackColor = true;
            this.Slet_Kunde.Click += new System.EventHandler(this.Slet_Kunde_Click);
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.Slet_Kunde);
            this.Controls.Add(this.Rediger_kunde);
            this.Controls.Add(this.Find_kunde);
            this.Controls.Add(this.Opret_kunde);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.Sælger);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Kunde_email_tb);
            this.Controls.Add(this.Kunde_tlf_tb);
            this.Controls.Add(this.Kunde_navn_tb);
            this.Controls.Add(this.Kunde_id_tb);
            this.Controls.Add(this.Køber);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.Navn);
            this.Controls.Add(this.Kunde_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KunderForm";
            this.Text = "KunderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Kunde_id;
        private System.Windows.Forms.Label Navn;
        private System.Windows.Forms.Label Telefon;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Køber;
        private System.Windows.Forms.TextBox Kunde_id_tb;
        private System.Windows.Forms.TextBox Kunde_navn_tb;
        private System.Windows.Forms.TextBox Kunde_tlf_tb;
        private System.Windows.Forms.TextBox Kunde_email_tb;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label Sælger;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button Opret_kunde;
        private System.Windows.Forms.Button Find_kunde;
        private System.Windows.Forms.Button Rediger_kunde;
        private System.Windows.Forms.Button Slet_Kunde;
    }
}