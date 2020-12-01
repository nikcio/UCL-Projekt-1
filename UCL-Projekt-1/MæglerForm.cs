using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCL_Projekt_1.Models;

namespace UCL_Projekt_1 {
    public partial class MæglerForm : Form {

        private BaseForm _baseForm;

        public MæglerForm(BaseForm form) {
            InitializeComponent();
            _baseForm = form;
            VisMæglere();
        }

        private void TilføjMægler_Click(object sender, EventArgs e) {
            _baseForm.OpenChildForm(new RedigerMæglerForm(_baseForm));
        }

        private void RedigerMægler_Click(object sender, EventArgs e, int id) {
            _baseForm.OpenChildForm(new RedigerMæglerForm(_baseForm, id));
        }

        private void VisMæglere() {
            Ejendomsmægler[] ejendomsmæglere = SQLRead.LoadEjendomsmægler();
            foreach(var item in ejendomsmæglere) {
                VisEnMægler(item.Mægler_Id, item.Navn, item.Email, item.Telefon.ToString());
            }
        }

        private void VisEnMægler(int id, string navn, string email, string tlf) {
            var Mægler = new Panel();
            var Navn = new Label();
            var Ejendomsmægler = new Label();
            var Email = new Label();
            var Tlf = new Label();
            var RedigerMægler = new Button();
            // 
            // Mægler
            // 
            Mægler.Controls.Add(RedigerMægler);
            Mægler.Controls.Add(Tlf);
            Mægler.Controls.Add(Email);
            Mægler.Controls.Add(Ejendomsmægler);
            Mægler.Controls.Add(Navn);
            Mægler.Location = new Point(229, 131);
            Mægler.Name = "Mægler";
            Mægler.Size = new Size(400, 346);
            Mægler.TabIndex = 0;
            // 
            // Navn
            // 
            Navn.AutoSize = true;
            Navn.Location = new Point(57, 60);
            Navn.Name = "Navn";
            Navn.Size = new Size(41, 17);
            Navn.TabIndex = 0;
            Navn.Text = navn;
            // 
            // Ejendomsmægler
            // 
            Ejendomsmægler.AutoSize = true;
            Ejendomsmægler.Location = new Point(60, 96);
            Ejendomsmægler.Name = "Ejendomsmægler";
            Ejendomsmægler.Size = new Size(118, 17);
            Ejendomsmægler.TabIndex = 1;
            Ejendomsmægler.Text = "Ejendomsmægler";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(60, 132);
            Email.Name = "Email";
            Email.Size = new Size(50, 17);
            Email.TabIndex = 2;
            Email.Text = email;
            // 
            // Tlf
            // 
            Tlf.AutoSize = true;
            Tlf.Location = new Point(60, 171);
            Tlf.Name = "Tlf";
            Tlf.Size = new Size(24, 17);
            Tlf.TabIndex = 3;
            Tlf.Text = tlf;
            // 
            // RedigerMægler
            // 
            RedigerMægler.Location = new System.Drawing.Point(63, 203);
            RedigerMægler.Name = "RedigerMægler";
            RedigerMægler.Size = new System.Drawing.Size(115, 45);
            RedigerMægler.TabIndex = 4;
            RedigerMægler.Text = "Rediger mægler";
            RedigerMægler.UseVisualStyleBackColor = true;
            RedigerMægler.Click += new System.EventHandler((sender, e) => RedigerMægler_Click(sender, e, id));

            FlowLayout.Controls.Add(Mægler);
        }
    }
}
