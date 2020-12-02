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
using System.Text.RegularExpressions;

namespace UCL_Projekt_1 {
    public partial class RedigerMæglerForm : Form {

        private BaseForm _baseForm;

        public RedigerMæglerForm(BaseForm form) {
            InitializeComponent();
            _baseForm = form;
        }

        public RedigerMæglerForm(BaseForm form, int id) {
            InitializeComponent();
            _baseForm = form;
            VisInformation(id.ToString());
        }

        private void Opret_mægler_Click(object sender, EventArgs e)
        {
            if (TjekMægler() == true)
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

                try
                {
                    BaseForm.conn.Open();
                    command.ExecuteNonQuery();
                    BaseForm.conn.Close();
                    MessageBox.Show("Bolig redigeret" /*Rediger*/);

                }
                catch (Exception exc)
                {
                    MessageBox.Show("Der opstod en fejl, prøv igen " + Opret);
                }
            }
            else
            {
                MessageBox.Show("Der opstod en fejl, prøv igen ");
            }
        
        }

        private void Find_mægler_Click(object sender, EventArgs e)
        {
            VisInformation(Mægler_id_tb.Text);
        }

        private void VisInformation(string id) {
            //VIS
            Ejendomsmægler m = SQLRead.VisEjendomsmægler(id);
            Mægler_navn_tb.Text = m.Navn.ToString();
            Mægler_telefon_tb.Text = m.Telefon.ToString();
            Mægler_email_tb.Text = m.Email.ToString();
            Mægler_id_tb.Text = id;
        }

        private void Rediger_mægler_Click(object sender, EventArgs e)
        {
            if (TjekMægler() == true)
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

                try
                {
                    BaseForm.conn.Open();
                    command.ExecuteNonQuery();
                    BaseForm.conn.Close();
                    MessageBox.Show("Bolig redigeret" /*Rediger*/);

                }
                catch (Exception exc)
                {
                    MessageBox.Show("Der opstod en fejl, prøv igen " + Rediger);
                }
            }
            else
            {
                MessageBox.Show("Der opstod en fejl, prøv igen ");
            }
        
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


        private bool TjekMægler()
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

        public bool NavnRegex(string input)
        {
            return Regex.IsMatch(input, "^[a-zA-Z æøåÆØÅ]+$");
        }
    }
}
