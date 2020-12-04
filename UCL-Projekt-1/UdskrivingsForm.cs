using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using UCL_Projekt_1.Models;
using System.IO;
using UCL_Projekt_1;
using System.Diagnostics;

namespace UCL_Projekt_1
{
    public partial class UdskrivingsForm : Form
    {

        private BaseForm _baseForm;

        public UdskrivingsForm(BaseForm form)
        {
            InitializeComponent();
            _baseForm = form;
        }

        private void UdskrivSolgte_Click(object sender, EventArgs e)
        {
            Bolig[] boliger = SQLRead.LoadBoliger(true);

            string path = $"{Environment.CurrentDirectory}/SolgteBoliger.txt";
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                foreach (Bolig item in boliger)
                {
                    Ejendomsmægler mægler = SQLRead.VisEjendomsmægler(item.Mægler_Id.ToString());
                    string mæglerInfo = "";
                    if (mægler != null)
                    {
                        mæglerInfo = $"Mægler navn: {mægler.Navn}, Mægler tlf: {mægler.Telefon}, Mægler email: {mægler.Email}";
                    }
                    streamWriter.WriteLine($"Id: {item.Bolig_Id}, Adresse: {item.Addresse}, Boligtype: {item.Boligtype}, Bolig areal: {item.Bolig_areal}, Grund areal: {item.Grund_areal}, Køber: {item.Kunde_køber}, Sælger: {item.Kunde_sælger}, Solgt: {(item.Solgt == true ? "Ja" : "Nej")}, {mæglerInfo}");
                }
            }
            Process.Start(path);
        }

        private void UdskrivTilSalg_Click(object sender, EventArgs e)
        {
            Bolig[] boliger = SQLRead.LoadBoliger(false);
            string path = $"{Environment.CurrentDirectory}/TilSalgBoliger.txt";
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                foreach (Bolig item in boliger)
                {
                    Ejendomsmægler mægler = SQLRead.VisEjendomsmægler(item.Mægler_Id.ToString());
                    string mæglerInfo = "";
                    if (mægler != null)
                    {
                        mæglerInfo = $"Mægler navn: {mægler.Navn}, Mægler tlf: {mægler.Telefon}, Mægler email: {mægler.Email}";
                    }
                    streamWriter.WriteLine($"Id: {item.Bolig_Id}, Adresse: {item.Addresse}, Boligtype: {item.Boligtype}, Bolig areal: {item.Bolig_areal}, Grund areal: {item.Grund_areal}, Køber: {item.Kunde_køber}, Sælger: {item.Kunde_sælger}, Solgt: {(item.Solgt == true ? "Ja" : "Nej")}, {mæglerInfo}");
                }
            }
            Process.Start(path);
        }

        private void UdskrivArea_Click(object sender, EventArgs e)
        {
            Bolig[] boliger = SQLRead.LoadBoliger(Area.Text);
            string path = $"{Environment.CurrentDirectory}/AreaBoliger.txt";
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                foreach (Bolig item in boliger)
                {
                    Ejendomsmægler mægler = SQLRead.VisEjendomsmægler(item.Mægler_Id.ToString());
                    string mæglerInfo = "";
                    if (mægler != null)
                    {
                        mæglerInfo = $"Mægler navn: {mægler.Navn}, Mægler tlf: {mægler.Telefon}, Mægler email: {mægler.Email}";
                    }
                    streamWriter.WriteLine($"Id: {item.Bolig_Id}, Adresse: {item.Addresse}, Boligtype: {item.Boligtype}, Bolig areal: {item.Bolig_areal}, Grund areal: {item.Grund_areal}, Køber: {item.Kunde_køber}, Sælger: {item.Kunde_sælger}, Solgt: {(item.Solgt == true ? "Ja" : "Nej")}, {mæglerInfo}");
                }
            }
            Process.Start(path);
        }


    }
}
