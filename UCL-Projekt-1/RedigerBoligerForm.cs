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
    public partial class RedigerBoligerForm : Form {
        
        private static readonly string ConnectionString = @"Data Source=den1.mssql8.gear.host;User ID=proevedatabase;Password=Ph0CSw_9V-FS;Database=proevedatabase;";
        private SqlConnection conn = new SqlConnection(ConnectionString);
        


        public RedigerBoligerForm() {
            InitializeComponent();
        }

        private void Opret_Click(object sender, EventArgs e)
        {
            //OPRET
            string Opret = $"INSERT INTO Bolig (Adresse, Grund_areal, Bolig_areal, Boligtype, Udbuds_pris, Solgt) VALUES (@Adresse_tb, @Grund_areal_tb, @Bolig_areal_tb, @Bolig_type_tb, @Udbudspris_tb, @Status_tb)";
            SqlCommand command = new SqlCommand(Opret, conn);
            command.Parameters.AddWithValue("@Adresse_tb", Adresse_tb.Text);
            command.Parameters.AddWithValue("@Grund_areal_tb", Grund_areal_tb.Text);
            command.Parameters.AddWithValue("@Bolig_areal_tb", Bolig_areal_tb.Text);
            command.Parameters.AddWithValue("@Bolig_type_tb", Bolig_type_tb.Text);
            command.Parameters.AddWithValue("@Udbudspris_tb", Udbudspris_tb.Text);
            command.Parameters.AddWithValue("@Status_tb", Status_tb.Text);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        private void Vis_Click(object sender, EventArgs e)
        {
            //VIS

        }

        private void Rediger_Click(object sender, EventArgs e)
        {
            //REDIGER
            string Rediger = $"UPDATE Bolig SET Udbuds_pris=@Udbudspris_tb, Solgt=@Status_tb WHERE Bolig_id = @Bolig_id_tb";
            SqlCommand command = new SqlCommand(Rediger, conn);
            command.Parameters.AddWithValue("@Bolig_id_tb", Bolig_id_tb.Text);
            command.Parameters.AddWithValue("@Udbudspris_tb", Udbudspris_tb.Text);
            command.Parameters.AddWithValue("@Status_tb", Status_tb.Text);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        private void Slet_Click(object sender, EventArgs e)
        {
            //SLET
            string Slet = $"DELETE FROM Bolig WHERE Bolig_id = @Bolig_id_tb";
            SqlCommand command= new SqlCommand(Slet, conn);
            command.Parameters.AddWithValue("@Bolig_id_tb", Bolig_id_tb.Text);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
