using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UCL_Projekt_1.Models;

namespace UCL_Projekt_1
{

    /// <summary>
    /// Viser alle kunder og lader dig søge i dem efter navn.
    /// </summary>
    public partial class KunderForm : Form
    {
        /// <summary>
        /// En refrence til BaseForm.
        /// </summary>
        private readonly BaseForm _baseForm;

        /// <summary>
        /// Et array over alle kunder i databasen.
        /// </summary>
        private readonly Kunde[] kunder = IndlæsFraDatabase.IndlæsKunder();

        /// <summary>
        /// Constructor til kunder form. Her indlæses alle kunder og vises i formen.
        /// </summary>
        /// <param name="form">En refrence til BaseForm</param>
        public KunderForm(BaseForm form)
        {
            InitializeComponent();
            // Her sættes refrencen til BaseForm.
            _baseForm = form;

            // Her vises alle kunder
            VisKunder();
        }

        /// <summary>
        /// Åbner en ny form til at tilføje en kunde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TilføjKunde_Click(object sender, EventArgs e)
        {
            _baseForm.ÅbenNyForm(new RedigerKunderForm(_baseForm));
        }

        /// <summary>
        /// Viser alle kunder
        /// </summary>
        private void VisKunder()
        {
            foreach (var item in kunder)
            {
                VisEnKunde(item.Kunde_Id, item.Navn, item.Email, item.Telefon, item.Er_køber, item.Er_sælger);
            }
        }

        /// <summary>
        /// Viser alle kunder som har den pågældende string i deres navn.
        /// </summary>
        /// <param name="navn">Søge parameter</param>
        private void VisKunder(string navn)
        {

            // Her finder vi de mæglere som matcher med den string vi søger efter.
            Kunde[] filterKunder = kunder.Where(item => item.Navn.ToLower().Contains(navn.ToLower())).ToArray();

            foreach (var item in filterKunder)
            {
                VisEnKunde(item.Kunde_Id, item.Navn, item.Email, item.Telefon, item.Er_køber, item.Er_sælger);
            }
        }

        /// <summary>
        /// Åbner en ny form til at redigere en kunde
        /// </summary>
        /// <param name="sende"></param>
        /// <param name="e"></param>
        /// <param name="id"></param>
        private void RedigerKunde_Click(object sende, EventArgs e, int id)
        {
            _baseForm.ÅbenNyForm(new RedigerKunderForm(_baseForm, id));
        }

        /// <summary>
        /// Sotere kunderne på det som er skrevet i textboxen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Søg_Click(object sender, EventArgs e)
        {
            // Fjerner alle controls fra flow layout.
            FlowLayout.Controls.Clear();

            if (Navn_tb.Text != "" && ValiderNavn())
            {

                // Viser kunder med matchende navn.
                VisKunder(Navn_tb.Text);
            }
            else
            {

                // Viser alle kunder.
                VisKunder();
            }
        }

        /// <summary>
        /// Tjekker om navn textboxen har en valid værdi
        /// </summary>
        /// <returns>Success</returns>
        private bool ValiderNavn()
        {
            if (Regex.IsMatch(Navn_tb.Text, ("^[a-zA-z æøåÆØÅ]+$")) || Navn_tb.Text == "")
            {
                NavnValidering.Text = "";
                return true;
            }
            else
            {
                NavnValidering.Text = "Navnet kan ikke indeholde specielle symboler";
                return false;
            }
        }

        /// <summary>
        /// Validere inputtet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Navn_tb_TextChanged(object sender, EventArgs e)
        {
            ValiderNavn();
        }

