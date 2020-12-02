﻿using System;
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

namespace UCL_Projekt_1
{

    public partial class RedigerBoligerForm : Form
    {

        private BaseForm _baseForm;

        public RedigerBoligerForm(BaseForm form)
        {
            InitializeComponent();
            _baseForm = form;
            Ejendomsmægler[] mæglers = SQLRead.LoadEjendomsmægler();
            var options = new BindingList<KeyValuePair<string, string>>();
            foreach(var item in mæglers) {
                options.Add(new KeyValuePair<string, string>(item.Mægler_Id.ToString(), $"{item.Navn}, Id: {item.Mægler_Id}"));
            }
            Mæglere.DataSource = options;
            Mæglere.ValueMember = "Key";
            Mæglere.DisplayMember = "Value";
            Mæglere.SelectedIndex = 0;
            OpretForm();
        }

        public RedigerBoligerForm(BaseForm form, int id)
        {
            InitializeComponent();
            _baseForm = form;
            VisInformation(id.ToString());
            RedigerSletForm();
        }

        private void OpretForm()
        {
            Bolig_id_tb.Visible = false;
            Bolig_id.Visible = false;
            Rediger.Visible = false;
            Slet.Visible = false;
            Vis.Visible = false;
        }

        private void RedigerSletForm()
        {
            Adresse_tb.Enabled = false;
            Grund_areal_tb.Enabled = false;
            Bolig_areal_tb.Enabled = false;
            Bolig_type_tb.Enabled = false;
            Mæglere.Enabled = false;
            Bolig_id_tb.Enabled = false;
        }

        private void Opret_Click(object sender, EventArgs e)
        {
            if (TjekOpretBolig() == true)
            {
                //OPRET
                string Opret = $"INSERT INTO Bolig (Adresse, Grund_areal, Bolig_areal, Boligtype, Udbuds_pris, Solgt, Mægler_Id) VALUES (@Adresse_tb, @Grund_areal_tb, @Bolig_areal_tb, @Bolig_type_tb, @Udbudspris_tb, @solgt, @mæglerId)";
                SqlCommand command = new SqlCommand(Opret, BaseForm.conn);
                command.Parameters.AddWithValue("@Adresse_tb", Adresse_tb.Text);
                command.Parameters.AddWithValue("@Grund_areal_tb", Grund_areal_tb.Text);
                command.Parameters.AddWithValue("@Bolig_areal_tb", Bolig_areal_tb.Text);
                command.Parameters.AddWithValue("@Bolig_type_tb", Bolig_type_tb.Text);
                command.Parameters.AddWithValue("@Udbudspris_tb", Udbudspris_tb.Text);
                command.Parameters.AddWithValue("@solgt", solgt.Checked);
                command.Parameters.AddWithValue("@mæglerId", ((KeyValuePair<string, string>)Mæglere.SelectedItem).Key);

                try
                {
                    BaseForm.conn.Open();
                    command.ExecuteNonQuery();
                    BaseForm.conn.Close();
                    MessageBox.Show("Bolig oprettet" /*+Opret*/);

                }
                catch (Exception exc)
                {
                    MessageBox.Show("Der opstod en fejl, prøv igen " + Opret);
                }
            }
            else
            {
                MessageBox.Show("Der opstod en fejl, prøv igen");
            }
        }

        private void Vis_Click(object sender, EventArgs e)
        {
            VisInformation(Bolig_id_tb.Text);
        }

        private void VisInformation(string id)
        {
            if (TjekOpretBolig() == true)
            {
                //VIS
                Bolig b = SQLRead.VisBolig(id);
                if (b != null)
                {
                    Adresse_tb.Text = b.Addresse;
                    Grund_areal_tb.Text = b.Grund_areal.ToString();
                    Bolig_areal_tb.Text = b.Bolig_areal.ToString();
                    Bolig_type_tb.Text = b.Boligtype;
                    Udbudspris_tb.Text = b.Udbuds_pris.ToString();
                    solgt.Checked = b.Solgt;
                    Bolig_id_tb.Text = b.Bolig_Id.ToString();
                    Ejendomsmægler mægler = SQLRead.VisEjendomsmægler(b.Mægler_Id.ToString());
                    Mæglere.Items.Add($"Id: {mægler.Mægler_Id}, Navn: {mægler.Navn}");
                    Mæglere.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Der opstod en fejl, prøv igen");
                }
            }
            else
            {
                MessageBox.Show("Der opstod en fejl, prøv igen ");
            }
        }

        private void Rediger_Click(object sender, EventArgs e)
        {
            if (TjekRedigerSletBolig() == true)
            {
                //REDIGER
                string Rediger = $"UPDATE Bolig SET Udbuds_pris=@Udbudspris_tb, Solgt=@Status_tb WHERE Bolig_id = @Bolig_id_tb";
                SqlCommand command = new SqlCommand(Rediger, BaseForm.conn);
                command.Parameters.AddWithValue("@Bolig_id_tb", Bolig_id_tb.Text);
                command.Parameters.AddWithValue("@Udbudspris_tb", Udbudspris_tb.Text);
                command.Parameters.AddWithValue("@Status_tb", solgt.Checked);

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

        private void Slet_Click(object sender, EventArgs e)
        {
            if (TjekRedigerSletBolig() == true)
            {
                //SLET
                string Slet = $"DELETE FROM Bolig WHERE Bolig_id = @Bolig_id_tb";
                SqlCommand command = new SqlCommand(Slet, BaseForm.conn);
                command.Parameters.AddWithValue("@Bolig_id_tb", Bolig_id_tb.Text);
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

        private bool TjekRedigerSletBolig()
        {
            int i = 0;
            if (!int.TryParse(Bolig_id_tb.Text, out i))
            {
                return false;
            }
            return true;
        }

        private bool TjekOpretBolig()
        {
            int j = 0;
            if (!int.TryParse(Grund_areal_tb.Text, out j))
            {
                return false;
            }

            int k = 0;
            if (!int.TryParse(Bolig_areal_tb.Text, out k))
            {
                return false;
            }

            int l = 0;
            if (!int.TryParse(Udbudspris_tb.Text, out l))
            {
                return false;
            }

            string[] adresse = Adresse_tb.Text.Split(',');
            if (adresse.Length != 2)
            {
                return false;
            }
            return true;
        }
    }
}
