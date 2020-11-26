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

namespace UCL_Projekt_1 {
    public partial class UdskrivingsForm : Form {

        public UdskrivingsForm() {
            InitializeComponent();
        }

        private void UdskrivSolgte_Click(object sender, EventArgs e) {
            Bolig[] boliger = SQLRead.LoadBoliger(true);

            using (StreamWriter streamWriter = new StreamWriter($"{Environment.CurrentDirectory}/SolgteBoliger.txt")) {
                foreach(Bolig item in boliger) {
                    streamWriter.WriteLine($"Id: {item.Bolig_Id}, Adresse: {item.Addresse}, Boligtype: {item.Boligtype}, Bolig areal: {item.Bolig_areal}, Grund areal: {item.Grund_areal}, Mægler id: {item.Mægler_Id}, Kunde id: {item.Kunde_Id}, Solgt: {(item.Solgt == true ? "Ja" : "Nej")}");
                }
            }
            
        }

        private void UdskrivTilSalg_Click(object sender, EventArgs e) {
            Bolig[] boliger = SQLRead.LoadBoliger(false);

            using (StreamWriter streamWriter = new StreamWriter($"{Environment.CurrentDirectory}/TilSalgBoliger.txt")) {
                foreach (Bolig item in boliger) {
                    streamWriter.WriteLine($"Id: {item.Bolig_Id}, Adresse: {item.Addresse}, Boligtype: {item.Boligtype}, Bolig areal: {item.Bolig_areal}, Grund areal: {item.Grund_areal}, Mægler id: {item.Mægler_Id}, Kunde id: {item.Kunde_Id}, Solgt: {(item.Solgt == true ? "Ja" : "Nej")}");
                }
            }
        }

        private void UdskrivArea_Click(object sender, EventArgs e) {
            Bolig[] boliger = SQLRead.LoadBoliger(Area.Text);

            using (StreamWriter streamWriter = new StreamWriter($"{Environment.CurrentDirectory}/AreaBoliger.txt")) {
                foreach (Bolig item in boliger) {
                    streamWriter.WriteLine($"Id: {item.Bolig_Id}, Adresse: {item.Addresse}, Boligtype: {item.Boligtype}, Bolig areal: {item.Bolig_areal}, Grund areal: {item.Grund_areal}, Mægler id: {item.Mægler_Id}, Kunde id: {item.Kunde_Id}, Solgt: {(item.Solgt == true ? "Ja" : "Nej")}");
                }
            }
        }

        
    }
}
