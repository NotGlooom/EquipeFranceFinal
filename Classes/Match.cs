using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipeFrance.Classes
{
    public class Match
    {

        /// <summary>
        /// Ceci est la classe Match qui comporte tout les attributs et détails nécessaire pour un match de soccer
        /// Le numéro du match: Unique pour chaqu'un
        /// L'adversaire: Un autre pays dans le world cup 2022, exemple: Brézil, Argentine, 
        /// Le jour du match
        /// Le stade: Soit: Al Bayt, Khalifa International, Al Thumama, Ahmad Bin Ali, Lusail, Stadium 974, Education City ou Al Janoub
        /// </summary>

        //Déclaration des champs privés
        private int num_match;
        private string adversaire;
        private DateTime jour;
        private string stade;

        //Déclaration des propriétés

        public int Num_Match
        {
            get { return num_match; }
            set { num_match = value; }
        }

        public string Adversaire
        {
            get { return adversaire; }
            set { adversaire = value; }
        }

        public DateTime Jour
        {
            get { return jour; }
            set { jour = value; }
        }

        public string Stade
        {
            get { return stade; }
            set { stade = value; }
        }


        //Constructeur par défault
        public Match()
        {
            num_match = 0;
            adversaire = "";
            jour = default(DateTime);
            stade = "";
        }

        //Constructeur par paramètres
        public Match(int pNum, string pAdversaire, DateTime pJour, string pStade)
        {
            num_match = pNum;
            adversaire = pAdversaire;
            jour = pJour;
            stade = pStade;
        }
    }
}
