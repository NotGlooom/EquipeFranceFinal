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

namespace EquipeFrance.Forms
{
    public partial class FormListStats : Form
    {
        public FormListStats()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Événement clicked du bouton afficherpour afficher la liste des statistiques des joueurs dans la listeview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAfficher_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            // Connection to the database
            string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=\"Équipe France\";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Select Player stats
                string sql = "SELECT * FROM Stat_Joueurs";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Create the first column
                            ListViewItem item = new ListViewItem(reader["Numero"].ToString());

                            // Add the rest of the columns
                            item.SubItems.Add(reader["Tempsjoue"].ToString());
                            item.SubItems.Add(reader["CartonJaunes"].ToString());
                            item.SubItems.Add(reader["CartonRouges"].ToString());
                            item.SubItems.Add(reader["Buts"].ToString());
                            item.SubItems.Add(reader["Assists"].ToString());
                            item.SubItems.Add("N/A"); // Goalie stats not applicable for players
                            item.SubItems.Add("N/A"); // Goalie stats not applicable for players

                            // Add the item to the list view
                            listView1.Items.Add(item);
                        }
                    }
                }

                // Select Goalie stats
                sql = "SELECT * FROM Stat_Gardiens";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Create the first column
                            ListViewItem item = new ListViewItem(reader["Numero"].ToString());

                            // Add the rest of the columns
                            item.SubItems.Add(reader["Tempsjoue"].ToString());
                            item.SubItems.Add(reader["CartonJaunes"].ToString());
                            item.SubItems.Add(reader["CartonRouges"].ToString());
                            item.SubItems.Add("N/A"); // Player stats not applicable for goalies
                            item.SubItems.Add("N/A"); // Player stats not applicable for goalies
                            item.SubItems.Add(reader["ButsLaisse"].ToString());
                            item.SubItems.Add(reader["ButsArrete"].ToString());

                            // Add the item to the list view
                            listView1.Items.Add(item);
                        }
                    }
                }

                conn.Close();
            }
        }
    }
}
