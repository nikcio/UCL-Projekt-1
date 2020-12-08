using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UCL_Projekt_1.Models;

namespace UCL_Projekt_1
{

    /// <summary>
    /// Skaber en form til at oprette, redigere og slette kunder
    /// </summary>
    public partial class RedigerKunderForm : Form
    {
        /// <summary>
        /// En refrence til BaseForm.
        /// </summary>
        private BaseForm _baseForm;

        /// <summary>
        /// Constructoren til at oprette en kunde
        /// </summary>
        /// <param name="form">En reference til BaseForm</param>
        public RedigerKunderForm(BaseForm form)
        {
            InitializeComponent();

            // Her sættes refrencen til BaseForm.
            _baseForm = form;

            // Indstiller de controls som ikke skal bruges til oprettelsen af en kunde.
            OpretForm();
        }

        /// <summary>
        /// Constructoren til at redigere/slette en kunde
        /// </summary>
        /// <param name="form">En reference til BaseForm</param>
        /// <param name="id">Kunde id'et på boligen som skal redigeres</param>
        public RedigerKunderForm(BaseForm form, int id)
        {
            InitializeComponent();

            // Her sættes refrencen til BaseForm.
            _baseForm = form;

            // Udfylder felterne med information omkring kunden
            IndlæsInformation(id);

            // Indstiller de controls som ikke skal bruges til redigeringen af en kunde.
            RedigerForm();
        }

        /// <summary>
        /// Indstiller de controls som ikke skal bruges til oprettelsen af en kunde.
        /// </summary>
        private void OpretForm()
        {
            Rediger_kunde.Visible = false;
            Slet_Kunde.Visible = false;
        }

        /// <summary>
        /// Indstiller de controls som ikke skal bruges til redigering af en kunde.
        /// </summary>
        private void RedigerForm()
        {
            Opret_kunde.Visible = false;
        }

