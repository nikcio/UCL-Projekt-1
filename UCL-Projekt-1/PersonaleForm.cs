using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UCL_Projekt_1 {
    public partial class PersonaleForm : Form {
        public PersonaleForm() {
            InitializeComponent();
        }

        private void Opret_mægler_Click(object sender, EventArgs e)
        {
            //OPRET
            string Opret = $"INSERT INTO Ejendomsmægler (Navn, Telefon, Email) VALUES (@Mægler_navn_tb, @Mægler_Telefon_tb, @Mægler_Email_tb)";
            SqlCommand command = new SqlCommand(Opret, BaseForm.conn);
            command.Parameters.AddWithValue("@Mægler_navn_tb", Mægler_navn_tb.Text);
            command.Parameters.AddWithValue("@Mægler_telefon_tb", Mægler_telefon_tb.Text);
            command.Parameters.AddWithValue("@Mægler_email_tb", Mægler_email_tb.Text);
            BaseForm.conn.Open();
            command.ExecuteNonQuery();
            BaseForm.conn.Close();
        }
    }
}
