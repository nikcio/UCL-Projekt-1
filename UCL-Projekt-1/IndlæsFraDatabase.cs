using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using UCL_Projekt_1.Models;

namespace UCL_Projekt_1
{

    /// <summary>
    /// Dette er en samling af de metoder som bruges til at indlæse data fra databasen
    /// </summary>
    public class IndlæsFraDatabase
    {
        /// <summary>
        /// Indlæser alle boliger fra databasen
        /// </summary>
        /// <returns></returns>
        public static Bolig[] IndlæsBoliger()
        {
            // En liste til at opbevare boligerne i når de bliver hentet fra databasen
            List<Bolig> boliger = new List<Bolig>();

            // Sqlcommandoen som indlæser alle boligerne
            SqlCommand command = new SqlCommand("SELECT * FROM Bolig", BaseForm.dataConnection);

            // Her hentes boligerne fra databasen
            HentBoliger(boliger, command);

            // Her returneres resulatet som et array
            return boliger.ToArray();
        }

        /// <summary>
        /// Indlæser en enkel bolig baseret på bolig id
        /// </summary>
        /// <param name="Bolig_id">Bolig id'et på boligen der skal findes</param>
        /// <returns></returns>
        public static Bolig IndlæsBolig(int Bolig_id)
        {
            // En liste til at opbevare boligerne i når bliver hentet fra databasen
            List<Bolig> boliger = new List<Bolig>();

            // Sqlcommandoen som indlæser den ene bolig
            SqlCommand command = new SqlCommand("SELECT * FROM Bolig WHERE Bolig_id = @Bolig_id_tb", BaseForm.dataConnection);

            // Her tilføjes vores værdier som parameretre. Dette forhindre at der opstår en uventet sql injection og virker derfor som et ekstra sikkerhedslag.
            command.Parameters.AddWithValue("@Bolig_id_tb", Bolig_id);

            // Her hentes boligerne fra databasen
            HentBoliger(boliger, command);

            // Her returneres resulatet (retunere null, hvis der ingen blev fundet)
            return boliger.FirstOrDefault();
        }

