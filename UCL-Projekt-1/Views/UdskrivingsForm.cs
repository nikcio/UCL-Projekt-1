using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using UCL_Projekt_1.Models;

namespace UCL_Projekt_1
{

    /// <summary>
    /// En form til at vise boliger og udskrive deres informationer
    /// </summary>
    public partial class UdskrivingsForm : Form
    {
        /// <summary>
        /// Alle boliger i databasen
        /// </summary>
        private readonly Bolig[] boliger = IndlæsFraDatabase.IndlæsBoliger();

        /// <summary>
        /// Alle kunder i databasen
        /// </summary>
        private readonly Kunde[] kunder = IndlæsFraDatabase.IndlæsKunder();

        /// <summary>
        /// Alle ejendomsmæglere i databasen
        /// </summary>
        private readonly Ejendomsmægler[] ejendomsmæglers = IndlæsFraDatabase.IndlæsEjendomsmæglere();

        /// <summary>
        /// Alle salg i databasen
        /// </summary>
        private readonly Salg[] alleSalg = IndlæsFraDatabase.IndlæsAlleSalg();

        /// <summary>
        /// Det nuværrende resultat
        /// </summary>
        private Bolig[] resultat;

        public UdskrivingsForm()
        {
            InitializeComponent();

            // Viser alle boliger
            VisResultat(boliger);
        }

        /// <summary>
        /// Søger på parametre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Søg_Click(object sender, EventArgs e)
        {
            // Se forklaringen nedenunder
            Bolig[] filterBoliger = boliger.Where(item => item.Solgt == Solgt_checkBox.Checked)
                                                .Where(item => item.Addresse.ToLower().Contains(Område_tb.Text.ToLower()) || Område_tb.Text == "")
                                                .Where(item => alleSalg.Any(salg => salg.Bolig_Id == item.Bolig_Id && DatoMellem(salg.Dato)) ||
                                                    Startdato.Text == "" ||
                                                    Slutdato.Text == ""
                                                ).ToArray();

            #region Forklaring
            // Forklaring af søg_click øverste linje
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

            //Forklaring af søg_click øverste linje (Skal stå som sin egen metode)
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
            #endregion

            VisResultat(filterBoliger);

        }

        /// <summary>
        /// Udskriver informationen på skræmen til en txt fil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UdskrivInformation_Click(object sender, EventArgs e)
        {

            // Placereing af den nye txt fil. Vi bruger Enviroment.CurrentDirectory til at ligge den ved siden af vores program.
            string path = $"{Environment.CurrentDirectory}/BoligInformation.txt";

            // Vi udskriver informationen til txt filen.
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                foreach (Bolig item in resultat)
                {
                    Ejendomsmægler mægler = IndlæsFraDatabase.IndlæsEjendomsmægler(item.Mægler_Id);
                    string mæglerInfo = "";
                    if (mægler != null)
                    {
                        mæglerInfo = $"Mægler navn: {mægler.Navn}, Mægler tlf: {mægler.Telefon}, Mægler email: {mægler.Email}";
                    }
                    streamWriter.WriteLine(
                        $"Id: {item.Bolig_Id}, " +
                        $"Adresse: {item.Addresse}, " +
                        $"Boligtype: {item.Boligtype}, " +
                        $"Bolig areal: {item.Bolig_areal}, " +
                        $"Grund areal: {item.Grund_areal}, " +
                        $"Køber: {item.Kunde_køber}, " +
                        $"Sælger: {item.Kunde_sælger}, " +
                        $"Solgt: {(item.Solgt == true ? "Ja" : "Nej")}, " +
                        $"{mæglerInfo}");
                }
            }
            Process.Start(path);
        }

        /// <summary>
        /// Tjek om datoen er mellem start og slut datoen
        /// </summary>
        /// <param name="dato"></param>
        /// <returns>Success</returns>
        private bool DatoMellem(DateTime dato)
        {
            if (DateTime.TryParse(Startdato.Text, out DateTime start) && DateTime.TryParse(Startdato.Text, out DateTime slut))
            {
                return start <= dato && dato <= slut;
            }
            else
            {
                return true;
            }

        }

