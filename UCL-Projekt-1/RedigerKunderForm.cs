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

    public partial class RedigerKunderForm : Form {

        private BaseForm _baseForm;

        public RedigerKunderForm(BaseForm form) {
            InitializeComponent();
            _baseForm = form;
        }

        private void Opret_kunde_Click(object sender, EventArgs e)
        {
            string OpretK = $"INSERT INTO Kunde (Navn, Telefon, Email) VALUES (@Kunde_navn_tb, @Kunde_tlf_tb, @Kunde_email_tb)";
            SqlCommand command = new SqlCommand(OpretK, BaseForm.conn);
            command.Parameters.AddWithValue("@Kunde_navn_tb", Kunde_navn_tb.Text);
            command.Parameters.AddWithValue("@Kunde_tlf_tb", Kunde_tlf_tb.Text);
            command.Parameters.AddWithValue("@Kunde_email_tb", Kunde_email_tb.Text);

            try
            {
                BaseForm.conn.Open();
                command.ExecuteNonQuery();
                BaseForm.conn.Close();
                MessageBox.Show("Kunde oprettet" /*+OpretK*/);
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("Der opstod en fejl, prøv igen "+ OpretK);
            }
        }

        private void Rediger_kunde_Click(object sender, EventArgs e)
        {
            string RedigerK = $"UPDATE Kunde SET Navn=@Kunde_navn_tb, Telefon=@Kunde_tlf_tb, Email=@Kunde_email_tb WHERE Kunde_id=@Kunde_id_tb";
            SqlCommand command = new SqlCommand(RedigerK, BaseForm.conn);
            command.Parameters.AddWithValue("@Kunde_navn_tb", Kunde_navn_tb.Text);
            command.Parameters.AddWithValue("@Kunde_tlf_tb", Kunde_tlf_tb.Text);
            command.Parameters.AddWithValue("@Kunde_email_tb", Kunde_email_tb.Text);
            command.Parameters.AddWithValue("@Kunde_id_tb", Kunde_id_tb.Text);
            
            try
            {
                BaseForm.conn.Open();
                command.ExecuteNonQuery();
                BaseForm.conn.Close();
                MessageBox.Show("Kunde redigeret" /*+ RedigerK*/);

            }
            catch (Exception exc)
            {
                MessageBox.Show("Der opstod en fejl, prøv igen " + RedigerK);
            }
        }

        private void Slet_Kunde_Click(object sender, EventArgs e)
        {
            string SletK = $"DELETE FROM Kunde WHERE Kunde_id=@Kunde_id_tb";
            SqlCommand command = new SqlCommand(SletK, BaseForm.conn);
            command.Parameters.AddWithValue(@"Kunde_id_tb", Kunde_id_tb.Text);
        
                try
                {
                BaseForm.conn.Open();
                command.ExecuteNonQuery();
                BaseForm.conn.Close();
                MessageBox.Show("Kunde slettet" /*+ SletK*/);

                }
            catch (Exception exc)
                {
                MessageBox.Show("Der opstod en fejl, prøv igen " + SletK);
                }    
        }

        private void Find_kunde_Click(object sender, EventArgs e)
        {

        }

        private void Se_alle_kunder_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Sælger_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Kunde_email_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kunde_tlf_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kunde_navn_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kunde_id_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Køber_Click(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void Telefon_Click(object sender, EventArgs e)
        {

        }

        private void Navn_Click(object sender, EventArgs e)
        {

        }

        private void Kunde_id_Click(object sender, EventArgs e)
        {
            Models.Kunde k = SQLRead.VisKunder(Kunde_id_tb.Text);
            Kunde_navn_tb.Text = k.Navn;
            Kunde_tlf_tb.Text = k.Telefon.ToString();
            Kunde_email_tb.Text = k.Email;
        }
    }
}