        /// <summary>
        /// Henter boligerne fra databasen
        /// </summary>
        /// <param name="boliger">En liste til at opbevare boligerne i</param>
        /// <param name="command">Den commando som skal køres</param>
        public static void HentBoliger(List<Bolig> boliger, SqlCommand command)
        {
            // Her forsøger vi at køre vores commando på databasen.
            try
            {
                BaseForm.dataConnection.Open();

                // Her starter indlæsningen
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Hver bolig tilføjes med de værdier som kan findes i databasen.
                        // reader.GetOrdinal henter kolonne tallet for den string som er givet
                        // reader.GetInt32 og GetString henter enten en int eller string
                        // reader.IsDBNull tjekker om værdien er null
                        boliger.Add(new Bolig(
                            reader.GetInt32(reader.GetOrdinal("Bolig_Id")),
                            reader.GetInt32(reader.GetOrdinal("Udbuds_pris")),
                            reader.GetString(reader.GetOrdinal("Boligtype")),
                            reader.GetInt32(reader.GetOrdinal("Bolig_areal")),
                            reader.GetInt32(reader.GetOrdinal("Grund_areal")),
                            reader.GetString(reader.GetOrdinal("Adresse")),
                            !reader.IsDBNull(reader.GetOrdinal("Kunde_køber")) ? reader.GetInt32(reader.GetOrdinal("Kunde_køber")) : -1,
                            !reader.IsDBNull(reader.GetOrdinal("Kunde_sælger")) ? reader.GetInt32(reader.GetOrdinal("Kunde_sælger")) : -1,
                            !reader.IsDBNull(reader.GetOrdinal("Mægler_Id")) ? reader.GetInt32(reader.GetOrdinal("Mægler_Id")) : -1,
                            reader.GetBoolean(reader.GetOrdinal("Solgt"))));
                    }
                }
                BaseForm.dataConnection.Close();
            }
            catch (Exception exception)
            {

                // Her tjekker vi på om fejlen skyldes netværket og skriver dertil en passende besked til brugeren
                if (exception.GetType() == typeof(SqlException) && exception.Source == ".Net SqlClient Data Provider")
                {
                    MessageBox.Show("Der kunne ikke oprettes forbinelse til serveren. Tjek venligst din netværksforbindelse og prøv igen.");
                }
                else
                {
                    MessageBox.Show("Der opstod en fejl, prøv igen");
                }

            }
            finally
            {
                // Hvis vores connection ikke blev lukket sørger vi for at lukke den her.
                if (BaseForm.dataConnection.State == ConnectionState.Open)
                {
                    BaseForm.dataConnection.Close();
                }
            }

        }

        /// <summary>
        /// Indlæser alle kunder fra databasen
        /// </summary>
        /// <returns></returns>
        public static Kunde[] IndlæsKunder()
        {
            // En liste til at gemme vores resultat
            List<Kunde> Kunder = new List<Kunde>();

            // Den sqlcommando som bruges til at hente alle kunder
            SqlCommand command = new SqlCommand("SELECT * FROM Kunde", BaseForm.dataConnection);

            // Henter informationen fra databasen
            HentKunder(Kunder, command);

            // Returnere resultatet som et array
            return Kunder.ToArray();
        }

        /// <summary>
        /// Indlæser en enkel kunde baseret på kunde id
        /// </summary>
        /// <param name="kunde_id"></param>
        /// <returns></returns>
        public static Kunde IndlæsKunde(int kunde_id)
        {
            // En liste til at gemme vores resultat
            List<Kunde> Kunder = new List<Kunde>();

            // Den sqlcommando som bruges til at hente alle kunder
            SqlCommand command = new SqlCommand("SELECT * FROM Kunde WHERE Kunde_id = @Kunde_id_tb", BaseForm.dataConnection);

            // Her tilføjes vores værdier som parameretre. Dette forhindre at der opstår en uventet sql injection og virker derfor som et ekstra sikkerheds lag.
            command.Parameters.AddWithValue("@Kunde_id_tb", kunde_id);

            // Her hentes kunderne fra databasen
            HentKunder(Kunder, command);

            // Her returneres resulatet (retunere null, hvis der ingen blev fandt)
            return Kunder.FirstOrDefault();
        }

        public static void HentKunder(List<Kunde> Kunder, SqlCommand command)
        {
            // Her forsøger vi at køre vores commando på databasen.
            try
            {
                BaseForm.dataConnection.Open();

                // Her starter indlæsningen
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Hver kunde tilføjes med de værdier som kan findes i databasen.
                        // reader.GetOrdinal henter kolonne tallet for den string som er givet
                        // reader.GetInt32 og GetString henter enten en int eller string
                        // reader.IsDBNull tjekker om værdien er null
                        Kunder.Add(new Kunde(
                            reader.GetString(reader.GetOrdinal("Navn")),
                            reader.GetInt32(reader.GetOrdinal("Telefon")),
                            reader.GetString(reader.GetOrdinal("Email")),
                            reader.GetInt32(reader.GetOrdinal("Kunde_Id")),
                            !reader.IsDBNull(reader.GetOrdinal("Er_sælger")) ? reader.GetBoolean(reader.GetOrdinal("Er_sælger")) : false,
                            !reader.IsDBNull(reader.GetOrdinal("Er_køber")) ? reader.GetBoolean(reader.GetOrdinal("Er_Køber")) : false
                            ));
                    }
                }
                BaseForm.dataConnection.Close();
            }
            catch (Exception exception)
            {

                // Her tjekker vi på om fejlen skyldes netværket og skriver dertil en passende besked til brugeren
                if (exception.GetType() == typeof(SqlException) && exception.Source == ".Net SqlClient Data Provider")
                {
                    MessageBox.Show("Der kunne ikke oprettes forbinelse til serveren. Tjek venligst din netværksforbindelse og prøv igen.");
                }
                else
                {
                    MessageBox.Show("Der opstod en fejl, prøv igen");
                }

            }
            finally
            {
                // Hvis vores connection ikke blev lukket sørger vi for at lukke den her.
                if (BaseForm.dataConnection.State == ConnectionState.Open)
                {
                    BaseForm.dataConnection.Close();
                }
            }
        }

        /// <summary>
        /// Indlæser alle ejendomsmæglere fra databasen
        /// </summary>
        /// <returns></returns>
        public static Ejendomsmægler[] IndlæsEjendomsmæglere()
        {
            // En liste til resultatet
            List<Ejendomsmægler> Ejendomsmæglere = new List<Ejendomsmægler>();

            // Sqlcommandoen til at hente alle ejendomsmæglere
            SqlCommand command = new SqlCommand("SELECT * FROM Ejendomsmægler", BaseForm.dataConnection);

            // Her hentes ejendomsmægler indformationerne
            HentEjendomsmægler(Ejendomsmæglere, command);

            // Returnere resultatet
            return Ejendomsmæglere.ToArray();
        }

        /// <summary>
        /// Indlæser en enkel ejendomsmægler baseret på id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Ejendomsmægler IndlæsEjendomsmægler(int id)
        {
            // En liste til resulatet
            List<Ejendomsmægler> Ejendomsmæglere = new List<Ejendomsmægler>();

            // Sqlcommandoen til at hente ejendomsmægleren
            SqlCommand command = new SqlCommand("SELECT * FROM Ejendomsmægler WHERE Mægler_Id=@id", BaseForm.dataConnection);

            // Her tilføjes vores værdier som parameretre. Dette forhindre at der opstår en uventet sql injection og virker derfor som et ekstra sikkerhedslag.
            command.Parameters.AddWithValue("@id", id);

            // Her hentes ejendomsmæglers id
            HentEjendomsmægler(Ejendomsmæglere, command);

            // Returnere resultatet
            return Ejendomsmæglere.FirstOrDefault();
        }

        /// <summary>
        /// Henter informationen fra databasen
        /// </summary>
        /// <param name="Ejendomsmæglere"></param>
        /// <param name="command"></param>
        public static void HentEjendomsmægler(List<Ejendomsmægler> Ejendomsmæglere, SqlCommand command)
        {
            // Her forsøger vi at køre vores commando på databasen.
            try
            {
                BaseForm.dataConnection.Open();

                // Her starter indlæsningen
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Hver ejendomsmægler tilføjes med de værdier som kan findes i databasen.
                        // reader.GetOrdinal henter kolonne tallet for den string som er givet
                        // reader.GetInt32 og GetString henter enten en int eller string
                        Ejendomsmæglere.Add(new Ejendomsmægler(
                            reader.GetInt32(reader.GetOrdinal("Mægler_Id")),
                            reader.GetString(reader.GetOrdinal("Navn")),
                            reader.GetInt32(reader.GetOrdinal("Telefon")),
                            reader.GetString(reader.GetOrdinal("Email"))
                            ));
                    }
                }
                BaseForm.dataConnection.Close();
            }
            catch (Exception exception)
            {

                // Her tjekker vi på om fejdasdlen skyldes netværket og skriver dertil en passende besked til brugeren
                if (exception.GetType() == typeof(SqlException) && exception.Source == ".Net SqlClient Data Provider")
                {
                    MessageBox.Show("Der kunne ikke oprettes forbinelse til serveren. Tjek venligst din netværksforbindelse og prøv igen.");
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
        /// Indlæser alle salg fra data basen
        /// </summary>
        /// <returns></returns>
        public static Salg[] IndlæsAlleSalg()
        {
            // En liste til resultatet
            List<Salg> Salgs = new List<Salg>();

            // Sqlcommandoen til at hente alle salg
            SqlCommand command = new SqlCommand("SELECT * FROM Salg", BaseForm.dataConnection);

            // Henter informationen
            HentSalg(Salgs, command);

            // Returnere resultatet
            return Salgs.ToArray();
        }

        /// <summary>
        /// Henter informationen fra databasen
        /// </summary>
        /// <param name="Salgs"></param>
        /// <param name="command"></param>
        public static void HentSalg(List<Salg> Salgs, SqlCommand command)
        {
            // Her forsøger vi at køre vores commando på databasen.
            try
            {
                BaseForm.dataConnection.Open();

                // Her starter indlæsningen
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Hver salg tilføjes med de værdier som kan findes i databasen.
                        // reader.GetOrdinal henter kolonne tallet for den string som er givet
                        // reader.GetInt32, GetDateTime og GetString henter enten en int, DateTime eller string
                        Salgs.Add(new Salg(
                            reader.GetInt32(reader.GetOrdinal("Salgs_Id")),
                            reader.GetDateTime(reader.GetOrdinal("Dato")),
                            reader.GetInt32(reader.GetOrdinal("Pris")),
                            reader.GetInt32(reader.GetOrdinal("Mægler_Id")),
                            reader.GetInt32(reader.GetOrdinal("Bolig_Id"))
                            ));
                    }
                }
                BaseForm.dataConnection.Close();
            }
            catch (Exception exception)
            {

                // Her tjekker vi på om fejdasdlen skyldes netværket og skriver dertil en passende besked til brugeren
                if (exception.GetType() == typeof(SqlException) && exception.Source == ".Net SqlClient Data Provider")
                {
                    MessageBox.Show("Der kunne ikke oprettes forbinelse til serveren. Tjek venligst din netværksforbindelse og prøv igen.");
                }
                else
                {
                    MessageBox.Show("Der opstod en fejl, prøv igen");
                }

            }
            finally
            {
                // Hvis vores connection ikke blev lukket sørger vi for at lukke den her.
                if (BaseForm.dataConnection.State == ConnectionState.Open)
                {
                    BaseForm.dataConnection.Close();
                }
            }
        }
    }
}
