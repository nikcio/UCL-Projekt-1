using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UCL_Projekt_1.Models;

namespace UCL_Projekt_1
{
    /// <summary>
    /// Skaber en form som kan oprette, opdatere, slette og sælge en bolig.
    /// </summary>
    public partial class RedigerBoligerForm : Form
    {
        /// <summary>
        /// En refrence til BaseForm.
        /// </summary>
        private readonly BaseForm _baseForm;

        /// <summary>
        /// Alle ejendomsmæglere.
        /// </summary>
        private readonly Ejendomsmægler[] alleEjendomsmæglere = IndlæsFraDatabase.IndlæsEjendomsmæglere();

        /// <summary>
        /// Alle kunder.
        /// </summary>
        private readonly Kunde[] alleKunder = IndlæsFraDatabase.IndlæsKunder();

        #region Constructors
        /// <summary>
        /// Kaldes når man skal oprette en bolig.
        /// </summary>
        /// <param name="form">En reference til BaseForm</param>
        public RedigerBoligerForm(BaseForm form)
        {
            InitializeComponent();

            // Her sættes refrencen til BaseForm.
            _baseForm = form;

            // Her findes alle kunder som er sælgere.
            Kunde[] sælgere = alleKunder.Where(item => item.Er_sælger == true).ToArray();

            // Her indlæses alle sælgere i sælger comboBoxen.           
            IndlæsKøberSælger(sælgere, Sælger_comboBox);

            // Her indlæses alle mæglere i mægler comboBoxen.
            IndlæsMæglere(alleEjendomsmæglere);

            // Indstiller de controls som ikke skal bruges til oprettelsen af en bolig.
            OpretForm();
        }

        /// <summary>
        /// Kaldes når en bolig skal redigeres.
        /// </summary>
        /// <param name="form">En reference til BaseForm</param>
        /// <param name="id">Bolig id'et på boligen som skal redigeres</param>
        public RedigerBoligerForm(BaseForm form, int id)
        {
            InitializeComponent();

            // Her sættes refrencen til BaseForm.
            _baseForm = form;

            // Her indlæses informationen omkring boligen i felterne.
            IndlæsInformation(id);

            // Indstiller de controls som ikke skal bruges til at redigere en bolig.
            RedigerForm(IndlæsFraDatabase.IndlæsBolig(id).Solgt);
        }

        /// <summary>
        /// Kaldes når en bolig skal sælges
        /// </summary>
        /// <param name="form">En reference til BaseForm</param>
        /// <param name="id">Bolig id'et på boligen som skal sælges</param>
        /// <param name="sælgBolig">Indikere at vi skal sælge boligen (Bruges til at adskille constructor)</param>
        public RedigerBoligerForm(BaseForm form, int id, bool sælgBolig)
        {
            InitializeComponent();

            // Her sættes refrencen til BaseForm.
            _baseForm = form;

            // Her indlæses informationen omkring boligen i felterne.
            IndlæsInformation(id);

            // Her indlæses købere i comboBoxen.
            IndlæsKøberInformation();

            // Indstiller de controls som ikke skal bruges til at sælge en bolig.
            SælgForm();
        }
        #endregion

