using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipeFrance.Classes
{
    class Stat_Joueur : Statistiques
    {
        /// <summary>
        /// Classe Hérite de la classe Statistique
        /// Ceci est une classe pour les statistique propre aux joueurs.
        /// 2 attributs: Buts (pour buts marqués par le joueur) et Assists (Quand il a fait une passe à quelqu'un qui a marqué un but)
        /// </summary>

        //Attribut privés 
        private int buts;
        private int assists;


        //Constructeur de la classe Stat_Joueur
        public Stat_Joueur(int pButs, int pAssists, TimeSpan pTemps) : base(pTemps)
        {
            this.buts = pButs;
            this.assists = pAssists;
        }
    }
}
