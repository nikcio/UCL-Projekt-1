using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UCL_Projekt_1.Models;

namespace UCL_Projekt_1
{
    /// <summary>
    /// Viser alle boliger og gør det muligt at tilgå funktioner for boliger.
    /// </summary>
    public partial class BoligerForm : Form
    {
        /// <summary>
        /// En refrence til BaseForm.
        /// </summary>
        private readonly BaseForm _baseForm;

        /// <summary>
        /// Et array over alle boliger i databasen.
        /// </summary>
        private readonly Bolig[] _boliger = IndlæsFraDatabase.IndlæsBoliger();

        /// <summary>
        /// Constructor til Boliger form. Her indlæses alle boliger og vises i formen.
        /// </summary>
        /// <param name="form">En refrence til BaseForm</param>
        public BoligerForm(BaseForm form)
        {
            InitializeComponent();

            // Her sættes referencen til BaseForm.
            _baseForm = form;

            // Her vises alle boliger
            VisBoliger();
        }


        // Indeholder de metoder som styrer hvilke boliger der skal vises.
        #region Visning af boliger

        /// <summary>
        /// Viser alle boliger.
        /// </summary>
        private void VisBoliger()
        {
            // Alle boliger gennemløbes.
            foreach (var bolig in _boliger)
            {
                // Adressen splittes ved komma for at kunne adskilde vej og by.
                string[] adresse = bolig.Addresse.Split(',');

                // Boligen vises i formen med den information som påkræves.
                // Der tages højde for at adressen kan være forkert indskrevet.
                VisEnBolig(
                    adresse.Length >= 1 ? adresse[0] : "Mangler adresse",
                    adresse.Length >= 2 ? adresse[1] : "Mangler by",
                    bolig.Udbuds_pris,
                    bolig.Bolig_Id,
                    bolig.Solgt
                );
            }

            // Viser en fejl, hvis der ikke findes nogle boliger.
            if (_boliger.Count() == 0)
            {
                VisEnFejl("Der blev ikke fundet nogle boliger");
            }
        }

        /// <summary>
        /// Viser alle boliger, hvor stringen 'område' kan findes i adressen.
        /// </summary>
        /// <param name="område">Området der søges efter</param>
        private void VisBoliger(string område)
        {

            // Et array med de filtrerede boliger.
            // Her filtreres efter om adressen indeholder 'område' stringen.
            // Vi søger for at der ikke er forskel på små og store bogstaver.
            Bolig[] filterBoliger = _boliger.Where(item => item.Addresse.ToLower().Contains(område.ToLower())).ToArray();

            // Alle de filtrerede boliger gennemløbes
            foreach (var bolig in filterBoliger)
            {

                // Adressen splittes ved komma for at kunne adskilde vej og by.
                string[] adresse = bolig.Addresse.Split(',');

                // Boligen vises i formen med den information som påkræves.
                // Der tages højde for at adressen kan være forkert indskrevet.
                VisEnBolig(
                    adresse.Length >= 1 ? adresse[0] : "Mangler adresse",
                    adresse.Length >= 2 ? adresse[1] : "Mangler by",
                    bolig.Udbuds_pris,
                    bolig.Bolig_Id,
                    bolig.Solgt
                );
            }

            // Viser en fejl, hvis der ikke findes nogle boliger.
            if (filterBoliger.Count() == 0)
            {
                VisEnFejl("Der blev ikke fundet nogle boliger");
            }
        }

        /// <summary>
        /// Viser den bolig med det gældende bolig id, hvis den findes
        /// </summary>
        /// <param name="boligId">Bolig id'et der søges efter</param>
        private void VisBolig(int boligId)
        {

            // Den bolig med det gældende bolig id.
            // Her filtreres efter bolig id.
            Bolig filterBolig = _boliger.FirstOrDefault(item => item.Bolig_Id == boligId);

            // Hvis boligen findes vises den.
            if (filterBolig != null)
            {

                // Adressen splittes ved komma for at kunne adskilde vej og by.
                string[] adresse = filterBolig.Addresse.Split(',');

                // Boligen vises i formen med den information som påkræves.
                // Der tages højde for at adressen kan være forkert indskrevet.
                VisEnBolig(
                    adresse.Length >= 1 ? adresse[0] : "Mangler adresse",
                    adresse.Length >= 2 ? adresse[1] : "Mangler by",
                    filterBolig.Udbuds_pris,
                    filterBolig.Bolig_Id,
                    filterBolig.Solgt
                );
            }
            else
            {

                // Viser en fejl, hvis der ikke findes nogle boliger.
                VisEnFejl("Der blev ikke fundet nogle boliger");
            }

        }
        #endregion