        /// <summary>
        /// Opretter en kunde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Opret_kunde_Click(object sender, EventArgs e)
        {
            // Her tjekkets om værdierne i felterne opfylder vores krav inden vi opretter kunden.
            if (TjekKundeVærdier() == true)
            {
                // Her skriver vi den sql commando som skal køres for at danne en bolig
                string sqlcommandoString = $"INSERT INTO Kunde (Navn, Telefon, Email,Er_sælger, Er_køber) " +
                    $"VALUES (@Kunde_navn_tb, @Kunde_tlf_tb, @Kunde_email_tb, @Er_sælger, @Er_køber)";

                // Her opretter vi den forige comando som en sqlcommand som skal eksekveres på vores data connection.
                SqlCommand command = new SqlCommand(sqlcommandoString, BaseForm.dataConnection);

                // Her tilføjes vores værdier som parameretre. Dette forhindre at der opstår en uventet sql injection og virker derfor som et ekstra sikkerheds lag.
                command.Parameters.AddWithValue("@Kunde_navn_tb", Kunde_navn_tb.Text);
                command.Parameters.AddWithValue("@Kunde_tlf_tb", Kunde_tlf_tb.Text);
                command.Parameters.AddWithValue("@Kunde_email_tb", Kunde_email_tb.Text);
                command.Parameters.AddWithValue("@Er_sælger", Er_sælger.Checked);
                command.Parameters.AddWithValue("@Er_køber", Er_køber.Checked);

                // Her forsøger vi at køre vores commando på databasen.
                try
                {
                    BaseForm.dataConnection.Open();
                    command.ExecuteNonQuery();
                    BaseForm.dataConnection.Close();

                    // Hvis commandoen er udført sendes brugeren tilbage til kunde formen.
                    _baseForm.ÅbenNyForm(new KunderForm(_baseForm));

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
        /// Redigere en kunde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rediger_kunde_Click(object sender, EventArgs e)
        {
            // Her tjekkets om værdierne i felterne opfylder vores krav inden vi redigere boligen.
            if (TjekKundeVærdier() == true)
            {
                // Her skriver vi den sql commando som skal køres for at redigere en bolig
                string sqlcommandoString = $"UPDATE Kunde SET Navn=@Kunde_navn_tb, Telefon=@Kunde_tlf_tb, Email=@Kunde_email_tb, Er_sælger=@Er_sælger, Er_køber=@Er_køber  " +
                    $"WHERE Kunde_id=@Kunde_id_tb";

                // Her opretter vi den forige comando som en sqlcommand som skal eksekveres på vores data connection.
                SqlCommand command = new SqlCommand(sqlcommandoString, BaseForm.dataConnection);

                // Her tilføjes vores værdier som parameretre. Dette forhindre at der opstår en uventet sql injection og virker derfor som et ekstra sikkerheds lag.
                command.Parameters.AddWithValue("@Kunde_navn_tb", Kunde_navn_tb.Text);
                command.Parameters.AddWithValue("@Kunde_tlf_tb", Kunde_tlf_tb.Text);
                command.Parameters.AddWithValue("@Kunde_email_tb", Kunde_email_tb.Text);
                command.Parameters.AddWithValue("@Kunde_id_tb", Kunde_id_tb.Text);
                command.Parameters.AddWithValue("@Er_sælger", Er_sælger.Checked);
                command.Parameters.AddWithValue("@Er_køber", Er_køber.Checked);

                // Her forsøger vi at køre vores commando på databasen.
                try
                {
                    BaseForm.dataConnection.Open();
                    command.ExecuteNonQuery();
                    BaseForm.dataConnection.Close();

                    // Hvis commandoen er udført sendes brugeren tilbage til kunde formen.
                    _baseForm.ÅbenNyForm(new KunderForm(_baseForm));

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
        /// Sletter en kunde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Slet_Kunde_Click(object sender, EventArgs e)
        {
            // Her tjekkets om værdierne i felterne opfylder vores krav inden vi sletter kunden.
            if (TjekSletMægler() == true)
            {

                // Her skriver vi den sql commando som skal køres for at slette en bolig
                string sqlcommandoString = $"DELETE FROM Kunde WHERE Kunde_id=@Kunde_id_tb";

                // Her opretter vi den forige comando som en sqlcommand som skal eksekveres på vores data connection.
                SqlCommand command = new SqlCommand(sqlcommandoString, BaseForm.dataConnection);

                // Her tilføjes vores værdier som parameretre. Dette forhindre at der opstår en uventet sql injection og virker derfor som et ekstra sikkerheds lag.
                command.Parameters.AddWithValue(@"Kunde_id_tb", Kunde_id_tb.Text);

                // Her forsøger vi at køre vores commando på databasen.
                try
                {
                    BaseForm.dataConnection.Open();
                    command.ExecuteNonQuery();
                    BaseForm.dataConnection.Close();

                    // Hvis commandoen er udført sendes brugeren tilbage til kunde formen.
                    _baseForm.ÅbenNyForm(new KunderForm(_baseForm));

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

        }

        /// <summary>
        /// Indlæser informationen omkring kunden
        /// </summary>
        /// <param name="id"></param>
        private void IndlæsInformation(int id)
        {
            // Her indlæses kunden fra databasen
            Kunde kunde = IndlæsFraDatabase.IndlæsKunde(id);

            // Her udfyldes informationen i felterne
            Kunde_navn_tb.Text = kunde.Navn;
            Kunde_tlf_tb.Text = kunde.Telefon.ToString();
            Kunde_email_tb.Text = kunde.Email;
            Er_sælger.Checked = kunde.Er_sælger;
            Er_køber.Checked = kunde.Er_køber;
        }

        /// <summary>
        /// Tjekker at værdierne er korrekte
        /// </summary>
        /// <returns>Success</returns>
        private bool TjekSletMægler()
        {
            int j = 0;
            if (!int.TryParse(Kunde_id_tb.Text, out j))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Tjekker at værdierne er korrekte
        /// </summary>
        /// <returns>Success</returns>
        private bool TjekKundeVærdier()
        {
            int i = 0;
            if (!int.TryParse(Kunde_tlf_tb.Text, out i))
            {
                return false;
            }

            string[] kundeEmail = Kunde_email_tb.Text.Split('@');
            if (kundeEmail.Length != 2)
            {
                return false;
            }

            if (!NavnRegex(Kunde_navn_tb.Text))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Ser om inputtet består af bogstaver
        /// </summary>
        /// <param name="input">En string der skal undersøges</param>
        /// <returns></returns>
        public bool NavnRegex(string input)
        {
            return Regex.IsMatch(input, ("^[a-zA-z æøåÆØÅ-]+$"));
        }
    }
}
