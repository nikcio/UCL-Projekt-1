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
    public partial class KunderForm : Form {

        private BaseForm _baseForm;

        public KunderForm(BaseForm form) {
            InitializeComponent();
            _baseForm = form;
            VisKunder();
        }

        private void TilføjKunde_Click(object sender, EventArgs e) {
            _baseForm.OpenChildForm(new RedigerKunderForm(_baseForm));
        }

        private void VisKunder() {
            Kunde[] kunder =  SQLRead.LoadKunder();
            foreach(var item in kunder) {
                VisEnKunde(item.Kunde_Id.ToString(), item.Navn, item.Email, item.Telefon.ToString(), (bool)item.Er_køber, (bool)item.Er_sælger);
            }
        }

        private void VisEnKunde(string id, string navn, string email, string tlf, bool Er_køber, bool Er_sælger) {
            var Kunde = new Panel();
            var KundeId = new Label();
            var Navn = new Label();
            var Tlf = new Label();
            var Email = new Label();
            var Sælger = new Label();
            var Køber = new Label();
            // 
            // Kunde
            // 
            Kunde.Controls.Add(Køber);
            Kunde.Controls.Add(Sælger);
            Kunde.Controls.Add(Email);
            Kunde.Controls.Add(Tlf);
            Kunde.Controls.Add(Navn);
            Kunde.Controls.Add(KundeId);
            Kunde.Location = new System.Drawing.Point(53, 101);
            Kunde.Name = "Kunde";
            Kunde.Size = new System.Drawing.Size(455, 91);
            Kunde.TabIndex = 0;
            // 
            // KundeId
            // 
            KundeId.AutoSize = true;
            KundeId.Location = new Point(35, 37);
            KundeId.Name = "KundeId";
            KundeId.Size = new Size(64, 17);
            KundeId.TabIndex = 0;
            KundeId.Text = id;
            // 
            // Navn
            // 
            Navn.AutoSize = true;
            Navn.Location = new Point(121, 37);
            Navn.Name = "Navn";
            Navn.Size = new Size(41, 17);
            Navn.TabIndex = 1;
            Navn.Text = navn;
            // 
            // Tlf
            // 
            Tlf.AutoSize = true;
            Tlf.Location = new Point(169, 37);
            Tlf.Name = "Tlf";
            Tlf.Size = new Size(19, 17);
            Tlf.TabIndex = 2;
            Tlf.Text = tlf;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(218, 37);
            Email.Name = "Email";
            Email.Size = new Size(42, 17);
            Email.TabIndex = 1;
            Email.Text = email;
            // 
            // Sælger
            // 
            Sælger.AutoSize = true;
            Sælger.Location = new Point(297, 37);
            Sælger.Name = "Sælger";
            Sælger.Size = new Size(54, 17);
            Sælger.TabIndex = 3;
            Sælger.Text = Er_sælger ? "Ja" : "Nej";
            // 
            // Køber
            // 
            Køber.AutoSize = true;
            Køber.Location = new Point(372, 37);
            Køber.Name = "Køber";
            Køber.Size = new Size(46, 17);
            Køber.TabIndex = 4;
            Køber.Text = Er_køber ? "Ja" : "Nej";

            FlowLayout.Controls.Add(Kunde);
        }
    }
}
