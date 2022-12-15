using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using EquipeFrance.Classes;

namespace EquipeFrance.Forms
{
    public partial class FormModifierStat_Joueur : Form
    {
        public FormModifierStat_Joueur()
        {
            InitializeComponent();
        }

        private void Numéro_Click(object sender, EventArgs e)
        {

        }

        //Remettre les labels à ""
        public void InitialiserLabel()
        {
            label6.Text = label7.Text = label8.Text = label9.Text = label10.Text = label11.Text = "";
        }


        //Vérifier si les valeurs entrés sont acceptables sinon afficher un message d'erreur
        public bool VerifierRegex(string modele, TextBox tb, Label lb, string messageErreur) //Code tirer du corrigé electeur
        {
            //Créer du Regex reg
            Regex Reg = new Regex(modele);
            //Vérifier la correspondance entre le champ entré dans le textbox et le modèle
            if (!Reg.IsMatch(tb.Text))
            {
                //Afficher le message d'erreur
                lb.ForeColor = Color.Red;
                lb.Text = messageErreur;
                //Effacer la Textbox
                tb.Clear();
                return false;
            }
            else lb.Text = ""; //Effacer le label si le cchamp entré est valide
            return true;
        }


        public bool VerifierTous()
        {
            //Déclaration des booléens de validation des informations entrées
            bool b_numero, b_buts, b_assists, b_temps, b_jaunes, b_rouges;
            //Appel de la méthode VerifierRegex pour tous les champs et récupération des valeurs retournées dans les variables booléenes
            b_numero = VerifierRegex("^[0-9]{1,2}$", txtNum, label6, "Un ou deux chiffres");
            b_buts = VerifierRegex("^[0-9]{1,2}$", txtButs, label7, "Un ou deux chiffres");
            b_assists = VerifierRegex("^[0-9]{1,2}$", txtAssists, label8, "Un ou deux chiffres");
            b_temps = VerifierRegex("^([0-9]{2}):([0-9]{2}):([0-9]{2})$", txtTemps, label9, "Le format de l'heure est hh:mm:ss");
            b_jaunes = VerifierRegex("^[0-9]{1,2}$", txtJaunes, label10, "Un ou deux chiffres");
            b_rouges = VerifierRegex("^[0-9]{1,2}$", txtRouges, label11, "Un ou deux chiffres");
            //Si toutes les vérifications  sont valides retourner vrai
            if (b_numero && b_buts && b_assists && b_temps && b_jaunes && b_rouges)
                return true;
            else return false; //sinon retourner faux
        }

        //Remettre tous les champs à défault
        public void InitialiserControles()
        {
            //Réinitialiser tous les champs du formulaire
            txtNum.Text = "";
            txtButs.Text = "";
            txtAssists.Text = "";
            txtTemps.Text = "";
            txtJaunes.Text = "";
            txtRouges.Text = "";
        }


        /// <summary>
        /// Événement clicked pour le bouton modifier Stat_Joueurs. Modifie les statistiques du joueurs s'il existe dans la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if(VerifierTous()) //Si tous les champs sont valides
            {
                //Instancier un Stat_Joueur avec les champs entrés pas l'utilisateur
                Stat_Joueur stat = new Stat_Joueur(int.Parse(txtButs.Text), int.Parse(txtAssists.Text), int.Parse(txtNum.Text),
                    TimeSpan.Parse(txtTemps.Text), int.Parse(txtJaunes.Text), int.Parse(txtRouges.Text));

                //L'ajouter à la base de données
                Stat_Joueur.ModifierStat_Joueur(stat);
                InitialiserControles();
            }
        }
    }
}
