namespace EquipeFrance
{
    partial class FormParent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.joueursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnJoueurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUnJoueurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnJoueurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUnMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suprimmerUnMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fermerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statJoueurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statGardienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.fermerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.joueursToolStripMenuItem,
            this.matchsToolStripMenuItem,
            this.statistiqueToolStripMenuItem,
            this.afficherToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.afficherToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // joueursToolStripMenuItem
            // 
            this.joueursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnJoueurToolStripMenuItem,
            this.modifierUnJoueurToolStripMenuItem,
            this.supprimerUnJoueurToolStripMenuItem,
            this.toolStripSeparator1,
            this.fermerToolStripMenuItem});
            this.joueursToolStripMenuItem.Name = "joueursToolStripMenuItem";
            this.joueursToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.joueursToolStripMenuItem.Text = "Joueurs";
            // 
            // ajouterUnJoueurToolStripMenuItem
            // 
            this.ajouterUnJoueurToolStripMenuItem.Name = "ajouterUnJoueurToolStripMenuItem";
            this.ajouterUnJoueurToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.ajouterUnJoueurToolStripMenuItem.Text = "Ajouter un joueur";
            this.ajouterUnJoueurToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnJoueurToolStripMenuItem_Click);
            // 
            // modifierUnJoueurToolStripMenuItem
            // 
            this.modifierUnJoueurToolStripMenuItem.Name = "modifierUnJoueurToolStripMenuItem";
            this.modifierUnJoueurToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.modifierUnJoueurToolStripMenuItem.Text = "Modifier un joueur";
            this.modifierUnJoueurToolStripMenuItem.Click += new System.EventHandler(this.modifierUnJoueurToolStripMenuItem_Click);
            // 
            // supprimerUnJoueurToolStripMenuItem
            // 
            this.supprimerUnJoueurToolStripMenuItem.Name = "supprimerUnJoueurToolStripMenuItem";
            this.supprimerUnJoueurToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.supprimerUnJoueurToolStripMenuItem.Text = "Supprimer un joueur";
            this.supprimerUnJoueurToolStripMenuItem.Click += new System.EventHandler(this.supprimerUnJoueurToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.fermerToolStripMenuItem.Text = "Fermer";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // matchsToolStripMenuItem
            // 
            this.matchsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnMatchToolStripMenuItem,
            this.modifierUnMatchToolStripMenuItem,
            this.suprimmerUnMatchToolStripMenuItem,
            this.toolStripSeparator2,
            this.fermerToolStripMenuItem1});
            this.matchsToolStripMenuItem.Name = "matchsToolStripMenuItem";
            this.matchsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.matchsToolStripMenuItem.Text = "Matchs";
            // 
            // ajouterUnMatchToolStripMenuItem
            // 
            this.ajouterUnMatchToolStripMenuItem.Name = "ajouterUnMatchToolStripMenuItem";
            this.ajouterUnMatchToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ajouterUnMatchToolStripMenuItem.Text = "Ajouter un match";
            this.ajouterUnMatchToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnMatchToolStripMenuItem_Click);
            // 
            // modifierUnMatchToolStripMenuItem
            // 
            this.modifierUnMatchToolStripMenuItem.Name = "modifierUnMatchToolStripMenuItem";
            this.modifierUnMatchToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.modifierUnMatchToolStripMenuItem.Text = "Modifier un match";
            this.modifierUnMatchToolStripMenuItem.Click += new System.EventHandler(this.modifierUnMatchToolStripMenuItem_Click);
            // 
            // suprimmerUnMatchToolStripMenuItem
            // 
            this.suprimmerUnMatchToolStripMenuItem.Name = "suprimmerUnMatchToolStripMenuItem";
            this.suprimmerUnMatchToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.suprimmerUnMatchToolStripMenuItem.Text = "Suprimmer un match";
            this.suprimmerUnMatchToolStripMenuItem.Click += new System.EventHandler(this.suprimmerUnMatchToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
            // 
            // fermerToolStripMenuItem1
            // 
            this.fermerToolStripMenuItem1.Name = "fermerToolStripMenuItem1";
            this.fermerToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.fermerToolStripMenuItem1.Text = "Fermer";
            this.fermerToolStripMenuItem1.Click += new System.EventHandler(this.fermerToolStripMenuItem1_Click);
            // 
            // statistiqueToolStripMenuItem
            // 
            this.statistiqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.toolStripSeparator3,
            this.fermerToolStripMenuItem2});
            this.statistiqueToolStripMenuItem.Name = "statistiqueToolStripMenuItem";
            this.statistiqueToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.statistiqueToolStripMenuItem.Text = "Statistique";
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statJoueurToolStripMenuItem,
            this.statGardienToolStripMenuItem});
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // statJoueurToolStripMenuItem
            // 
            this.statJoueurToolStripMenuItem.Name = "statJoueurToolStripMenuItem";
            this.statJoueurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statJoueurToolStripMenuItem.Text = "Stat_Joueur";
            this.statJoueurToolStripMenuItem.Click += new System.EventHandler(this.statJoueurToolStripMenuItem_Click);
            // 
            // statGardienToolStripMenuItem
            // 
            this.statGardienToolStripMenuItem.Name = "statGardienToolStripMenuItem";
            this.statGardienToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statGardienToolStripMenuItem.Text = "Stat_Gardien";
            this.statGardienToolStripMenuItem.Click += new System.EventHandler(this.statGardienToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // fermerToolStripMenuItem2
            // 
            this.fermerToolStripMenuItem2.Name = "fermerToolStripMenuItem2";
            this.fermerToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.fermerToolStripMenuItem2.Text = "Fermer";
            this.fermerToolStripMenuItem2.Click += new System.EventHandler(this.fermerToolStripMenuItem2_Click);
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDToolStripMenuItem,
            this.horaireToolStripMenuItem,
            this.statistiqueToolStripMenuItem1});
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.afficherToolStripMenuItem.Text = "Afficher";
            // 
            // listeDToolStripMenuItem
            // 
            this.listeDToolStripMenuItem.Name = "listeDToolStripMenuItem";
            this.listeDToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.listeDToolStripMenuItem.Text = "Liste des joueurs";
            this.listeDToolStripMenuItem.Click += new System.EventHandler(this.listeDToolStripMenuItem_Click);
            // 
            // horaireToolStripMenuItem
            // 
            this.horaireToolStripMenuItem.Name = "horaireToolStripMenuItem";
            this.horaireToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.horaireToolStripMenuItem.Text = "Horaire";
            this.horaireToolStripMenuItem.Click += new System.EventHandler(this.horaireToolStripMenuItem_Click);
            // 
            // statistiqueToolStripMenuItem1
            // 
            this.statistiqueToolStripMenuItem1.Name = "statistiqueToolStripMenuItem1";
            this.statistiqueToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.statistiqueToolStripMenuItem1.Text = "Statistique";
            this.statistiqueToolStripMenuItem1.Click += new System.EventHandler(this.statistiqueToolStripMenuItem1_Click);
            // 
            // FormParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormParent";
            this.Text = "Gestion de l\'équipe de la France";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem joueursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnJoueurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUnJoueurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnJoueurToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnMatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUnMatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suprimmerUnMatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem statistiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiqueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem statJoueurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statGardienToolStripMenuItem;
    }
}