        #region Opret Visuelle elementer
        /// <summary>
        /// Viser en fejl besked til brugeren.
        /// </summary>
        /// <param name="besked">Den besked der skal vises</param>
        private void VisEnFejl(string besked)
        {
            //
            // Fejl
            //
            var fejl = new Label();
            fejl.AutoSize = true;
            fejl.Font = new Font("Roboto Condensed", 16F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            fejl.Location = new Point(3, 0);
            fejl.Name = "fejl";
            fejl.Size = new Size(249, 19);
            fejl.TabIndex = 0;
            fejl.Text = besked;

            // Labelet tilføjet til flow layoutet.
            FlowLayout.Controls.Add(fejl);
        }

        private void VisEnKunde(int id, string navn, string email, int tlf, bool Er_køber, bool Er_sælger)
        {
            var Kunde = new Panel();
            var RedigerKunde = new Button();
            var Email = new Label();
            var Tlf = new Label();
            var Navn = new Label();
            var KundeId = new Label();
            var Køber = new CheckBox();
            var Sælger = new CheckBox();
            // 
            // Kunde
            // 
            Kunde.Controls.Add(Sælger);
            Kunde.Controls.Add(Køber);
            Kunde.Controls.Add(RedigerKunde);
            Kunde.Controls.Add(Email);
            Kunde.Controls.Add(Tlf);
            Kunde.Controls.Add(Navn);
            Kunde.Controls.Add(KundeId);
            Kunde.Location = new Point(40, 82);
            Kunde.Margin = new Padding(2, 2, 2, 2);
            Kunde.Name = "Kunde";
            Kunde.Size = new Size(1100, 74);
            Kunde.TabIndex = 0;
            // 
            // RedigerKunde
            // 
            RedigerKunde.BackColor = Color.FromArgb(77, 157, 224);
            RedigerKunde.FlatStyle = FlatStyle.Flat;
            RedigerKunde.Font = new Font("Roboto Condensed", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            RedigerKunde.ForeColor = Color.White;
            RedigerKunde.Location = new Point(932, 18);
            RedigerKunde.Margin = new Padding(2, 2, 2, 2);
            RedigerKunde.Name = "RedigerKunde";
            RedigerKunde.Size = new Size(156, 38);
            RedigerKunde.TabIndex = 5;
            RedigerKunde.Text = "Rediger kunde";
            RedigerKunde.UseVisualStyleBackColor = false;
            RedigerKunde.Click += new EventHandler((sender, e) => RedigerKunde_Click(sender, e, id));
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Roboto Condensed", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            Email.Location = new Point(531, 25);
            Email.Margin = new Padding(2, 0, 2, 0);
            Email.Name = "Email";
            Email.Size = new Size(195, 24);
            Email.TabIndex = 1;
            Email.Text = email;
            // 
            // Tlf
            // 
            Tlf.AutoSize = true;
            Tlf.Font = new Font("Roboto Condensed", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tlf.Location = new Point(400, 25);
            Tlf.Margin = new Padding(2, 0, 2, 0);
            Tlf.Name = "Tlf";
            Tlf.Size = new Size(105, 24);
            Tlf.TabIndex = 2;
            Tlf.Text = $"{tlf:## ## ## ##}";
            // 
            // Navn
            // 
            Navn.AutoSize = true;
            Navn.Font = new Font("Roboto Condensed", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            Navn.Location = new Point(160, 25);
            Navn.Margin = new Padding(2, 0, 2, 0);
            Navn.Name = "Navn";
            Navn.Size = new Size(179, 24);
            Navn.TabIndex = 1;
            Navn.Text = navn;
            // 
            // KundeId
            // 
            KundeId.AutoSize = true;
            KundeId.Font = new Font("Roboto Condensed", 20F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            KundeId.Location = new Point(20, 25);
            KundeId.Margin = new Padding(2, 0, 2, 0);
            KundeId.Name = "KundeId";
            KundeId.Size = new Size(80, 24);
            KundeId.TabIndex = 0;
            KundeId.Text = id.ToString();
            // 
            // Køber
            // 
            Køber.AutoSize = true;
            Køber.Font = new Font("Roboto Condensed", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            Køber.Location = new Point(796, 31);
            Køber.Name = "Køber";
            Køber.Size = new Size(15, 14);
            Køber.TabIndex = 1;
            Køber.UseVisualStyleBackColor = true;
            Køber.Checked = Er_køber;
            Køber.Enabled = false;
            // 
            // Sælger
            // 
            Sælger.AutoSize = true;
            Sælger.Font = new Font("Roboto Condensed", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            Sælger.Location = new Point(860, 31);
            Sælger.Name = "Sælger";
            Sælger.Size = new Size(15, 14);
            Sælger.TabIndex = 6;
            Sælger.UseVisualStyleBackColor = true;
            Sælger.Checked = Er_sælger;
            Sælger.Enabled = false;

            FlowLayout.Controls.Add(Kunde);
        }
        #endregion

    }
}
