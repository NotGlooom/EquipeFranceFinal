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
        /// 4 atrributs: numero (du joueur), tempsjoue (sur le terrain), cartonjaune et cartonrouge reçu.
        /// Temps joué: Soit un timespan du temps qu'ils ont passé sur le terrain.
        /// </summary>

        //Attributs privé
        private int numero;
        private TimeSpan tempsjoue;
        private int cartonjaune;
        private int cartonrouge;

        //propriétés
        
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }


        public TimeSpan Tempsjoue
        {
            get { return tempsjoue; }
            set { tempsjoue = value; }
        }


        public int Cartonjaune
        {
            get { return cartonjaune; }
            set { cartonjaune = value; }
        }

        public int Cartonrouge
        {
            get { return cartonrouge; }
            set { cartonrouge = value; }
        }

        //Constructeur pas défault
        public Statistiques()
        {
            numero = 0;
            tempsjoue = TimeSpan.Zero;
            cartonjaune = 0;
            cartonrouge = 0;
        }


        //Constructeur par paramètres
        public Statistiques(int pNumero, TimeSpan pTemps, int pJaune, int pRouge)
        {
            Numero = pNumero;
            tempsjoue = pTemps;
            cartonjaune = pJaune;
            cartonrouge = pRouge;
        }
    }
}
