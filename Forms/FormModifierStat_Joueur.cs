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




        private void btnModifier_Click(object sender, EventArgs e)
        {

        }
    }
}