        /// <summary>
        /// Åbner en ny form til at tilføje en bolig, hvis knappen trykkes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TilføjBolig_Click(object sender, EventArgs e)
        {
            _baseForm.ÅbenNyForm(new RedigerBoligerForm(_baseForm));
        }

        /// <summary>
        /// Åbner en ny form til at redigere en bolig, hvis knappen trykkes.
        /// </summary>
        /// <param name="id">Id'et på boligen som skal redigeres</param>
        private void RedigerBolig_Click(int id)
        {
            _baseForm.ÅbenNyForm(new RedigerBoligerForm(_baseForm, id));
        }

        /// <summary>
        /// Åbner en ny form til at sælge en bolig, hvis knappen trykkes.
        /// </summary>
        /// <param name="id">Id'et på boligen der skal sælges</param>
        private void SælgBolig_Click(int id)
        {
            _baseForm.ÅbenNyForm(new RedigerBoligerForm(_baseForm, id, true));
        }

        /// <summary>
        /// Søger efter boliger der matcher søgefelts parameterne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Søg_Click(object sender, EventArgs e)
        {

            // Fjerner alle controls fra flow layout.
            FlowLayout.Controls.Clear();

            if (BoligId.Text != "" && int.TryParse(BoligId.Text, out int resultat))
            {
                BoligIdValidation.Text = "";

                // Viser boligen med id'et.
                VisBolig(resultat);
            }
            else if (Adresse_tb.Text != "" && ValiderAdresse())
            {

                // Viser boliger med matchende adresse.
                VisBoliger(Adresse_tb.Text);
            }
            else
            {

                // Viser alle boliger.
                VisBoliger();
            }
        }

        /// <summary>
        /// Kaldes når adresse boksen ændres. Her sørger vi for at der ikke skrives noget i både bolig id og adresse, da vi kun kan søge på en af delene og vi laver validering.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Adresse_tb_TextChanged(object sender, EventArgs e)
        {
            if (BoligId.Text != "")
            {
                BoligId.Text = "";
            }

            // Her tjekkes at adressen ikke indeholder specielle symboler.
            ValiderAdresse();
        }

        /// <summary>
        /// Her tjekkes at adressen ikke indeholder specielle symboler.
        /// </summary>
        /// <returns>Success</returns>
        private bool ValiderAdresse()
        {
            if (Regex.IsMatch(Adresse_tb.Text, ("^[a-zA-z æøåÆØÅ0-9,]+$")) || Adresse_tb.Text == "")
            {
                AdresseValidering.Text = "";
                return true;
            }
            else
            {
                AdresseValidering.Text = "Adressen kan ikke indeholde specielle symboler";
                return false;
            }
        }

        /// <summary>
        /// Kaldes når bolig id ændres. Her sørger vi for at der ikke skrives noget i både bolig id og adresse, da vi kun kan søge på en af delene og vi laver validering.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoligId_TextChanged(object sender, EventArgs e)
        {
            if (Adresse_tb.Text != "")
            {
                Adresse_tb.Text = "";
            }

            // Her tjekkes på om bolig id er et tal og hvis ikke skrives en fejl.
            ValiderBolidId();
        }

        /// <summary>
        /// Her tjekkes på om bolig id er et tal og hvis ikke skrives en fejl.
        /// </summary>
        /// <returns>Success</returns>
        private bool ValiderBolidId()
        {
            if (int.TryParse(BoligId.Text, out int _) || BoligId.Text == "")
            {
                BoligIdValidation.Text = "";
                return true;
            }
            else
            {
                BoligIdValidation.Text = "Bolid id skal være et tal";
                return false;
            }
        }

        #region Opret visuelle elementer
        /// <summary>
        /// Viser en fejlbesked til brugeren.
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

