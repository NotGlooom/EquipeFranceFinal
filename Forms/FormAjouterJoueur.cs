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

namespace EquipeFrance.Classes
{
    public partial class FormAjouterJoueur : Form
    {
        public FormAjouterJoueur()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Remettre lels labels à ""
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

        /// <summary>
        /// Vérifier que la valeur entrée est entre 150cm(4,9 pieds) et 220(7,2 pieds)
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="lb"></param>
        /// <returns></returns>
        public bool VerifierTaille(TextBox tb, Label lb)
        {
            //Convertir le txtbox en int
            double taille = double.Parse(tb.Text);
            if (taille >= 150.00 && taille <= 220.00) { lb.Text = ""; return true; }
            else //Sinon afficher un message d'erreur
            {
                lb.ForeColor = Color.Red; lb.Text = "Taille doit être entre 150cm et 220cm";
                tb.Clear();
                return false;
            }
        }


        /// <summary>
        /// Vérifier que la valeur entrée est entre 130lbs(59 kg) et 220lbs(100kg)
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="lb"></param>
        /// <returns></returns>
        public bool VerifierMasse(TextBox tb, Label lb)
        {
            //Convertir le txtbox en int
            double masse = double.Parse(tb.Text);
            if (masse >= 130.00 && masse <= 220.00) { lb.Text = ""; return true;}
            else //Sinon afficher un message d'erreur
            {
                lb.ForeColor = Color.Red; lb.Text = "Masse doit être entre 130lbs et 220lbs";
                tb.Clear();
                return false;
            }
        }



        //Vérifier le combobox Position
        public bool VerifierCombobox(ComboBox cb, Label lb)
        {
            //Si l'utilisateur a choisi une valeur dans la liste
            if (cb.Text != "") { lb.Text = ""; return true; }
            else //Sinon afficher un message d'erreur
            {
                lb.ForeColor = Color.Red; lb.Text = "Entrez une position"; return false;
            }
        }

        public bool VerifierTous()
        {
            //Déclaratiion des booléens de validation des informations entrées
            bool b_numero, b_nom, b_prenom, b_taille, b_masse, b_combobox;
            //Appel de la méthode VerifierRegex pour tous les champs et récupération des valeurs retournées dans les variables booléenes
            b_numero = VerifierRegex("^[0-9]{1,2}$", txtNum, label6, "Un ou deux chiffres");
            b_nom = VerifierRegex("^[A-Z]{1}[a-z]{1,20}$", txtNom, label7, "Lettre majuscule suivie de 1 à 20 lettres minuscules");
            b_prenom = VerifierRegex("^[A-Z]{1}[a-z]{1,20}$", txtPrenom, label8, "Lettre majuscule suivie de 1 à 20 lettres minuscules");
            //appel de la méthode pour vérifier taille
            b_taille = VerifierTaille(txtTaille, label9);
            //appel de la méthode pour vérifier masse
            b_masse = VerifierMasse(txtMasse, label10);
            //Vérifier le combobox (position)
            b_combobox = VerifierCombobox(cbPosition, label11);
            //Si toutes les vérifications sont valides valides retouner vrai
            if (b_numero && b_nom && b_prenom && b_taille && b_masse && b_combobox)
                return true;
            else return false; //sinon retourner faux

        }

        //Remettre tous les champs à défault
        public void InitialiserControles()
        {
            //Réinitialiser tous les champs du formulaire
            txtNum.Text = "";
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtTaille.Text = "";
            txtMasse.Text = "";
            cbPosition.SelectedIndex = -1;
        }




        /// <summary>
        /// Évenement clicked pour le bouton ajouter joueur. Ajoute le joueur à la base de données s'il n,existe pas déjà.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if(VerifierTous()) //Si tous les champs sont valides
            {
                //Instancier un joueur avec les champs entrés par l'utilisateur
                Joueur joue = new Joueur(int.Parse(txtNum.Text), txtNom.Text, txtPrenom.Text,
                    double.Parse(txtTaille.Text), double.Parse(txtMasse.Text), cbPosition.Text);

                //Ajouter le joueur à la base de données
                Equipe.AjouterJoueur(joue);
                InitialiserControles();
            }
        }
    }
}
