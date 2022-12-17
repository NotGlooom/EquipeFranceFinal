using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipeFrance.Classes
{
    class Stat_Gardien : Statistiques
    {
        /// <summary>
        /// Classe Hérite de la classe Statistique
        /// Ceci est une classe pour les statistique propre aux gardien de buts.
        /// 2 attributs: Buts arrêtés et buts laissés (Donc, qu'il na pas pu arrêter d'aller dans son filet.)
        /// </summary>

        //Attributs privés
        private int butsarrete;
        private int butlaisse;

        //Constructeur de la classe Stat_Gardien
        public Stat_Gardien(int pButA, int pButsL, int pNumero, TimeSpan pTemps, int pJaune, int pRouge) 
            : base(pNumero, pTemps, pJaune, pRouge)
        {
            this.butsarrete = pButA;
            this.butlaisse = pButsL;
        }


        /// <summary>
        /// Méthode statique pour modifier les statistiques d'un gardien
        /// </summary>
        /// <param name="stat"></param>
        public static void ModiferStat_Gardien(Stat_Gardien stat)
        {
            //Connection à la base de donnés
            string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=\"Équipe France\";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                //Vérifier si le joueur exist avec le numéro du joueur
                string sql = $"SELECT Numero FROM Stat_Gardiens WHERE Numero = {stat.Numero}";

                SqlCommand cmd = new SqlCommand(sql, conn);


                // Exécuter la command et mettre le résultat dans une variable
                object resultat = cmd.ExecuteScalar();

                // Si le résultat n'est pas null, le joueur exist
                if (resultat != null)
                {
                    //Suprimme le joueur avec ce numéro
                    string sql2 = $"DELETE FROM Stat_Gardiens WHERE Numero = {stat.Numero}";

                    SqlCommand cmd1 = new SqlCommand(sql2, conn);
                    cmd1.ExecuteNonQuery();


                    //Maintenant ajouter le nouveau joueur (modifier) 
                    //Créer la commande sql pour insérer l'objet joueur dans la table
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = conn;
                    cmd2.CommandText = "INSERT INTO Stat_Gardiens VALUES (@Numero, @Tempsjoue, @CartonJaunes, @CartonRouges, @ButsLaisse, @ButsArrete)";

                    cmd2.Parameters.AddWithValue("@Numero", stat.Numero);
                    cmd2.Parameters.AddWithValue("@Tempsjoue", stat.Tempsjoue);
                    cmd2.Parameters.AddWithValue("@CartonJaunes", stat.Cartonjaune);
                    cmd2.Parameters.AddWithValue("@CartonRouges", stat.Cartonrouge);
                    cmd2.Parameters.AddWithValue("@ButsLaisse", stat.butlaisse);
                    cmd2.Parameters.AddWithValue("@ButsArrete", stat.butsarrete);

                    //Ecécuter la commande
                    cmd2.ExecuteNonQuery();

                    conn.Close();

                }
                else
                {
                    MessageBox.Show("Joueur n'existe pas", "Message");
                    conn.Close();
                }
            }
        }
    }
}
