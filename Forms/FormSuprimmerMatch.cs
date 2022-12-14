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
    public partial class FormSuprimmerMatch : Form
    {
        public FormSuprimmerMatch()
        {
            InitializeComponent();
        }

        public bool VerifierRegex(string modele, TextBox tb, Label lb, string messageErreur)
        {
            //Créer du Regex reg 
            Regex reg = new Regex(modele);
            //Vérifier la correspondance entre le champ entré dans la textBox et le modèle
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
        /// Événement clicked pour le bouton suprimmer un match
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            //Initialiser le label
            label3.Text = "";
            //Vérifier que le numéro entré correspond au modèle
            bool b_numero = VerifierRegex("^[0-9]{4}$", txtNum1, label3, "4 chiffres");
            if (b_numero) //si oui suprimmer match
            {
                Horaire.SuprimmerMatch(int.Parse(txtNum1.Text));
                txtNum1.Text = "";
            }
        }
    }
}