        /// <summary>
        /// Viser resultatet for et array af boliger
        /// </summary>
        /// <param name="filter"></param>
        private void VisResultat(Bolig[] filter)
        {
            // Her fjernes alle gamle elementer i panelet
            FlowLayout.Controls.Clear();

            // Vi opdatere hvad det nuværrende resultat er
            resultat = filter;

            // Her gennemløbes alle boligerne
            foreach (Bolig item in filter)
            {
                Ejendomsmægler mægler = ejendomsmæglers.FirstOrDefault(ejendomsmægler => ejendomsmægler.Mægler_Id == item.Mægler_Id);
                Kunde køber = kunder.FirstOrDefault(kundeKøber => kundeKøber.Kunde_Id == item.Kunde_køber);
                Kunde sælger = kunder.FirstOrDefault(kundeSælger => kundeSælger.Kunde_Id == item.Kunde_sælger);
                Salg salg = alleSalg.FirstOrDefault(salgItem => salgItem.Bolig_Id == item.Bolig_Id);

                TilføjRække(item.Grund_areal.ToString(),
                            item.Bolig_areal.ToString(),
                            item.Boligtype,
                            (mægler != null ? mægler.Navn : "Der er ingen mægler"),
                            (sælger != null ? sælger.Navn : "Der er ingen sælger"),
                            (køber != null ? køber.Navn : "Der er ingen køber"),
                            item.Addresse,
                            item.Udbuds_pris,
                            item.Solgt,
                            (salg != null ? salg.Dato.ToShortDateString() : ""));
            }

            if (filter.Count() == 0)
            {
                VisEnFejl("Der blev ikke fundet nogen boliger");
            }
        }

        #region Opret visuelle elementer
        /// <summary>
        /// Viser en fejl besked til brugeren.
        /// </summary>
        /// <param name="besked">Den besked der skal vises</param>
        private void VisEnFejl(string besked)
        {
            //
            // Fejl
            //
            Label fejl = new Label
            {
                AutoSize = true,
                Font = new Font("Roboto Condensed", 16F, FontStyle.Regular, GraphicsUnit.Pixel, 0),
                Location = new Point(3, 0),
                Name = "fejl",
                Size = new Size(249, 19),
                TabIndex = 0,
                Text = besked
            };

            // Labelet tilføjet til flow layoutet.
            FlowLayout.Controls.Add(fejl);
        }

