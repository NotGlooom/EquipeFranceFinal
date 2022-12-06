using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipeFrance.Classes
{
    public class Joueur
    {
        /// <summary>
        /// Ceci est la classe joueur qui comporte tout les attributs et détails de base de chaque joueur
        /// Attributs: Le numéro sur leur chandail (un numéro unique pour chaque joueur, servira de primary key)
        /// Nom, prenom, taille, masse
        /// Position: Soit: attaquant, milieu, défenseur ou gardien
        /// </summary>
        
        //Déclaration des champs privés
        private int num_joueur;
        private string nom;
        private string prenom;
        private double taille;
        private double masse;
        private string position;


        //Déclaration des propriétés
        public int Num_joueur
        {
            get { return num_joueur; }
            set { num_joueur = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public double Taille
        {
            get { return taille; }
            set { taille = value; }
        }

        public double Masse
        {
            get { return masse; }
            set { masse = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        //Constructeur par défault
        public Joueur()
        {
            num_joueur = 0;
            nom = "";
            prenom = "";
            taille = 0.0;
            masse = 0.0;
            position = "";
        }

        //Constructeur par paramètres
        public Joueur(int nj, string n, string pr, double t, double m, string po)
        {
            num_joueur = nj;
            nom = n;
            prenom = pr;
            taille = t;
            masse = m;
            position = po;
        }

        //Méthode d'affichage
        public string Afficher()
        {
            return "Numero: " + num_joueur + "Nom: " + nom + "Prenom: " + prenom + "Taille: " + taille +
                "Masse: " + masse + "Position: " + position;
        }

    }
}
