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
    public partial class FormModifierMatch : Form
    {
        public FormModifierMatch()
        {
            InitializeComponent();
        }

        //Remettre lels labels à ""
        public void InitialiserLabel()
        {
            label5.Text = label6.Text = label7.Text = label8.Text =  "";
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
                dtpJourMatch1.Value = DateTime.Today;
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
            b_numero = VerifierRegex("^[0-9]{4}$", txtNum1, label5, "Quatre chiffres");
            b_adversaire = VerifierRegex("^[A-Z]{1}[a-z]{1,20}$", txtAdversaire1, label6, "Lettre majuscule suivie de 1 à 20 lettres minuscules");
            //Appel de la méthode pour vérifier la date
            b_jour = VerifierDate(dtpJourMatch1, label7);
            //Vérifier le combobox (stade)
            b_stade = VerifierCombobox(cbStade1, label8);
            //Si toutes les vérifications sont valides retourner vrai
            if (b_numero && b_adversaire && b_jour && b_stade)
                return true;
            else return false; // sinon retourner faux
        }

        //Remettre tous les champs à défault
        public void InitialiserControles()
        {
            //Réinitialiser tous les champs du formulaire
            txtNum1.Text = "";
            txtAdversaire1.Text = "";
            dtpJourMatch1.Value = DateTime.Today;
            cbStade1.SelectedIndex = -1;
        }


        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (VerifierTous()) // Si tous les champs sont valides
            {
                //Instancier un match avec les champs entrés par l'utilisateur
                Classes.Match mat = new Classes.Match(int.Parse(txtNum1.Text), txtAdversaire1.Text, dtpJourMatch1.Value.Date, cbStade1.Text);

                //Ajouter le match à la base de données
                Horaire.ModifierMatch(mat);
                InitialiserControles();
            }
        }
    }
}
