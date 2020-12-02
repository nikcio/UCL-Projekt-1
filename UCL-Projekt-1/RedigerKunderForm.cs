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
using System.Text.RegularExpressions;

namespace UCL_Projekt_1
{

    public partial class RedigerKunderForm : Form
    {

        private BaseForm _baseForm;

        public RedigerKunderForm(BaseForm form)
        {
            InitializeComponent();
            _baseForm = form;
        }

        public RedigerKunderForm(BaseForm form, int id)
        {
            InitializeComponent();
            _baseForm = form;
            VisInformation(id.ToString());
        }

        private void Opret_kunde_Click(object sender, EventArgs e)
        {
            if (tjekKundeVærdiger() == true)
            {
                string OpretK = $"INSERT INTO Kunde (Navn, Telefon, Email,Er_sælger, Er_køber) VALUES (@Kunde_navn_tb, @Kunde_tlf_tb, @Kunde_email_tb, @Er_sælger, @Er_køber)";
                SqlCommand command = new SqlCommand(OpretK, BaseForm.conn);
                command.Parameters.AddWithValue("@Kunde_navn_tb", Kunde_navn_tb.Text);
                command.Parameters.AddWithValue("@Kunde_tlf_tb", Kunde_tlf_tb.Text);
                command.Parameters.AddWithValue("@Kunde_email_tb", Kunde_email_tb.Text);
                command.Parameters.AddWithValue("@Er_sælger", Er_sælger.Checked);
                command.Parameters.AddWithValue("@Er_køber", Er_køber.Checked);

                try
                {
                    BaseForm.conn.Open();
                    command.ExecuteNonQuery();
                    BaseForm.conn.Close();
                    MessageBox.Show("Kunde oprettet" /*+OpretK*/);

                }
                catch (Exception exc)
                {
                    MessageBox.Show("Der opstod en fejl, prøv igen " + OpretK);
                }
            }
            else
            {
                MessageBox.Show("Der opstod en fejl, prøv igen ");
            }

        }

        private void Rediger_kunde_Click(object sender, EventArgs e)
        {
            if (tjekKundeVærdiger() == true)
            {
                string RedigerK = $"UPDATE Kunde SET Navn=@Kunde_navn_tb, Telefon=@Kunde_tlf_tb, Email=@Kunde_email_tb, Er_sælger=@Er_sælger, Er_køber=@Er_køber  WHERE Kunde_id=@Kunde_id_tb";
                SqlCommand command = new SqlCommand(RedigerK, BaseForm.conn);
                command.Parameters.AddWithValue("@Kunde_navn_tb", Kunde_navn_tb.Text);
                command.Parameters.AddWithValue("@Kunde_tlf_tb", Kunde_tlf_tb.Text);
                command.Parameters.AddWithValue("@Kunde_email_tb", Kunde_email_tb.Text);
                command.Parameters.AddWithValue("@Kunde_id_tb", Kunde_id_tb.Text);
                command.Parameters.AddWithValue("@Er_sælger", Er_sælger.Checked);
                command.Parameters.AddWithValue("@Er_køber", Er_køber.Checked);

                try
                {
                    BaseForm.conn.Open();
                    command.ExecuteNonQuery();
                    BaseForm.conn.Close();
                    MessageBox.Show("Bolig redigeret" /*Rediger*/);

                }
                catch (Exception exc)
                {
                    MessageBox.Show("Der opstod en fejl, prøv igen " + RedigerK);
                }
            }
            else
            {
                MessageBox.Show("Der opstod en fejl, prøv igen ");
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
            VisInformation(Kunde_id_tb.Text);

        }

        private void VisInformation(string id)
        {
            Models.Kunde k = SQLRead.VisKunder(id);
            Kunde_navn_tb.Text = k.Navn;
            Kunde_tlf_tb.Text = k.Telefon.ToString();
            Kunde_email_tb.Text = k.Email;
            Er_sælger.Checked = (bool)k.Er_sælger;
            Er_køber.Checked = (bool)k.Er_køber;
        }

        private bool tjekKundeVærdiger()
        {
            int i = 0;
            if (!int.TryParse(Kunde_tlf_tb.Text, out i))
            {
                return false;
            }
            int j = 0;
            if (!int.TryParse(Kunde_id_tb.Text, out j))
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

        public bool NavnRegex(string input)
        {
            return Regex.IsMatch(input, ("^[a-zA-z æøåÆØÅ]"));
        }
    }
}
