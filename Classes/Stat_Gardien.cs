using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
