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
using UCL_Projekt_1.Models;

namespace UCL_Projekt_1 {
    public partial class RedigerMæglerForm : Form {
        public RedigerMæglerForm() {
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

        private void Find_mægler_Click(object sender, EventArgs e)
        {
            //VIS
            Ejendomsmægler m = SQLRead.VisEjendomsmægler(Mægler_id_tb.Text);
            Mægler_navn_tb.Text = m.Navn.ToString();
            Mægler_telefon_tb.Text = m.Telefon.ToString();
            Mægler_email_tb.Text = m.Email.ToString();
        }

        private void Rediger_mægler_Click(object sender, EventArgs e)
        {
            //REDIGER
            string Rediger = $"UPDATE Ejendomsmægler SET Navn=@Mægler_navn_tb, Telefon=@Mægler_telefon_tb, Email=@Mægler_email_tb WHERE Mægler_id = @Mægler_id_tb";
            SqlCommand command = new SqlCommand(Rediger, BaseForm.conn);
            command.Parameters.AddWithValue("@Mægler_id_tb", Mægler_id_tb.Text);
            command.Parameters.AddWithValue("@Mægler_navn_tb", Mægler_navn_tb.Text);
            command.Parameters.AddWithValue("@Mægler_telefon_tb", Mægler_telefon_tb.Text);
            command.Parameters.AddWithValue("@Mægler_email_tb", Mægler_email_tb.Text);
            BaseForm.conn.Open();
            command.ExecuteNonQuery();
            BaseForm.conn.Close();

        }

        private void Slet_mægler_Click(object sender, EventArgs e)
        {
            //SLET
            string Slet = $"DELETE FROM Ejendomsmægler WHERE Mægler_id = @Mægler_id_tb";
            SqlCommand command = new SqlCommand(Slet, BaseForm.conn);
            command.Parameters.AddWithValue("@Mægler_id_tb", Mægler_id_tb.Text);
            BaseForm.conn.Open();
            command.ExecuteNonQuery();
            BaseForm.conn.Close();
        }
    }
}
