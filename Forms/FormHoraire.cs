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
    public partial class FormHoraire : Form
    {
        public FormHoraire()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Méthode qui compte le nombre de matchs dansla table horaire
        /// </summary>
        public void CompterMatch()
        {
            textBox1.Text = "";

            //Connection à la base de donnés
            string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=\"Équipe France\";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT COUNT (*) FROM Horaire";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    int count = (int)cmd.ExecuteScalar();
                    textBox1.Text = count.ToString();
                }
            }
        }



        /// <summary>
        /// Événement clicked du bouton afficher pour afficher la liste des matchs dans la listeview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAfficher_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            //Connection à la base de donnés
            string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=\"Équipe France\";Integrated Security=True";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT * FROM Horaire";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //Créer la première colonne
                            ListViewItem item = new ListViewItem(reader["Numero"].ToString());

                            //Ajouter les autres
                            item.SubItems.Add(reader["Adversaire"].ToString());
                            item.SubItems.Add(reader["Jour"].ToString());
                            item.SubItems.Add(reader["Stade"].ToString());
                            

                            //Ajouter les items
                            listView1.Items.Add(item);


                        }

                        conn.Close();
                        CompterMatch();
                    }
                }
            }
        }
    }
}
