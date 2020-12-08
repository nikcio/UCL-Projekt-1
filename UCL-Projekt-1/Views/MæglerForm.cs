using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UCL_Projekt_1.Models;

namespace UCL_Projekt_1
{

    /// <summary>
    /// Viser mæglere og giver mulighed for at sortere mellem dem.
    /// </summary>
    public partial class MæglerForm : Form
    {
        /// <summary>
        /// En reference til BaseForm.
        /// </summary>
        private readonly BaseForm _baseForm;

        /// <summary>
        /// Et array over alle ejendomsmæglere
        /// </summary>
        private readonly Ejendomsmægler[] ejendomsmæglere = IndlæsFraDatabase.IndlæsEjendomsmæglere();

        /// <summary>
        /// Constructor til MæglerForm
        /// </summary>
        /// <param name="form"></param>
        public MæglerForm(BaseForm form)
        {
            InitializeComponent();

            // Her sættes refrencen til BaseForm.
            _baseForm = form;

            // Her vies alle mæglere
            VisMæglere();
        }

        /// <summary>
        /// Viser alle mæglere med information
        /// </summary>
        private void VisMæglere()
        {
            foreach (Ejendomsmægler item in ejendomsmæglere)
            {
                VisEnMægler(item.Mægler_Id, item.Navn, item.Email, item.Telefon);
            }

            if (ejendomsmæglere.Count() == 0)
            {
                VisEnFejl("Der kunne ikke findes nogen ejendomsmæglere");
            }
        }

        /// <summary>
        /// Viser alle mæglere, hvis navn indeholder den string som er sendt med.
        /// </summary>
        /// <param name="navn">Den string der skal søges efter</param>
        private void VisMæglere(string navn)
        {

            // Her finder vi de mæglere som matcher med den string vi søger efter.
            Ejendomsmægler[] filterEjendomsmægler = ejendomsmæglere.Where(item => item.Navn.ToLower().Contains(navn.ToLower())).ToArray();

            // Her gennemløbes de fundne mæglere
            foreach (Ejendomsmægler item in filterEjendomsmægler)
            {
                VisEnMægler(item.Mægler_Id, item.Navn, item.Email, item.Telefon);
            }

            if (filterEjendomsmægler.Count() == 0)
            {
                VisEnFejl("Der blev ikke fundet nogen ejendomsmæglere");
            }
        }

        /// <summary>
        /// Tjekker om navn textboxen har en valid værdi
        /// </summary>
        /// <returns>Success</returns>
        private bool ValiderNavn()
        {
            if (Regex.IsMatch(Navn_tb.Text, ("^[a-zA-z æøåÆØÅ-]+$")) || Navn_tb.Text == "")
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
        /// Åbner en form til at oprette en mægler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TilføjMægler_Click(object sender, EventArgs e)
        {
            _baseForm.ÅbenNyForm(new RedigerMæglerForm(_baseForm));
        }

        /// <summary>
        /// Åbner en form til at redigere en mægler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="id"></param>
        private void RedigerMægler_Click(object sender, EventArgs e, int id)
        {
            _baseForm.ÅbenNyForm(new RedigerMæglerForm(_baseForm, id));
        }

        /// <summary>
        /// Søger på den streng som er skrevet ind i textboksen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Søg_Click(object sender, EventArgs e)
        {
            // Fjerner alle controls fra flow layout.
            FlowLayout.Controls.Clear();

            if (Navn_tb.Text != "" && ValiderNavn())
            {

                // Viser boliger med matchende adresse.
                VisMæglere(Navn_tb.Text);
            }
            else
            {

                // Viser alle boliger.
                VisMæglere();
            }
        }

        /// <summary>
        /// Laver validering, hver gang der skrives i søge feltet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Navn_tb_TextChanged(object sender, EventArgs e)
        {
            ValiderNavn();
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

        private void VisEnMægler(int id, string navn, string email, int tlf)
        {
            Panel Mægler = new Panel();
            Button RedigerMægler = new Button();
            Label Tlf = new Label();
            Label Email = new Label();
            Label Ejendomsmægler = new Label();
            Label Navn = new Label();
            // 
            // Mægler
            // 
            Mægler.Controls.Add(RedigerMægler);
            Mægler.Controls.Add(Tlf);
            Mægler.Controls.Add(Email);
            Mægler.Controls.Add(Ejendomsmægler);
            Mægler.Controls.Add(Navn);
            Mægler.Location = new Point(163, 113);
            Mægler.Margin = new Padding(2, 15, 2, 15);
            Mægler.Name = "Mægler";
            Mægler.Size = new Size(275, 181);
            Mægler.TabIndex = 0;
            // 
            // RedigerMægler
            // 
            RedigerMægler.BackColor = Color.FromArgb(77, 157, 224);
            RedigerMægler.FlatStyle = FlatStyle.Flat;
            RedigerMægler.Font = new Font("Roboto Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            RedigerMægler.ForeColor = Color.White;
            RedigerMægler.Location = new Point(6, 132);
            RedigerMægler.Margin = new Padding(2, 2, 2, 2);
            RedigerMægler.Name = "RedigerMægler";
            RedigerMægler.Size = new Size(141, 37);
            RedigerMægler.TabIndex = 4;
            RedigerMægler.Text = "Rediger mægler";
            RedigerMægler.UseVisualStyleBackColor = false;
            RedigerMægler.Click += new EventHandler((sender, e) => RedigerMægler_Click(sender, e, id));
            // 
            // Tlf
            // 
            Tlf.AutoSize = true;
            Tlf.Font = new Font("Roboto Condensed", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tlf.Location = new Point(6, 101);
            Tlf.Margin = new Padding(2, 0, 2, 0);
            Tlf.Name = "Tlf";
            Tlf.Size = new Size(110, 19);
            Tlf.TabIndex = 3;

            // Her sætter vi telefon nummeret til at have mellemrum mellem tallene.
            Tlf.Text = $"Tlf: {tlf:## ## ## ##}";

            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Roboto Condensed", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Email.Location = new Point(6, 70);
            Email.Margin = new Padding(2, 0, 2, 0);
            Email.Name = "Email";
            Email.Size = new Size(202, 19);
            Email.TabIndex = 2;
            Email.Text = $"Email: {email}";
            // 
            // Ejendomsmægler
            // 
            Ejendomsmægler.AutoSize = true;
            Ejendomsmægler.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            Ejendomsmægler.Location = new Point(5, 38);
            Ejendomsmægler.Margin = new Padding(2, 0, 2, 0);
            Ejendomsmægler.Name = "Ejendomsmægler";
            Ejendomsmægler.Size = new Size(133, 22);
            Ejendomsmægler.TabIndex = 1;
            Ejendomsmægler.Text = "Ejendomsmægler";
            // 
            // Navn
            // 
            Navn.AutoSize = true;
            Navn.Font = new Font("Roboto Condensed", 24F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            Navn.Location = new Point(2, 0);
            Navn.Margin = new Padding(2, 0, 2, 0);
            Navn.Name = "Navn";
            Navn.Size = new Size(221, 29);
            Navn.TabIndex = 0;
            Navn.Text = navn;

            FlowLayout.Controls.Add(Mægler);
        }
        #endregion

    }
}
