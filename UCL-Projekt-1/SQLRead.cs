using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCL_Projekt_1.Models;
using UCL_Projekt_1;

namespace UCL_Projekt_1 {
    public class SQLRead {
        public static Bolig[] LoadBoliger() {
            List<Bolig> boliger = new List<Bolig>();

            SqlCommand command = new SqlCommand("SELECT * FROM Bolig", BaseForm.conn);
            FindBolig(boliger, command);

            return boliger.ToArray();
        }

        public static void FindBolig(List<Bolig> boliger, SqlCommand command) {
            BaseForm.conn.Open();
            using (SqlDataReader reader = command.ExecuteReader()) {
                while (reader.Read()) {
                    boliger.Add(new Bolig(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetString(2),
                        reader.GetInt32(3),
                        reader.GetInt32(4),
                        reader.GetString(5),
                        !reader.IsDBNull(6) ? reader.GetInt32(6) : -1,
                        !reader.IsDBNull(7) ? reader.GetInt32(7) : -1,
                        reader.GetBoolean(8)));
                }
            }
            BaseForm.conn.Close();
        }

        public static Bolig[] LoadBoliger(string adresse) {
            List<Bolig> boliger = new List<Bolig>();

            SqlCommand command = new SqlCommand("SELECT * FROM Bolig WHERE Adresse LIKE @adresse", BaseForm.conn);
            command.Parameters.AddWithValue("@adresse", $"%{adresse}%");
            FindBolig(boliger, command);

            return boliger.ToArray();
        }

        public static Bolig[] LoadBoliger(bool solgt) {
            List<Bolig> boliger = new List<Bolig>();

            SqlCommand command = new SqlCommand("SELECT * FROM Bolig WHERE Solgt=@solgt", BaseForm.conn);
            command.Parameters.AddWithValue("@solgt", solgt);
            FindBolig(boliger, command);

            return boliger.ToArray();
        }
    }
}
