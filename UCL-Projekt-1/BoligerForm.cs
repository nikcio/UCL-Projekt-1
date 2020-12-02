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

namespace UCL_Projekt_1
{
    public partial class BoligerForm : Form
    {
        private BaseForm _baseForm;

        public BoligerForm(BaseForm form)
        {
            InitializeComponent();
            _baseForm = form;
            VisBoliger();
        }

        private void TilføjBolig_Click(object sender, EventArgs e)
        {
            _baseForm.OpenChildForm(new RedigerBoligerForm(_baseForm));
        }

        private void VisBoliger()
        {
            Bolig[] boliger = SQLRead.LoadBoliger();
            foreach (var item in boliger)
            {
                string[] adresse = item.Addresse.Split(',');
                if (adresse.Length == 2)
                {
                    VisEnBolig(adresse[0], adresse[1], item.Udbuds_pris.ToString(), item.Bolig_Id);
                }
            }
        }

        private void VisEnBolig(string adresse, string by, string pris, int id)
        {
            var Bolig = new Panel();
            var Adresse = new Label();
            var By = new Label();
            var Pris = new Label();
            var SeBolig = new Button();
            // 
            // Bolig
            // 
            Bolig.Controls.Add(SeBolig);
            Bolig.Controls.Add(Pris);
            Bolig.Controls.Add(By);
            Bolig.Controls.Add(Adresse);
            Bolig.Location = new Point(49, 41);
            Bolig.Name = "Bolig";
            Bolig.Size = new Size(327, 208);
            Bolig.TabIndex = 0;
            // 
            // Adresse
            // 
            Adresse.AutoSize = true;
            Adresse.Location = new Point(23, 25);
            Adresse.Name = "Adresse";
            Adresse.Size = new Size(125, 17);
            Adresse.TabIndex = 0;
            Adresse.Text = adresse;
            // 
            // By
            // 
            By.AutoSize = true;
            By.Location = new Point(26, 58);
            By.Name = "By";
            By.Size = new Size(73, 17);
            By.TabIndex = 1;
            By.Text = by;
            // 
            // Pris
            // 
            Pris.AutoSize = true;
            Pris.Location = new Point(209, 152);
            Pris.Name = "Pris";
            Pris.Size = new Size(80, 17);
            Pris.TabIndex = 2;
            Pris.Text = pris;
            // 
            // SeBolig
            // 
            SeBolig.Location = new Point(29, 145);
            SeBolig.Name = "SeBolig";
            SeBolig.Size = new Size(84, 32);
            SeBolig.TabIndex = 3;
            SeBolig.Text = "Se bolig";
            SeBolig.UseVisualStyleBackColor = true;
            SeBolig.Click += new EventHandler((sender, e) => SeBolig_Click(sender, e, id));

            FlowLayout.Controls.Add(Bolig);
        }

        private void SeBolig_Click(object sender, EventArgs e, int id)
        {
            _baseForm.OpenChildForm(new RedigerBoligerForm(_baseForm, id));
        }
    }
}
