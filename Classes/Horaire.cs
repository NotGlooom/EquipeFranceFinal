using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipeFrance.Classes
{
    public static class Horaire
    {


        /// <summary>
        /// Méthodes statiques Ajouter, Modifier et Suprimmer match
        /// </summary>
        //Méthodes

        public static void AjouterMatch(Match mat)
        {
            //Connection à la base de donnés
            string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=\"Équipe France\";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                //Vérifier si le match exist déja avec le numéro du joueur
                string sql = $"SELECT Numero FROM Horaire WHERE Numero = {mat.Num_Match}";

                SqlCommand cmd = new SqlCommand(sql, conn);


                // Exécuter la command et mettre le résultat dans une variable
                object resultat = cmd.ExecuteScalar();

                // Si le résultat n'est pas null, le joueur exist déjà
                if (resultat != null)
                {
                    MessageBox.Show("Match existant déjà", "Message");
                    conn.Close();
                }
                else
                {
                    //Créer la commande sql pour insérer l'objet match dans la table
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = conn;
                    cmd1.CommandText = "INSERT INTO HORAIRE VALUES (@Num_Match, @Adversaire, @Jour, @Stade)";

                    cmd1.Parameters.AddWithValue("@Num_Match", mat.Num_Match);
                    cmd1.Parameters.AddWithValue("@Adversaire", mat.Adversaire);
                    cmd1.Parameters.AddWithValue("@Jour", mat.Jour);
                    cmd1.Parameters.AddWithValue("@Stade", mat.Stade);

                    //Ecécuter la commande
                    cmd1.ExecuteNonQuery();

                    conn.Close();
                }
            }
   
        }
    }
}

