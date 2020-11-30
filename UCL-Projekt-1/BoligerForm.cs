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
    public partial class BoligerForm : Form {

        public BoligerForm() {
            InitializeComponent();
        }

        private void Opret_Click(object sender, EventArgs e)
        {
            //OPRET
            string Opret = $"INSERT INTO Bolig (Adresse, Grund_areal, Bolig_areal, Boligtype, Udbuds_pris, Solgt) VALUES (@Adresse_tb, @Grund_areal_tb, @Bolig_areal_tb, @Bolig_type_tb, @Udbudspris_tb, @Status_tb)";
            SqlCommand command = new SqlCommand(Opret, BaseForm.conn);
            command.Parameters.AddWithValue("@Adresse_tb", Adresse_tb.Text);
            command.Parameters.AddWithValue("@Grund_areal_tb", Grund_areal_tb.Text);
            command.Parameters.AddWithValue("@Bolig_areal_tb", Bolig_areal_tb.Text);
            command.Parameters.AddWithValue("@Bolig_type_tb", Bolig_type_tb.Text);
            command.Parameters.AddWithValue("@Udbudspris_tb", Udbudspris_tb.Text);
            command.Parameters.AddWithValue("@Status_tb", Status_tb.Text);
            BaseForm.conn.Open();
            command.ExecuteNonQuery();
            BaseForm.conn.Close();
        }

        private void Vis_Click(object sender, EventArgs e)
        {
            //VIS
            Bolig b = SQLRead.VisBolig(Bolig_id_tb.Text);
            Adresse_tb.Text = b.Addresse;
            Grund_areal_tb.Text = b.Grund_areal.ToString();
            Bolig_areal_tb.Text = b.Bolig_areal.ToString();
            Bolig_type_tb.Text = b.Boligtype;
            Udbudspris_tb.Text = b.Udbuds_pris.ToString();
            Status_tb.Text = b.Solgt.ToString();
        }

        private void Rediger_Click(object sender, EventArgs e)
        {
            //REDIGER
            string Rediger = $"UPDATE Bolig SET Udbuds_pris=@Udbudspris_tb, Solgt=@Status_tb WHERE Bolig_id = @Bolig_id_tb";
            SqlCommand command = new SqlCommand(Rediger, BaseForm.conn);
            command.Parameters.AddWithValue("@Bolig_id_tb", Bolig_id_tb.Text);
            command.Parameters.AddWithValue("@Udbudspris_tb", Udbudspris_tb.Text);
            command.Parameters.AddWithValue("@Status_tb", Status_tb.Text);
            BaseForm.conn.Open();
            command.ExecuteNonQuery();
            BaseForm.conn.Close();
        }

        private void Slet_Click(object sender, EventArgs e)
        {
            //SLET
            string Slet = $"DELETE FROM Bolig WHERE Bolig_id = @Bolig_id_tb";
            SqlCommand command= new SqlCommand(Slet, BaseForm.conn);
            command.Parameters.AddWithValue("@Bolig_id_tb", Bolig_id_tb.Text);
            BaseForm.conn.Open();
            command.ExecuteNonQuery();
            BaseForm.conn.Close();
        }
    }
}
