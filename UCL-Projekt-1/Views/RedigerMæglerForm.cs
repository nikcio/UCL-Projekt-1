using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UCL_Projekt_1.Models;

namespace UCL_Projekt_1
{

    /// <summary>
    /// Laver en form, hvor man kan oprette, redigere og slette ejendomsmæglere.
    /// </summary>
    public partial class RedigerMæglerForm : Form
    {
        /// <summary>
        /// En refrence til BaseForm.
        /// </summary>
        private readonly BaseForm _baseForm;

        /// <summary>
        /// Constructoren til at oprette en mægler
        /// </summary>
        /// <param name="form">En reference til BaseForm</param>
        public RedigerMæglerForm(BaseForm form)
        {
            InitializeComponent();

            // Her sættes refrencen til BaseForm.
            _baseForm = form;

            // Indstiller de controls som ikke skal bruges til oprettelsen af en mægler.
            OpretForm();
        }

        /// <summary>
        /// Constructoren til at redigere eller slette en mægler
        /// </summary>
        /// <param name="form">En reference til BaseForm</param>
        /// <param name="id">Den mægler der skal redigeres/slettes</param>
        public RedigerMæglerForm(BaseForm form, int id)
        {
            InitializeComponent();

            // Her sættes refrencen til BaseForm.
            _baseForm = form;

            // Her viser vi informationen omkring mægleren i felterne.
            IndlæsInformation(id);

            // Indstiller de controls som ikke skal bruges til redigering/sleting af en mægler.
            RedigerForm();
        }

        /// <summary>
        /// Indstiller de controls som ikke skal bruges til oprettelse af en mægler.
        /// </summary>
        private void OpretForm()
        {
            Rediger_mægler.Visible = false;
            Slet_mægler.Visible = false;
            Mægler_id_tb.Enabled = false;
        }

        /// <summary>
        /// Indstiller de controls som ikke skal bruges til redigering/sleting af en mægler.
        /// </summary>
        private void RedigerForm()
        {
            Opret_mægler.Visible = false;
            Mægler_id_tb.Enabled = false;
        }

