﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipeFrance.Classes
{
    public static class Equipe
    {

        //Méthodes

        public static void AjouterJoueur(Joueur joue)
        {
            //Connection à la base de donnés
            string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=\"Équipe France\";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                //Vérifier si le joueur exiist déja avec le numéro du joueur
                string sql = $"SELECT Numero FROM Joueurs WHERE Numero = {joue.Num_joueur}";
                
                SqlCommand cmd = new SqlCommand(sql, conn);


                // Exécuter la command et mettre le résultat dans une variable
                object resultat = cmd.ExecuteScalar();

                // Si le résultat n'est pas null, le joueur exist déjà
                if (resultat != null)
                {
                    MessageBox.Show("Joueur existant déjà", "Message");
                    conn.Close();
                }

                else
                {
                    //Créer la commande sql pour insérer l'objet joueur dans la table
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = conn;
                    cmd1.CommandText = "INSERT INTO Joueurs VALUES (@Num_joueur, @Nom, @Prenom, @Taille, @Masse, @Position)";

                    cmd1.Parameters.AddWithValue("@Num_joueur", joue.Num_joueur);
                    cmd1.Parameters.AddWithValue("@Nom", joue.Nom);
                    cmd1.Parameters.AddWithValue("@Prenom", joue.Prenom);
                    cmd1.Parameters.AddWithValue("@Taille", joue.Taille);
                    cmd1.Parameters.AddWithValue("@Masse", joue.Masse);
                    cmd1.Parameters.AddWithValue("@Position", joue.Position);

                    //Ecécuter la commande
                    cmd1.ExecuteNonQuery();

                    conn.Close();
                        
                }
            }
        }








    }
}
