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
        private Bolig[] boliger;
        private Kunde[] kunder;
        private Ejendomsmægler[] ejendomsmæglers;

        public UdskrivingsForm(BaseForm form)
        {
            InitializeComponent();
            _baseForm = form;
            boliger = SQLRead.LoadBoliger();
            kunder = SQLRead.LoadKunder();
            ejendomsmæglers = SQLRead.LoadEjendomsmægler();
        }

        //private void UdskrivSolgte_Click(object sender, EventArgs e)
        //{
        //    Bolig[] boliger = SQLRead.LoadBoliger(true);

        //    string path = $"{Environment.CurrentDirectory}/SolgteBoliger.txt";
        //    using (StreamWriter streamWriter = new StreamWriter(path))
        //    {
        //        foreach (Bolig item in boliger)
        //        {
        //            Ejendomsmægler mægler = SQLRead.VisEjendomsmægler(item.Mægler_Id.ToString());
        //            string mæglerInfo = "";
        //            if (mægler != null)
        //            {
        //                mæglerInfo = $"Mægler navn: {mægler.Navn}, Mægler tlf: {mægler.Telefon}, Mægler email: {mægler.Email}";
        //            }
        //            streamWriter.WriteLine($"Id: {item.Bolig_Id}, Adresse: {item.Addresse}, Boligtype: {item.Boligtype}, Bolig areal: {item.Bolig_areal}, Grund areal: {item.Grund_areal}, Køber: {item.Kunde_køber}, Sælger: {item.Kunde_sælger}, Solgt: {(item.Solgt == true ? "Ja" : "Nej")}, {mæglerInfo}");
        //        }
        //    }
        //    Process.Start(path);
        //}

        //private void UdskrivTilSalg_Click(object sender, EventArgs e)
        //{
        //    Bolig[] boliger = SQLRead.LoadBoliger(false);
        //    string path = $"{Environment.CurrentDirectory}/TilSalgBoliger.txt";
        //    using (StreamWriter streamWriter = new StreamWriter(path))
        //    {
        //        foreach (Bolig item in boliger)
        //        {
        //            Ejendomsmægler mægler = SQLRead.VisEjendomsmægler(item.Mægler_Id.ToString());
        //            string mæglerInfo = "";
        //            if (mægler != null)
        //            {
        //                mæglerInfo = $"Mægler navn: {mægler.Navn}, Mægler tlf: {mægler.Telefon}, Mægler email: {mægler.Email}";
        //            }
        //            streamWriter.WriteLine($"Id: {item.Bolig_Id}, Adresse: {item.Addresse}, Boligtype: {item.Boligtype}, Bolig areal: {item.Bolig_areal}, Grund areal: {item.Grund_areal}, Køber: {item.Kunde_køber}, Sælger: {item.Kunde_sælger}, Solgt: {(item.Solgt == true ? "Ja" : "Nej")}, {mæglerInfo}");
        //        }
        //    }
        //    Process.Start(path);
        //}

        //private void UdskrivArea_Click(object sender, EventArgs e)
        //{
        //    Bolig[] boliger = SQLRead.LoadBoliger(Area.Text);
        //    string path = $"{Environment.CurrentDirectory}/AreaBoliger.txt";
        //    using (StreamWriter streamWriter = new StreamWriter(path))
        //    {
        //        foreach (Bolig item in boliger)
        //        {
        //            Ejendomsmægler mægler = SQLRead.VisEjendomsmægler(item.Mægler_Id.ToString());
        //            string mæglerInfo = "";
        //            if (mægler != null)
        //            {
        //                mæglerInfo = $"Mægler navn: {mægler.Navn}, Mægler tlf: {mægler.Telefon}, Mægler email: {mægler.Email}";
        //            }
        //            streamWriter.WriteLine($"Id: {item.Bolig_Id}, Adresse: {item.Addresse}, Boligtype: {item.Boligtype}, Bolig areal: {item.Bolig_areal}, Grund areal: {item.Grund_areal}, Køber: {item.Kunde_køber}, Sælger: {item.Kunde_sælger}, Solgt: {(item.Solgt == true ? "Ja" : "Nej")}, {mæglerInfo}");
        //        }
        //    }
        //    Process.Start(path);
        //}


        private void TilføjRække(string grundareal, string boligareal, string boligtype, string mægler, string sælger, string køber, string adresse, string pris, bool solgt)
        {
            var Item = new System.Windows.Forms.Panel();
            var Grund_areal = new System.Windows.Forms.Label();
            var Bolig_areal = new System.Windows.Forms.Label();
            var Boligtype = new System.Windows.Forms.Label();
            var Pris = new System.Windows.Forms.Label();
            var Solgt = new System.Windows.Forms.CheckBox();
            var Sælger = new System.Windows.Forms.Label();
            var Køber = new System.Windows.Forms.Label();
            var Mægler = new System.Windows.Forms.Label();
            var Adresse = new System.Windows.Forms.Label();
            // 
            // Item
            // 
            Item.Controls.Add(Grund_areal);
            Item.Controls.Add(Bolig_areal);
            Item.Controls.Add(Boligtype);
            Item.Controls.Add(Pris);
            Item.Controls.Add(Solgt);
            Item.Controls.Add(Sælger);
            Item.Controls.Add(Køber);
            Item.Controls.Add(Mægler);
            Item.Controls.Add(Adresse);
            Item.Location = new System.Drawing.Point(209, 113);
            Item.Name = "Item";
            Item.Size = new System.Drawing.Size(1000, 70);
            Item.TabIndex = 0;
            // 
            // Grund_areal
            // 
            Grund_areal.AutoSize = true;
            Grund_areal.Location = new System.Drawing.Point(272, 43);
            Grund_areal.Name = "Grund_areal";
            Grund_areal.Size = new System.Drawing.Size(84, 17);
            Grund_areal.TabIndex = 9;
            Grund_areal.Text = grundareal;
            // 
            // Bolig_areal
            // 
            Bolig_areal.AutoSize = true;
            Bolig_areal.Location = new System.Drawing.Point(134, 43);
            Bolig_areal.Name = "Bolig_areal";
            Bolig_areal.Size = new System.Drawing.Size(75, 17);
            Bolig_areal.TabIndex = 8;
            Bolig_areal.Text = boligareal;
            // 
            // Boligtype
            // 
            Boligtype.AutoSize = true;
            Boligtype.Location = new System.Drawing.Point(3, 43);
            Boligtype.Name = "Boligtype";
            Boligtype.Size = new System.Drawing.Size(66, 17);
            Boligtype.TabIndex = 7;
            Boligtype.Text = boligtype;
            // 
            // Pris
            // 
            Pris.AutoSize = true;
            Pris.Location = new System.Drawing.Point(768, 10);
            Pris.Name = "Pris";
            Pris.Size = new System.Drawing.Size(32, 17);
            Pris.TabIndex = 6;
            Pris.Text = pris;
            // 
            // Solgt
            // 
            Solgt.AutoSize = true;
            Solgt.Location = new System.Drawing.Point(935, 10);
            Solgt.Name = "Solgt";
            Solgt.Size = new System.Drawing.Size(62, 21);
            Solgt.TabIndex = 5;
            Solgt.Text = "Solgt";
            Solgt.UseVisualStyleBackColor = true;
            Solgt.Checked = solgt;
            // 
            // Sælger
            // 
            Sælger.AutoSize = true;
            Sælger.Location = new System.Drawing.Point(611, 10);
            Sælger.Name = "Sælger";
            Sælger.Size = new System.Drawing.Size(54, 17);
            Sælger.TabIndex = 4;
            Sælger.Text = sælger;
            // 
            // Køber
            // 
            Køber.AutoSize = true;
            Køber.Location = new System.Drawing.Point(453, 10);
            Køber.Name = "Køber";
            Køber.Size = new System.Drawing.Size(46, 17);
            Køber.TabIndex = 3;
            Køber.Text = køber;
            // 
            // Mægler
            // 
            Mægler.AutoSize = true;
            Mægler.Location = new System.Drawing.Point(272, 10);
            Mægler.Name = "Mægler";
            Mægler.Size = new System.Drawing.Size(56, 17);
            Mægler.TabIndex = 2;
            Mægler.Text = mægler;
            // 
            // Adresse
            // 
            Adresse.AutoSize = true;
            Adresse.Location = new System.Drawing.Point(2, 10);
            Adresse.Name = "Adresse";
            Adresse.Size = new System.Drawing.Size(60, 17);
            Adresse.TabIndex = 0;
            Adresse.Text = adresse;

            FlowLayout.Controls.Add(Item);
        }

        private void Søg_Click(object sender, EventArgs e)
        {
            Salg[] alleSalg = new Salg[0];
            if(Startdato.Text != "" && Slutdato.Text != "")
            {
                alleSalg = SQLRead.LoadSalg();
            }

            Bolig[] filterBoliger = boliger.Where(item => item.Solgt == Solgt_checkBox.Checked)
                                                .Where(item => item.Addresse.Contains(Område_tb.Text) || Område_tb.Text == "")
                                                .Where(item => alleSalg.Any(salg => salg.Bolig_Id == item.Bolig_Id && DatoMellem(salg.Dato)) ||
                                                    Startdato.Text == "" ||
                                                    Slutdato.Text == ""
                                                ).ToArray();
            // Forklaring af linje 220
            //List<Bolig> boligerEx = new List<Bolig>();
            //foreach(var bolig in boliger)
            //{
            //    if (bolig.Solgt == Solgt_checkBox.Checked)
            //    {
            //        if(bolig.Addresse.Contains(Område_tb.Text) || Område_tb.Text == "")
            //        {
            //            if(Check(alleSalg, bolig.Bolig_Id))
            //            {
            //                boligerEx.Add(bolig);
            //            }
            //        }
            //    }
            //}

            VisResultat(filterBoliger);

        }

        //Forklaring af linje 220
        //private bool Check(Salg[] allesalg, int boligId)
        //{
        //    foreach(var salg in allesalg)
        //    {
        //        if(salg.Bolig_Id == boligId)
        //        {
        //            if (DatoMellem(salg.Dato) || Startdato.Text == "" || Slutdato.Text == "")
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    return false;
        //}

        private bool DatoMellem(DateTime dato)
        {
            return DateTime.Parse(Startdato.Text) <= dato && dato <= DateTime.Parse(Slutdato.Text);
        }

        private void VisResultat(Bolig[] filter)
        {
            FlowLayout.Controls.Clear();

            foreach (var item in filter)
            {
                Ejendomsmægler mægler = ejendomsmæglers.FirstOrDefault(ejendomsmægler => ejendomsmægler.Mægler_Id == item.Mægler_Id);
                Kunde køber = kunder.FirstOrDefault(kundeKøber => kundeKøber.Kunde_Id == item.Kunde_køber);
                Kunde sælger = kunder.FirstOrDefault(kundeSælger => kundeSælger.Kunde_Id == item.Kunde_sælger);
                
                TilføjRække(item.Grund_areal.ToString(),
                            item.Bolig_areal.ToString(),
                            item.Boligtype,
                            (mægler != null ? mægler.Navn : "Der er ingen mægler"),
                            (sælger != null ? sælger.Navn : "Der er ingen sælger"),
                            (køber != null ? køber.Navn : "Der er ingen køber"),
                            item.Addresse,
                            item.Udbuds_pris.ToString(),
                            item.Solgt);
            }
        }
    }
}