        /// <summary>
        /// Opretter en mægler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Opret_mægler_Click(object sender, EventArgs e)
        {
            // Her tjekkets om værdierne i felterne opfylder vores krav inden vi opretter mægleren.
            if (TjekOpretMægler() == true)
            {
                // Her skriver vi den sql commando som skal køres for at danne en bolig
                string sqlcommandoString = $"INSERT INTO Ejendomsmægler (Navn, Telefon, Email) " +
                    $"VALUES (@Mægler_navn_tb, @Mægler_Telefon_tb, @Mægler_Email_tb)";

                // Her opretter vi den forige comando som en sqlcommand som skal eksekveres på vores data connection.
                SqlCommand command = new SqlCommand(sqlcommandoString, BaseForm.dataConnection);

                // Her tilføjes vores værdier som parameretre. Dette forhindre at der opstår en uventet sql injection og virker derfor som et ekstra sikkerheds lag.
                command.Parameters.AddWithValue("@Mægler_navn_tb", Mægler_navn_tb.Text);
                command.Parameters.AddWithValue("@Mægler_telefon_tb", Mægler_telefon_tb.Text);
                command.Parameters.AddWithValue("@Mægler_email_tb", Mægler_email_tb.Text);

                // Her forsøger vi at køre vores commando på databasen.
                try
                {
                    BaseForm.dataConnection.Open();
                    command.ExecuteNonQuery();
                    BaseForm.dataConnection.Close();

                    // Hvis commandoen er udført sendes brugeren tilbage til mægler formen.
                    _baseForm.ÅbenNyForm(new MæglerForm(_baseForm));

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
        /// Viser informationen omkring en mægler
        /// </summary>
        /// <param name="id"></param>
        private void IndlæsInformation(int id)
        {
            // Her indlæses ejendommægleren fra databasen
            Ejendomsmægler ejendomsmægler = IndlæsFraDatabase.IndlæsEjendomsmægler(id);

            // Her sættes værdierne i felterne
            Mægler_navn_tb.Text = ejendomsmægler.Navn.ToString();
            Mægler_telefon_tb.Text = ejendomsmægler.Telefon.ToString();
            Mægler_email_tb.Text = ejendomsmægler.Email.ToString();
            Mægler_id_tb.Text = id.ToString();
        }

        /// <summary>
        /// Rediger informationen omkring en mægler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rediger_mægler_Click(object sender, EventArgs e)
        {
            // Her tjekkets om værdierne i felterne opfylder vores krav inden vi redigere mægleren.
            if (TjekRedigerMægler() == true)
            {
                // Her skriver vi den sql commando som skal køres for at redigere en bolig
                string Rediger = $"UPDATE Ejendomsmægler SET Navn=@Mægler_navn_tb, Telefon=@Mægler_telefon_tb, Email=@Mægler_email_tb WHERE Mægler_id = @Mægler_id_tb";

                // Her opretter vi den forige comando som en sqlcommand som skal eksekveres på vores data connection.
                SqlCommand command = new SqlCommand(Rediger, BaseForm.dataConnection);

                // Her tilføjes vores værdier som parameretre. Dette forhindre at der opstår en uventet sql injection og virker derfor som et ekstra sikkerheds lag.
                command.Parameters.AddWithValue("@Mægler_id_tb", Mægler_id_tb.Text);
                command.Parameters.AddWithValue("@Mægler_navn_tb", Mægler_navn_tb.Text);
                command.Parameters.AddWithValue("@Mægler_telefon_tb", Mægler_telefon_tb.Text);
                command.Parameters.AddWithValue("@Mægler_email_tb", Mægler_email_tb.Text);

                // Her forsøger vi at køre vores commando på databasen.
                try
                {
                    BaseForm.dataConnection.Open();
                    command.ExecuteNonQuery();
                    BaseForm.dataConnection.Close();

                    // Hvis commandoen er udført sendes brugeren tilbage til mægler formen.
                    _baseForm.ÅbenNyForm(new MæglerForm(_baseForm));

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


        private void Slet_mægler_Click(object sender, EventArgs e)
        {
            // Her tjekkets om værdierne i felterne opfylder vores krav inden vi sletter mægleren.
            if (TjekSletMægler() == true)
            {
                // Her skriver vi den sql commando som skal køres for at slette en mægler
                string Slet = $"DELETE FROM Ejendomsmægler WHERE Mægler_id = @Mægler_id_tb";

                // Her opretter vi den forige comando som en sqlcommand som skal eksekveres på vores data connection.
                SqlCommand command = new SqlCommand(Slet, BaseForm.dataConnection);

                // Her tilføjes vores værdier som parameretre. Dette forhindre at der opstår en uventet sql injection og virker derfor som et ekstra sikkerheds lag.
                command.Parameters.AddWithValue("@Mægler_id_tb", Mægler_id_tb.Text);

                try
                {
                    BaseForm.dataConnection.Open();
                    command.ExecuteNonQuery();
                    BaseForm.dataConnection.Close();

                    // Hvis commandoen er udført sendes brugeren tilbage til mægler formen.
                    _baseForm.ÅbenNyForm(new MæglerForm(_baseForm));

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
        /// Tjekker om felterne brugt i sletning indholder korekte værider
        /// </summary>
        /// <returns>Success</returns>
        private bool TjekSletMægler()
        {
            int i = 0;
            if (!int.TryParse(Mægler_id_tb.Text, out i))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Tjekker om felterne brugt i redigering indholder korekte værider
        /// </summary>
        /// <returns>Success</returns>
        private bool TjekRedigerMægler()
        {
            int i = 0;
            if (!int.TryParse(Mægler_id_tb.Text, out i))
            {
                return false;
            }

            int j = 0;
            if (!int.TryParse(Mægler_telefon_tb.Text, out j))
            {
                return false;
            }

            string[] email = Mægler_email_tb.Text.Split('@');
            if (email.Length != 2)
            {
                return false;
            }

            if (!NavnRegex(Mægler_navn_tb.Text))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Tjekker om felterne brugt i opret indholder korekte værider
        /// </summary>
        /// <returns>Success</returns>
        private bool TjekOpretMægler()
        {
            int j = 0;
            if (!int.TryParse(Mægler_telefon_tb.Text, out j)) //Tjekker for at det kun er tal
            {
                return false;
            }

            string[] email = Mægler_email_tb.Text.Split('@'); //Tjekker for at der er et snabbel a
            if (email.Length != 2)
            {
                return false;
            }

            if (!NavnRegex(Mægler_navn_tb.Text))
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
