using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EquipeFrance.Classes;
using EquipeFrance.Forms;


namespace EquipeFrance
{
    public partial class FormParent : Form
    {
        public FormParent()
        {
            InitializeComponent();
        }

        private void listeDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajouterUnJoueurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form enfant
            FormAjouterJoueur aj = new FormAjouterJoueur();
            aj.MdiParent = this;
            aj.Show();
        }

        private void modifierUnJoueurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form enfant
            FormModifierJoueur mj = new FormModifierJoueur();
            mj.MdiParent = this;
            mj.Show();
        }

        private void supprimerUnJoueurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form enfant
            FormSuprimmerJoueur sj = new FormSuprimmerJoueur();
            sj.MdiParent = this;
            sj.Show();
        }
    }
}