        /// <summary>
        /// Opret en række med information omkring en bolig
        /// </summary>
        /// <param name="grundareal"></param>
        /// <param name="boligareal"></param>
        /// <param name="boligtype"></param>
        /// <param name="mægler"></param>
        /// <param name="sælger"></param>
        /// <param name="køber"></param>
        /// <param name="adresse"></param>
        /// <param name="pris"></param>
        /// <param name="solgt"></param>
        /// <param name="dato"></param>
        private void TilføjRække(string grundareal, string boligareal, string boligtype, string mægler, string sælger, string køber, string adresse, int pris, bool solgt, string dato)
        {
            Panel Item = new Panel();
            Label Grund_areal = new Label();
            Label Bolig_areal = new Label();
            Label Boligtype = new Label();
            Label Pris = new Label();
            CheckBox Solgt = new CheckBox();
            Label Sælger = new Label();
            Label Køber = new Label();
            Label Mægler = new Label();
            Label Adresse = new Label();
            Label SolgtDato = new Label();
            FlowLayoutPanel flowlayoutpanel1 = new FlowLayoutPanel();
            FlowLayoutPanel flowlayoutpanel2 = new FlowLayoutPanel();
            // 
            // Item
            // 
            Item.Controls.Add(SolgtDato);
            Item.Controls.Add(Pris);
            Item.Controls.Add(Solgt);
            Item.Controls.Add(Adresse);
            Item.Controls.Add(flowlayoutpanel1);
            Item.Controls.Add(flowlayoutpanel2);
            Item.Location = new Point(45, 77);
            Item.Margin = new Padding(2, 2, 2, 2);
            Item.Name = "Item";
            Item.Size = new Size(1100, 151);
            Item.TabIndex = 0;
            // 
            // Grund_areal
            // 
            Grund_areal.AutoSize = true;
            Grund_areal.Font = new Font("Roboto Condensed", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Grund_areal.Location = new Point(197, 95);
            Grund_areal.Margin = new Padding(2, 0, 2, 0);
            Grund_areal.Name = "Grund_areal";
            Grund_areal.Size = new Size(84, 19);
            Grund_areal.TabIndex = 9;
            Grund_areal.Text = $"Grund areal {grundareal}";
            // 
            // Bolig_areal
            // 
            Bolig_areal.AutoSize = true;
            Bolig_areal.Font = new Font("Roboto Condensed", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Bolig_areal.Location = new Point(17, 95);
            Bolig_areal.Margin = new Padding(2, 0, 2, 0);
            Bolig_areal.Name = "Bolig_areal";
            Bolig_areal.Size = new Size(79, 19);
            Bolig_areal.TabIndex = 8;
            Bolig_areal.Text = $"Bolig areal: {boligareal}";
            // 
            // Boligtype
            // 
            Boligtype.AutoSize = true;
            Boligtype.Font = new Font("Roboto Condensed", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Boligtype.Location = new Point(426, 95);
            Boligtype.Margin = new Padding(2, 0, 2, 0);
            Boligtype.Name = "Boligtype";
            Boligtype.Size = new Size(70, 19);
            Boligtype.TabIndex = 7;
            Boligtype.Text = boligtype;
            // 
            // Pris
            // 
            Pris.AutoSize = true;
            Pris.Font = new Font("Roboto Condensed", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Pris.Location = new Point(847, 27);
            Pris.Margin = new Padding(2, 0, 2, 0);
            Pris.Name = "Pris";
            Pris.Size = new Size(34, 19);
            Pris.TabIndex = 6;
            Pris.Text = $"Pris: {pris:C2}";
            // 
            // Solgt
            // 
            Solgt.AutoSize = true;
            Solgt.Font = new Font("Roboto Condensed", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Solgt.Location = new Point(1022, 23);
            Solgt.Margin = new Padding(2, 2, 2, 2);
            Solgt.Name = "Solgt";
            Solgt.Size = new Size(61, 23);
            Solgt.TabIndex = 5;
            Solgt.Text = "Solgt";
            Solgt.UseVisualStyleBackColor = true;
            Solgt.Checked = solgt;
            Solgt.Enabled = false;
            // 
            // Sælger
            // 
            Sælger.AutoSize = true;
            Sælger.Font = new Font("Roboto Condensed", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Sælger.Location = new Point(197, 59);
            Sælger.Margin = new Padding(2, 0, 2, 0);
            Sælger.Name = "Sælger";
            Sælger.Size = new Size(54, 19);
            Sælger.TabIndex = 4;
            Sælger.Text = $"Sægler: {sælger}";
            // 
            // Køber
            // 
            Køber.AutoSize = true;
            Køber.Font = new Font("Roboto Condensed", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Køber.Location = new Point(17, 59);
            Køber.Margin = new Padding(2, 0, 2, 0);
            Køber.Name = "Køber";
            Køber.Size = new Size(47, 19);
            Køber.TabIndex = 3;
            Køber.Text = $"Køber: {køber}";
            // 
            // Mægler
            // 
            Mægler.AutoSize = true;
            Mægler.Font = new Font("Roboto Condensed", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Mægler.Location = new Point(426, 59);
            Mægler.Margin = new Padding(2, 0, 2, 0);
            Mægler.Name = "Mægler";
            Mægler.Size = new Size(58, 19);
            Mægler.TabIndex = 2;
            Mægler.Text = $"Mægler: {mægler}";
            // 
            // Adresse
            // 
            Adresse.AutoSize = true;
            Adresse.Font = new Font("Roboto Condensed", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Adresse.Location = new Point(17, 24);
            Adresse.Margin = new Padding(2, 0, 2, 0);
            Adresse.Name = "Adresse";
            Adresse.Size = new Size(61, 19);
            Adresse.TabIndex = 0;
            Adresse.Text = adresse;
            // 
            // SolgtDato
            // 
            SolgtDato.AutoSize = true;
            SolgtDato.Font = new Font("Roboto Condensed", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            SolgtDato.Location = new Point(847, 59);
            SolgtDato.Margin = new Padding(2, 0, 2, 0);
            SolgtDato.Name = "label1";
            SolgtDato.Size = new Size(72, 19);
            SolgtDato.TabIndex = 10;
            SolgtDato.Text = (dato != "" ? $"Solgt d. {dato}" : "");
            // 
            // flowLayoutPanel1
            // 
            flowlayoutpanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            flowlayoutpanel1.Controls.Add(Sælger);
            flowlayoutpanel1.Controls.Add(Køber);
            flowlayoutpanel1.Controls.Add(Mægler);
            flowlayoutpanel1.Location = new System.Drawing.Point(16, 64);
            flowlayoutpanel1.Name = "flowLayoutPanel1";
            flowlayoutpanel1.Size = new System.Drawing.Size(1103, 41);
            flowlayoutpanel1.TabIndex = 11;
            // 
            // flowLayoutPanel2
            // 
            flowlayoutpanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            flowlayoutpanel2.Controls.Add(Grund_areal);
            flowlayoutpanel2.Controls.Add(Bolig_areal);
            flowlayoutpanel2.Controls.Add(Boligtype);
            flowlayoutpanel2.Location = new System.Drawing.Point(16, 104);
            flowlayoutpanel2.Name = "flowLayoutPanel2";
            flowlayoutpanel2.Size = new System.Drawing.Size(1102, 50);
            flowlayoutpanel2.TabIndex = 12;

            FlowLayout.Controls.Add(Item);
        }
        #endregion
    }
}
