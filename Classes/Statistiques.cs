using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipeFrance.Classes
{
    abstract class Statistiques
    {
        /// <summary>
        /// Ceci est la classe abstraite Statistique
        /// Seulement un attribut commun entre joueur et gardien
        /// Temps joué: Soit un timespan du temps qu'ils ont passé sur le terrain.
        /// </summary>
        
        //Attributs privé
        private TimeSpan tempsjoue;

        //propriétés
        public TimeSpan Tempsjoue
        {
            get { return tempsjoue; }
            set { tempsjoue = value; }
        }


        //Constructeur pas défault
        public Statistiques()
        {
            tempsjoue = TimeSpan.Zero;
        }


        //Constructeur par paramètres
        public Statistiques(TimeSpan pTemps)
        {
            tempsjoue = pTemps;
        }
    }
}