        /// <summary>
        /// Danner et panel med de controls som skal vises for en bolig.
        /// </summary>
        /// <param name="adresse">Adressen for boligen</param>
        /// <param name="by">Byen for boligen</param>
        /// <param name="pris">Prisen for boligen</param>
        /// <param name="id">Id'et for boligen</param>
        private void VisEnBolig(string adresse, string by, int pris, int id, bool solgt)
        {
            var Bolig = new Panel();
            var Pris_label = new Label();
            var SælgBolig = new Button();
            var RedigerBolig = new Button();
            var Pris = new Label();
            var By = new Label();
            var Adresse = new Label();
            // 
            // Bolig
            // 
            Bolig.Controls.Add(Pris_label);
            Bolig.Controls.Add(SælgBolig);
            Bolig.Controls.Add(RedigerBolig);
            Bolig.Controls.Add(Pris);
            Bolig.Controls.Add(By);
            Bolig.Controls.Add(Adresse);
            Bolig.Location = new Point(37, 33);
            Bolig.Margin = new Padding(2, 15, 2, 15);
            Bolig.Name = "Bolig";
            Bolig.Size = new Size(275, 156);
            Bolig.TabIndex = 0;
            // 
            // Pris_label
            // 
            Pris_label.AutoSize = true;
            Pris_label.Font = new Font("Roboto Condensed", 22F, FontStyle.Regular, GraphicsUnit.World, 0);
            Pris_label.Location = new Point(3, 115);
            Pris_label.Name = "Pris_label";
            Pris_label.Size = new Size(51, 27);
            Pris_label.TabIndex = 6;
            Pris_label.Text = "Pris:";
            // 
            // SælgBolig
            // 
            SælgBolig.BackColor = Color.Transparent;
            SælgBolig.BackgroundImageLayout = ImageLayout.None;
            SælgBolig.FlatAppearance.BorderColor = Color.FromArgb(77, 154, 224);
            SælgBolig.FlatAppearance.BorderSize = 2;
            SælgBolig.FlatAppearance.MouseOverBackColor = Color.FromArgb(77, 154, 224);
            SælgBolig.FlatStyle = FlatStyle.Flat;
            SælgBolig.Font = new Font("Roboto Condensed", 16F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            SælgBolig.ForeColor = Color.Black;
            SælgBolig.Location = new Point(144, 73);
            SælgBolig.Margin = new Padding(2);
            SælgBolig.Name = "SælgBolig";
            SælgBolig.Size = new Size(120, 30);
            SælgBolig.TabIndex = 5;
            SælgBolig.Text = "Sælg bolig";
            SælgBolig.UseVisualStyleBackColor = false;
            SælgBolig.Click += new EventHandler((sender, e) => SælgBolig_Click(id));

            // Hvis boligen er solgt skal man ikke kunne sælge den igen.
            if (solgt)
            {
                SælgBolig.Enabled = false;
                SælgBolig.Text = "SOLGT";
            }

            // 
            // RedigerBolig
            // 
            RedigerBolig.BackColor = Color.FromArgb(77, 154, 224);
            RedigerBolig.BackgroundImageLayout = ImageLayout.None;
            RedigerBolig.FlatAppearance.BorderSize = 0;
            RedigerBolig.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 113, 185);
            RedigerBolig.FlatStyle = FlatStyle.Flat;
            RedigerBolig.Font = new Font("Roboto Condensed", 16F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            RedigerBolig.ForeColor = Color.White;
            RedigerBolig.Location = new Point(7, 73);
            RedigerBolig.Margin = new Padding(2);
            RedigerBolig.Name = "RedigerBolig";
            RedigerBolig.Size = new Size(120, 30);
            RedigerBolig.TabIndex = 3;
            RedigerBolig.Text = "Rediger bolig";
            RedigerBolig.UseVisualStyleBackColor = false;
            RedigerBolig.Click += new EventHandler((sender, e) => RedigerBolig_Click(id));

            // Hvis boligen er solgt skal man ikke kunne redigere den.
            if (solgt)
            {
                RedigerBolig.Text = "Se oplysninger";
            }

            // 
            // Pris
            // 
            Pris.AutoSize = true;
            Pris.Font = new Font("Roboto Condensed", 22F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            Pris.Location = new Point(59, 115);
            Pris.Margin = new Padding(2, 0, 2, 0);
            Pris.Name = "Pris";
            Pris.Size = new Size(150, 27);
            Pris.TabIndex = 2;
            Pris.Text = $"{pris:C2}";
            // 
            // By
            // 
            By.AutoSize = true;
            By.Font = new Font("Roboto Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            By.Location = new Point(2, 39);
            By.Margin = new Padding(2, 0, 2, 0);
            By.Name = "By";
            By.Size = new Size(93, 25);
            By.TabIndex = 1;
            By.Text = by;
            // 
            // Adresse
            // 
            Adresse.AutoSize = true;
            Adresse.Font = new Font("Roboto Condensed", 24F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            Adresse.Location = new Point(2, 0);
            Adresse.Margin = new Padding(2, 0, 2, 0);
            Adresse.Name = "Adresse";
            Adresse.Size = new Size(188, 29);
            Adresse.TabIndex = 0;
            Adresse.Text = adresse;

            // Panelet tilføjet til flow layoutet.
            FlowLayout.Controls.Add(Bolig);
        }
        #endregion
    }
}