        #region Knapper
        /// <summary>
        /// Opretter en bolig.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Opret_Click(object sender, EventArgs e)
        {
            // Her tjekkets om værdierne i felterne opfylder vores krav inden vi opretter boligen.
            if (TjekOpretBolig() == true)
            {
                // Her skriver vi den sql commando som skal køres for at danne en bolig
                string sqlcommandoString = $"INSERT INTO Bolig (Adresse, Grund_areal, Bolig_areal, Boligtype, Udbuds_pris, Solgt, Mægler_Id, Kunde_sælger) " +
                    $"VALUES (@Adresse_tb, @Grund_areal_tb, @Bolig_areal_tb, @Bolig_type_tb, @Udbudspris_tb, @solgt, @mæglerId, @sælger)";

                // Her opretter vi den forige comando som en sqlcommand som skal eksekveres på vores data connection.
                SqlCommand command = new SqlCommand(sqlcommandoString, BaseForm.dataConnection);

                // Her tilføjes vores værdier som parameretre. Dette forhindre at der opstår en uventet sql injection og virker derfor som et ekstra sikkerheds lag.
                command.Parameters.AddWithValue("@Adresse_tb", Adresse_tb.Text);
                command.Parameters.AddWithValue("@Grund_areal_tb", Grund_areal_tb.Text);
                command.Parameters.AddWithValue("@Bolig_areal_tb", Bolig_areal_tb.Text);
                command.Parameters.AddWithValue("@Bolig_type_tb", BoligType_combobox.Text);
                command.Parameters.AddWithValue("@Udbudspris_tb", Udbudspris_tb.Text);
                command.Parameters.AddWithValue("@solgt", 0);
                command.Parameters.AddWithValue("@mæglerId", ((KeyValuePair<int, string>)Mæglere_comboBox.SelectedItem).Key);
                command.Parameters.AddWithValue("@sælger", ((KeyValuePair<int, string>)Sælger_comboBox.SelectedItem).Key);

                // Her forsøger vi at køre vores commando på databasen.
                try
                {
                    BaseForm.dataConnection.Open();
                    command.ExecuteNonQuery();
                    BaseForm.dataConnection.Close();

                    // Hvis commandoen er udført sendes brugeren tilbage til boliger formen.
                    _baseForm.ÅbenNyForm(new BoligerForm(_baseForm));

                }
                catch (Exception exception)
                {
                    // Her tjekker vi på om fejlen skyldes netværket og skriver dertil en passende besked til brugeren.
                    if (exception.GetType() == typeof(SqlException) && exception.Source == ".Net SqlClient Data Provider")
                    {
                        MessageBox.Show("Der kunne oprettes forbinelse til serveren. Tjek venligst din netværks forbindelse og prøv igen.");
                    }
                    else
                    {
                        MessageBox.Show("Der opstod en fejl, prøv igen");
                    }

                }
                finally
                {
                    // Hvis vores connection ikke blev lukket søger vi for at lukke den her.
                    if (BaseForm.dataConnection.State == ConnectionState.Open)
                    {
                        BaseForm.dataConnection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Der opstod en fejl, prøv igen");
            }
        }

        /// <summary>
        /// Redigere en bolig
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rediger_Click(object sender, EventArgs e)
        {
            // Her tjekkets om værdierne i felterne opfylder vores krav inden vi redigere boligen.
            if (TjekRedigerBolig() == true)
            {
                // Her skriver vi den sql commando som skal køres for at redigere en bolig
                string sqlcommandoString = $"UPDATE Bolig SET Udbuds_pris=@Udbudspris_tb WHERE Bolig_id = @Bolig_id_tb";

                // Her opretter vi den forige comando som en sqlcommand som skal eksekveres på vores data connection.
                SqlCommand command = new SqlCommand(sqlcommandoString, BaseForm.dataConnection);

                // Her tilføjes vores værdier som parameretre. Dette forhindre at der opstår en uventet sql injection og virker derfor som et ekstra sikkerheds lag.
                command.Parameters.AddWithValue("@Bolig_id_tb", Bolig_id_tb.Text);
                command.Parameters.AddWithValue("@Udbudspris_tb", Udbudspris_tb.Text);

                // Her forsøger vi at køre vores commando på databasen.
                try
                {
                    BaseForm.dataConnection.Open();
                    command.ExecuteNonQuery();
                    BaseForm.dataConnection.Close();

                    // Hvis commandoen er udført sendes brugeren tilbage til boliger formen.
                    _baseForm.ÅbenNyForm(new BoligerForm(_baseForm));

                }
                catch (Exception exception)
                {
                    // Her tjekker vi på om fejlen skyldes netværket og skriver dertil en passende besked til brugeren.
                    if (exception.GetType() == typeof(SqlException) && exception.Source == ".Net SqlClient Data Provider")
                    {
                        MessageBox.Show("Der kunne oprettes forbinelse til serveren. Tjek venligst din netværks forbindelse og prøv igen.");
                    }
                    else
                    {
                        MessageBox.Show("Der opstod en fejl, prøv igen");
                    }

                }
                finally
                {
                    // Hvis vores connection ikke blev lukket søger vi for at lukke den her.
                    if (BaseForm.dataConnection.State == ConnectionState.Open)
                    {
                        BaseForm.dataConnection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Der opstod en fejl, prøv igen ");
            }
        }

        /// <summary>
        /// Sletter en bolig
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Slet_Click(object sender, EventArgs e)
        {
            // Her tjekkets om værdierne i felterne opfylder vores krav inden vi sletter boligen.
            if (TjekSletBolig() == true)
            {
                // Her skriver vi den sql commando som skal køres for at slette en bolig
                string sqlcommandoString = $"DELETE FROM Bolig WHERE Bolig_id = @Bolig_id_tb";

                // Her opretter vi den forige comando som en sqlcommand som skal eksekveres på vores data connection.
                SqlCommand command = new SqlCommand(sqlcommandoString, BaseForm.dataConnection);

                // Her tilføjes vores værdier som parameretre. Dette forhindre at der opstår en uventet sql injection og virker derfor som et ekstra sikkerheds lag.
                command.Parameters.AddWithValue("@Bolig_id_tb", Bolig_id_tb.Text);

                // Her forsøger vi at køre vores commando på databasen.
                try
                {
                    BaseForm.dataConnection.Open();
                    command.ExecuteNonQuery();
                    BaseForm.dataConnection.Close();

                    // Hvis commandoen er udført sendes brugeren tilbage til boliger formen.
                    _baseForm.ÅbenNyForm(new BoligerForm(_baseForm));
                }
                catch (Exception exception)
                {
                    // Her tjekker vi på om fejlen skyldes netværket og skriver dertil en passende besked til brugeren.
                    if (exception.GetType() == typeof(SqlException) && exception.Source == ".Net SqlClient Data Provider")
                    {
                        MessageBox.Show("Der kunne oprettes forbinelse til serveren. Tjek venligst din netværks forbindelse og prøv igen.");
                    }
                    else
                    {
                        MessageBox.Show("Der opstod en fejl, prøv igen");
                    }

                }
                finally
                {
                    // Hvis vores connection ikke blev lukket søger vi for at lukke den her.
                    if (BaseForm.dataConnection.State == ConnectionState.Open)
                    {
                        BaseForm.dataConnection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Der opstod en fejl, prøv igen ");
            }
        }

        /// <summary>
        /// Sælger en bolig til en kunde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sælg_bolig_Click(object sender, EventArgs e)
        {

            // Her tjekkets om værdierne i felterne opfylder vores krav inden vi sælger boligen.
            if (TjekSælgBolig() == true)
            {

                // Her opretter vi et salg af en bolig.
                if (OpretSalgAfBolig() == true)
                {
                    // Hvis salget blev oprettet markere vi nu boligen som solgt.
                    MarkerBoligSomSolgt();
                }

            }
            else
            {
                MessageBox.Show("Der opstod en fejl, prøv igen ");
            }

        }

        private void Romertal_tb_TextChanged(object sender, EventArgs e)
        {
            if(Numerisk_tb.Text != "")
            {
                Numerisk_tb.Text = "";
            }
        }

        private void Numerisk_tb_TextChanged(object sender, EventArgs e)
        {
            if(Romertal_tb.Text != "")
            {
                Romertal_tb.Text = "";
            }
        }

        private void KonverterTal_Click(object sender, EventArgs e)
        {
            if(Numerisk_tb.Text != "" && int.TryParse(Numerisk_tb.Text, out int result))
            {
                string output = TilRomerTal.TilRomer(result);
                Romertal_tb.Text = "Udregner";
                Romertal_tb.Text = output;
            }
            else if(Romertal_tb.Text != "" && Regex.IsMatch(Romertal_tb.Text, ("^[MDCLXVImdclxvi]+$")))
            {
                string output = RomertalKonvertering.RomerTalConverter(Romertal_tb.Text).ToString();
                Numerisk_tb.Text = "Udregner";
                Numerisk_tb.Text = output;
            }
            else
            {
                MessageBox.Show("Udfyld en værdi for at konvertatere");
            }
        }
        #endregion

        #region Metoder
        /// <summary>
        /// Markerer en bolig som solgt
        /// </summary>
        /// <returns>Success</returns>
        private void MarkerBoligSomSolgt()
        {
            // Her skriver vi den sql commando som skal køres for at redigere en bolig
            string sqlcommandoString = $"UPDATE Bolig SET Solgt=@Solgt, Udbuds_pris=@Udbudspris, Kunde_køber=@Køber WHERE Bolig_id=@Bolig_id_tb";

            // Her opretter vi den forige comando som en sqlcommand som skal eksekveres på vores data connection.
            SqlCommand command = new SqlCommand(sqlcommandoString, BaseForm.dataConnection);

            // Her tilføjes vores værdier som parameretre. Dette forhindre at der opstår en uventet sql injection og virker derfor som et ekstra sikkerheds lag.
            command.Parameters.AddWithValue("@Solgt", 1); // 1=true fordi det er en bool.
            command.Parameters.AddWithValue("@Bolig_id_tb", Bolig_id_tb.Text);
            command.Parameters.AddWithValue("@Udbudspris", Udbudspris_tb.Text);

            // Her tager vi key værdien fra vores køber combobox og bruger den som værdi da, den refere til kunde id'et for køberen.
            command.Parameters.AddWithValue("@Køber", ((KeyValuePair<int, string>)Køber_comboBox.SelectedItem).Key);

            // Her forsøger vi at køre vores commando på databasen.
            try
            {
                BaseForm.dataConnection.Open();
                command.ExecuteNonQuery();
                BaseForm.dataConnection.Close();

                // Hvis commandoen er udført sendes brugeren tilbage til boliger formen.
                _baseForm.ÅbenNyForm(new BoligerForm(_baseForm));
            }
            catch (Exception exception)
            {
                // Her tjekker vi på om fejlen skyldes netværket og skriver dertil en passende besked til brugeren.
                if (exception.GetType() == typeof(SqlException) && exception.Source == ".Net SqlClient Data Provider")
                {
                    MessageBox.Show("Der kunne oprettes forbinelse til serveren. Tjek venligst din netværks forbindelse og prøv igen.");
                }
                else
                {
                    MessageBox.Show("Der opstod en fejl, prøv igen");
                }

            }
            finally
            {
                // Hvis vores connection ikke blev lukket søger vi for at lukke den her.
                if (BaseForm.dataConnection.State == ConnectionState.Open)
                {
                    BaseForm.dataConnection.Close();
                }
            }
        }

        /// <summary>
        /// Opretter et salg af en bolig
        /// </summary>
        /// <returns>Success</returns>
        private bool OpretSalgAfBolig()
        {
            // Her skriver vi den sql commando som skal køres for at oprette et salg
            string sqlcommandoString = $"INSERT INTO Salg (Dato, Pris, Mægler_id, Bolig_id) VALUES (@Dato, @Udbudspris, @Mægler_id, @Bolig_id)";

            // Her opretter vi den forrige commando som en sqlcommand som skal eksekveres på vores data connection.
            SqlCommand command = new SqlCommand(sqlcommandoString, BaseForm.dataConnection);

            // Her tilføjes vores værdier som parametre. Dette forhindre at der opstår en uventet sql injection og virker derfor som et ekstra sikkerheds lag.
            command.Parameters.AddWithValue("@Udbudspris", Udbudspris_tb.Text);
            command.Parameters.AddWithValue("@Bolig_id", Bolig_id_tb.Text);
            command.Parameters.AddWithValue("@Dato", Date.SelectionRange.Start.Date);

            // Her tager vi key værdien fra vores mægler combobox og bruger den som værdi da, den refere til mægler id'et
            command.Parameters.AddWithValue("@Mægler_id", ((KeyValuePair<int, string>)Mæglere_comboBox.SelectedItem).Key);

            // Her forsøger vi at køre vores commando på databasen.
            try
            {
                BaseForm.dataConnection.Open();
                command.ExecuteNonQuery();
                BaseForm.dataConnection.Close();
                return true;
            }
            catch (Exception exception)
            {
                // Her tjekker vi på om fejlen skyldes netværket og skriver dertil en passende besked til brugeren.
                if (exception.GetType() == typeof(SqlException) && exception.Source == ".Net SqlClient Data Provider")
                {
                    MessageBox.Show("Der kunne oprettes forbinelse til serveren. Tjek venligst din netværks forbindelse og prøv igen.");
                }
                else
                {
                    MessageBox.Show("Der opstod en fejl, prøv igen");
                }
                return false;

            }
            finally
            {
                // Hvis vores connection ikke blev lukket søger vi for at lukke den her.
                if (BaseForm.dataConnection.State == ConnectionState.Open)
                {
                    BaseForm.dataConnection.Close();
                }
            }
        }

        /// <summary>
        /// Indlæser alle mæglere og indstiller dem som værdier i comboBoxen
        /// </summary>
        /// <param name="mæglers">De mæglere som skal indlæses</param>
        private void IndlæsMæglere(Ejendomsmægler[] mæglers)
        {

            // Her oprettes en liste med key value pairs. Dette bruges til at opbevare både mægler id og titel med mægler navn, samt mægler id.
            var valgmuligheder = new BindingList<KeyValuePair<int, string>>();

            // Her gennemløbes alle mæglere
            foreach (var item in mæglers)
            {

                // For hver mægler tilføjes et key value pair som indeholder et mægler id og en titel med navn og mægler id.
                valgmuligheder.Add(new KeyValuePair<int, string>(item.Mægler_Id, $"{item.Navn}, Id: {item.Mægler_Id}"));
            }

            // Her sættes comboBoxens data til den førhen dannet liste
            Mæglere_comboBox.DataSource = valgmuligheder;

            // Her sættes comboboksens value til at være vores key i key value pairet.
            Mæglere_comboBox.ValueMember = "Key";

            // Her sættes comboBoxens visning til vores value i key value pairet.
            Mæglere_comboBox.DisplayMember = "Value";
        }

        /// <summary>
        /// Indlæser kunder i en combobox.
        /// </summary>
        /// <param name="mæglers"></param>
        /// <param name="comboBox"></param>
        private void IndlæsKøberSælger(Kunde[] mæglers, ComboBox comboBox)
        {

            // Her oprettes en liste med key value pairs. Dette bruges til at opbevare både kunde id og titel med kunde navn, samt kunde id.
            var valgmuligheder = new BindingList<KeyValuePair<int, string>>();

            // Her gennemløbes alle mæglere
            foreach (var item in mæglers)
            {

                // For hver mægler tilføjes et key value pair som indeholder et kunde id og en titel med navn og kunde id.
                valgmuligheder.Add(new KeyValuePair<int, string>(item.Kunde_Id, $"{item.Navn}, Id: {item.Kunde_Id}"));
            }

            // Her sættes comboBoxens data til den førhen dannet liste
            comboBox.DataSource = valgmuligheder;

            // Her sættes comboboksens value til at være vores key i key value pairet.
            comboBox.ValueMember = "Key";

            // Her sættes comboBoxens visning til vores value i key value pairet.
            comboBox.DisplayMember = "Value";
        }

        /// <summary>
        /// Fjerner alle de controls som ikke bruges i opretelsen.
        /// </summary>
        private void OpretForm()
        {
            Bolig_id_tb.Enabled = false;
            Bolig_id.Enabled = false;
            Rediger.Visible = false;
            Slet.Visible = false;
            Date.Visible = false;
            Sælg_bolig.Visible = false;
            SalgsDatoText.Visible = false;
            Køber.Enabled = false;
            Køber_comboBox.Enabled = false;
        }

        /// <summary>
        /// Deaktivere og fjerner alle de controls som ikke bruges i redigeringen.
        /// </summary>
        private void RedigerForm(bool solgt)
        {
            Adresse_tb.Enabled = false;
            Grund_areal_tb.Enabled = false;
            Bolig_areal_tb.Enabled = false;
            BoligType_combobox.Enabled = false;
            Mæglere_comboBox.Enabled = false;
            Bolig_id_tb.Enabled = false;
            Opret.Visible = false;
            Sælger_comboBox.Enabled = false;
            Sælg_bolig.Visible = false;
            RomertalKoverteringPanel.Visible = false;
            SalgsDatoText.Visible = false;
            Date.Visible = false;
            Køber_comboBox.Enabled = false;

            // Hvis boligen er solgt skal vi ikke kunne ændre oplysningerne på den.
            if (solgt)
            {
                Udbudspris_tb.Enabled = false;
                Rediger.Enabled = false;
            }
        }

        /// <summary>
        /// Deaktivere og fjerner alle de controls som ikke bruges i salget.
        /// </summary>
        private void SælgForm()
        {
            Adresse_tb.Enabled = false;
            Grund_areal_tb.Enabled = false;
            Bolig_areal_tb.Enabled = false;
            BoligType_combobox.Enabled = false;
            Mæglere_comboBox.Enabled = false;
            Bolig_id_tb.Enabled = false;
            Sælger_comboBox.Enabled = false;
            Opret.Visible = false;
            Rediger.Visible = false;
            Slet.Visible = false;
            RomertalKoverteringPanel.Visible = false;
        }

        /// <summary>
        /// Indsætter bolig informationen i text felterne.
        /// </summary>
        /// <param name="id">Bolig id'et for boligen der skal indlæses</param>
        private void IndlæsInformation(int id)
        {
            // Her indlæses boligen fra databasen.
            Bolig bolig = IndlæsFraDatabase.IndlæsBolig(id);

            // Her indlæses mægler information fra databasen.
            Ejendomsmægler ejendomsmægler = IndlæsFraDatabase.IndlæsEjendomsmægler(bolig.Mægler_Id);

            // Her indlæses sælger information fra databasen.
            Kunde sælger = IndlæsFraDatabase.IndlæsKunde(bolig.Kunde_sælger);

            // Her indlæses køber information fra databasen.
            Kunde køber = IndlæsFraDatabase.IndlæsKunde(bolig.Kunde_køber);

            //Her indsættes dataen i felterne.
            Adresse_tb.Text = bolig.Addresse;
            Grund_areal_tb.Text = bolig.Grund_areal.ToString();
            Bolig_areal_tb.Text = bolig.Bolig_areal.ToString();
            BoligType_combobox.Text = bolig.Boligtype;
            Udbudspris_tb.Text = bolig.Udbuds_pris.ToString();
            Bolig_id_tb.Text = bolig.Bolig_Id.ToString();

            // Her tages højde for mulig manglende information i databasen.
            if (ejendomsmægler != null)
            {
                // Her sættes mægler værdien i form af et key value pair med mægler id og en titel
                Mæglere_comboBox.Items.Add(new KeyValuePair<int, string>(ejendomsmægler.Mægler_Id, $"{ejendomsmægler.Navn}, Id: {ejendomsmægler.Mægler_Id}"));

                // Her sættes comboboksens value til at være vores key i key value pairet.
                Mæglere_comboBox.ValueMember = "Key";

                // Her sættes comboBoxens visning til vores value i key value pairet.
                Mæglere_comboBox.DisplayMember = "Value";

                // Her stiller vi den tilføjet værdi som den markeret værdi. Hvilket vil sige det er den som vises.
                Mæglere_comboBox.SelectedIndex = 0;
            }

            // Her tages højde for mulig manglende information i databasen.
            if (sælger != null)
            {
                Sælger_comboBox.Items.Add(new KeyValuePair<int, string>(sælger.Kunde_Id, $"{sælger.Navn}, Id: {sælger.Kunde_Id}"));

                // Her sættes comboboksens value til at være vores key i key value pairet.
                Sælger_comboBox.ValueMember = "Key";

                // Her sættes comboBoxens visning til vores value i key value pairet.
                Sælger_comboBox.DisplayMember = "Value";

                // Her stiller vi den tilføjet værdi som den markeret værdi. Hvilket vil sige det er den som vises.
                Sælger_comboBox.SelectedIndex = 0;
            }

            // Her tages højde for mulig manglende information i databasen.
            if (køber != null)
            {
                Køber_comboBox.Items.Add(new KeyValuePair<int, string>(køber.Kunde_Id, $"{køber.Navn}, Id: {køber.Kunde_Id}"));

                // Her sættes comboboksens value til at være vores key i key value pairet.
                Køber_comboBox.ValueMember = "Key";

                // Her sættes comboBoxens visning til vores value i key value pairet.
                Køber_comboBox.DisplayMember = "Value";

                // Her stiller vi den tilføjet værdi som den markeret værdi. Hvilket vil sige det er den som vises.
                Køber_comboBox.SelectedIndex = 0;
            }

        }

        /// <summary>
        /// Indlæser købere og indsætter dem i comboBoxen.
        /// </summary>
        private void IndlæsKøberInformation()
        {
            // Her finder vi alle kunder som er købere.
            // Der soteres her på Er_køber booleanen som en kunde har.
            Kunde[] købere = alleKunder.Where(item => item.Er_køber == true).ToArray();

            // Her indlæses køberne i køber comboBoxen
            IndlæsKøberSælger(købere, Køber_comboBox);
        }

        /// <summary>
        /// Tjekker om felterne brugt i redigering indholder korekte værider
        /// </summary>
        /// <returns>Er felterne valide</returns>
        private bool TjekRedigerBolig()
        {
            int i = 0;
            if (!int.TryParse(Bolig_id_tb.Text, out i))
            {
                return false;
            }
            int l = 0;
            if (!int.TryParse(Udbudspris_tb.Text, out l))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Tjekker om felterne brugt i salg indholder korekte værider
        /// </summary>
        /// <returns>Er felterne valide</returns>
        private bool TjekSælgBolig()
        {
            int i = 0;
            if (!int.TryParse(Bolig_id_tb.Text, out i))
            {
                return false;
            }
            int l = 0;
            if (!int.TryParse(Udbudspris_tb.Text, out l))
            {
                return false;
            }
            // TODO: Dato og Køber validering?
            return true;
        }

        /// <summary>
        /// Tjekker om felterne brugt i slet indholder korekte værider
        /// </summary>
        /// <returns>Er felterne valide</returns>
        private bool TjekSletBolig()
        {
            int i = 0;
            if (!int.TryParse(Bolig_id_tb.Text, out i))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Tjekker om felterne brugt i salg indholder korekte værider
        /// </summary>
        /// <returns>Er felterne valide</returns>
        private bool TjekOpretBolig()
        {
            int j = 0;
            if (!int.TryParse(Grund_areal_tb.Text, out j))
            {
                return false;
            }

            int k = 0;
            if (!int.TryParse(Bolig_areal_tb.Text, out k))
            {
                return false;
            }

            int l = 0;
            if (!int.TryParse(Udbudspris_tb.Text, out l))
            {
                return false;
            }

            string[] adresse = Adresse_tb.Text.Split(',');
            if (adresse.Length != 2)
            {
                return false;
            }
            return true;
        }
        #endregion

    }
}
