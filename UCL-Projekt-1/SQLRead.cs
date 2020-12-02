using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCL_Projekt_1.Models;
using UCL_Projekt_1;

namespace UCL_Projekt_1
{
    public class SQLRead
    {
        public static Bolig[] LoadBoliger()
        {
            List<Bolig> boliger = new List<Bolig>();

            SqlCommand command = new SqlCommand("SELECT * FROM Bolig", BaseForm.conn);
            FindBolig(boliger, command);

            return boliger.ToArray();
        }

        public static Bolig VisBolig(string Bolig_id_tb)
        {
            List<Bolig> boliger = new List<Bolig>();

            SqlCommand command = new SqlCommand("SELECT * FROM Bolig WHERE Bolig_id = @Bolig_id_tb", BaseForm.conn);
            command.Parameters.AddWithValue("@Bolig_id_tb", Bolig_id_tb);
            FindBolig(boliger, command);

            return boliger.FirstOrDefault();
        }

        public static void FindBolig(List<Bolig> boliger, SqlCommand command)
        {
            BaseForm.conn.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    boliger.Add(new Bolig(
                        reader.GetInt32(reader.GetOrdinal("Bolig_Id")),
                        reader.GetInt32(reader.GetOrdinal("Udbuds_pris")),
                        reader.GetString(reader.GetOrdinal("Boligtype")),
                        reader.GetInt32(reader.GetOrdinal("Bolig_areal")),
                        reader.GetInt32(reader.GetOrdinal("Grund_areal")),
                        reader.GetString(reader.GetOrdinal("Adresse")),
                        !reader.IsDBNull(reader.GetOrdinal("Kunde_Id")) ? reader.GetInt32(reader.GetOrdinal("Kunde_Id")) : -1,
                        !reader.IsDBNull(reader.GetOrdinal("Mægler_Id")) ? reader.GetInt32(reader.GetOrdinal("Mægler_Id")) : -1,
                        reader.GetBoolean(reader.GetOrdinal("Solgt"))));
                }
            }
            BaseForm.conn.Close();
        }


        public static Bolig[] LoadBoliger(string adresse)
        {
            List<Bolig> boliger = new List<Bolig>();

            SqlCommand command = new SqlCommand("SELECT * FROM Bolig WHERE Adresse LIKE @adresse", BaseForm.conn);
            command.Parameters.AddWithValue("@adresse", $"%{adresse}%");
            FindBolig(boliger, command);

            return boliger.ToArray();
        }

        public static Bolig[] LoadBoliger(bool solgt)
        {
            List<Bolig> boliger = new List<Bolig>();

            SqlCommand command = new SqlCommand("SELECT * FROM Bolig WHERE Solgt=@solgt", BaseForm.conn);
            command.Parameters.AddWithValue("@solgt", solgt);
            FindBolig(boliger, command);

            return boliger.ToArray();
        }

        public static Kunde[] LoadKunder()
        {
            List<Kunde> Kunder = new List<Kunde>();

            SqlCommand command = new SqlCommand("SELECT * FROM Kunde", BaseForm.conn);
            FindKunder(Kunder, command);

            return Kunder.ToArray();


        }

        public static Kunde VisKunder(string kunde_id)
        {
            List<Kunde> Kunder = new List<Kunde>();

            SqlCommand command = new SqlCommand("SELECT * FROM Kunde WHERE Kunde_id = @Kunde_id_tb", BaseForm.conn);
            command.Parameters.AddWithValue("@Kunde_id_tb", kunde_id);
            FindKunder(Kunder, command);

            return Kunder.FirstOrDefault();


        }

        public static void FindKunder(List<Kunde> Kunder, SqlCommand command)
        {
            BaseForm.conn.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
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
            BaseForm.conn.Close();
        }

        public static Ejendomsmægler[] LoadEjendomsmægler()
        {
            List<Ejendomsmægler> Ejendomsmæglere = new List<Ejendomsmægler>();

            SqlCommand command = new SqlCommand("SELECT * FROM Ejendomsmægler", BaseForm.conn);
            FindEjendomsmægler(Ejendomsmæglere, command);

            return Ejendomsmæglere.ToArray();
        }

        public static Ejendomsmægler VisEjendomsmægler(string id)
        {
            List<Ejendomsmægler> Ejendomsmæglere = new List<Ejendomsmægler>();

            SqlCommand command = new SqlCommand("SELECT * FROM Ejendomsmægler WHERE Mægler_Id=@id", BaseForm.conn);
            command.Parameters.AddWithValue("@id", id);
            FindEjendomsmægler(Ejendomsmæglere, command);

            return Ejendomsmæglere.FirstOrDefault();
        }

        public static void FindEjendomsmægler(List<Ejendomsmægler> Ejendomsmæglere, SqlCommand command)
        {
            BaseForm.conn.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Ejendomsmæglere.Add(new Ejendomsmægler(
                        reader.GetInt32(reader.GetOrdinal("Mægler_Id")),
                        reader.GetString(reader.GetOrdinal("Navn")),
                        reader.GetInt32(reader.GetOrdinal("Telefon")),
                        reader.GetString(reader.GetOrdinal("Email"))
                        ));
                }
            }
            BaseForm.conn.Close();
        }

        public static Salg[] LoadSalg()
        {
            List<Salg> Salgs = new List<Salg>();

            SqlCommand command = new SqlCommand("SELECT * FROM Salg", BaseForm.conn);
            FindSalg(Salgs, command);

            return Salgs.ToArray();
        }
        public static void FindSalg(List<Salg> Salgs, SqlCommand command)
        {
            BaseForm.conn.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Salgs.Add(new Salg(
                        reader.GetInt32(reader.GetOrdinal("Salgs_Id")),
                        reader.GetDateTime(reader.GetOrdinal("Dato")),
                        reader.GetInt32(reader.GetOrdinal("Pris")),
                        reader.GetInt32(reader.GetOrdinal("Mægler_Id")),
                        reader.GetInt32(reader.GetOrdinal("Bolig_Id"))
                        ));
                }
            }
            BaseForm.conn.Close();
        }
    }
}
