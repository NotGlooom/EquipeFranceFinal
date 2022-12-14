using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using EquipeFrance.Classes;

namespace EquipeFrance.Forms
{
    public partial class FormAjouterMatch : Form
    {
        public FormAjouterMatch()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        //Remettre les labels à "" ou rien
        public void InitialiserLabel()
        {
            label4.Text = label5.Text = label6.Text = label7.Text = "";
        }

        //Verifier si les valeurs entrés sont acceptables sinon afficher un message d'erreur
        public bool VerifierRegex(string modele, TextBox tb, Label lb, string messageErreur)  //Code tirer du corrigé electeur
        {
            //Créer du Regex reg
            Regex reg = new Regex(modele);
            //Vérifier la correspondance entre le champ entré dans la textbox et le modèle
            if (!reg.IsMatch(tb.Text))
            {
                //Afficher le message d'erreur
                lb.ForeColor = Color.Red;
                lb.Text = messageErreur;
                //Effacer la TextBox
                tb.Clear();
                return false;
            }
            else lb.Text = ""; //Effacer le label si le champ entré est valide
            return true;

        }


        /// <summary>
        /// Vérifie que la date entrée est supérieur ou égal à celle d'aujoud'hui
        /// </summary>
        /// <param name="dtP"></param>
        /// <param name="lb"></param>
        /// <returns></returns>
        public bool VerifierDate(DateTimePicker dtP, Label lb)
        {
            //Assurer que la date entré est supérieur à aujourd'hui
            if (dtP.Value >= DateTime.Today) { lb.Text = ""; return true; }
            else
            {
                lb.ForeColor = Color.Red; lb.Text = "Date doit être supérieur ou égal à aujourd'hui";
                dtpJourMatch.Value = DateTime.Today;
                return false;
            }
        }


        //Vérifie le combobox Stade
        public bool VerifierCombobox(ComboBox cb, Label lb)
        {
            //Si l'utilisateur a choisi une valeur dans la liste
            if (cb.Text != "") { lb.Text = ""; return true; }
            else //Sinon afficher un message d'erreur
            {
                lb.ForeColor = Color.Red; lb.Text = "Entrez un stade"; return false;
            }
        }



        public bool VerifierTous()
        {
            //Déclaration des booléens de validation des informations entrées
            bool b_numero, b_adversaire, b_jour, b_stade;
            //Appel de la méthode VerifierRegex pour tous les champs et récupération des valeurs retournées dans les variables bouléennes
            b_numero = VerifierRegex("^[0-9]{4}$", txtNum, label4, "Quatre chiffres");
            b_adversaire = VerifierRegex("^[A-Z]{1}[a-z]{1,20}$", txtAdversaire, label5, "Lettre majuscule suivie de 1 à 20 lettres minuscules");
            //Appel de la méthode pour vérifier la date
            b_jour = VerifierDate(dtpJourMatch, label6);
            //Vérifier le combobox (stade)
            b_stade = VerifierCombobox(cbStade, label7);
            //Si toutes les vérifications sont valides retourner vrai
            if (b_numero && b_adversaire && b_jour && b_stade)
                return true;
            else return false; // sinon retourner faux
        }

        //Remettre tous les champs à défault
        public void InitialiserControles()
        {
            //Réinitialiser tous les champs du formulaire
            txtNum.Text = "";
            txtAdversaire.Text = "";
            dtpJourMatch.Value = DateTime.Today;
            cbStade.SelectedIndex = -1;
        }
            




        /// <summary>
        /// Événement clicked pour le bouton ajouter match. Ajoute le match à la base de données s'il n'existe pas déjà.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if(VerifierTous()) // Si tous les champs sont valides
            {
                //Instancier un match avec les champs entrés par l'utilisateur
                Classes.Match mat = new Classes.Match(int.Parse(txtNum.Text), txtAdversaire.Text, dtpJourMatch.Value.Date, cbStade.Text);

                //Ajouter le match à la base de données
                Horaire.AjouterMatch(mat);
                InitialiserControles();
            }
        }

        
    }
}
