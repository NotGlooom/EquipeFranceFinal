namespace EquipeFrance.Forms
{
    partial class FormAjouterMatch
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
            this.Adversaire = new System.Windows.Forms.Label();
            this.txtAdversaire = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpJourMatch = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStade = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Adversaire
            // 
            this.Adversaire.AutoSize = true;
            this.Adversaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adversaire.Location = new System.Drawing.Point(38, 102);
            this.Adversaire.Name = "Adversaire";
            this.Adversaire.Size = new System.Drawing.Size(99, 20);
            this.Adversaire.TabIndex = 1;
            this.Adversaire.Text = "Adversaire:";
            // 
            // txtAdversaire
            // 
            this.txtAdversaire.Location = new System.Drawing.Point(220, 102);
            this.txtAdversaire.Name = "txtAdversaire";
            this.txtAdversaire.Size = new System.Drawing.Size(208, 20);
            this.txtAdversaire.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date du match:";
            // 
            // dtpJourMatch
            // 
            this.dtpJourMatch.CustomFormat = "dd MMMM yyyy";
            this.dtpJourMatch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJourMatch.Location = new System.Drawing.Point(220, 170);
            this.dtpJourMatch.Name = "dtpJourMatch";
            this.dtpJourMatch.Size = new System.Drawing.Size(208, 20);
            this.dtpJourMatch.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Stade:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbStade
            // 
            this.cbStade.FormattingEnabled = true;
            this.cbStade.Items.AddRange(new object[] {
            "Al Bayt Stadium",
            "Khalifa International Stadium",
            "Al Thumama Stadium",
            "Ahmed Bin Alii Stadium",
            "Lusail Stadium",
            "Stadium 974",
            "Educatioin City Stadium",
            "Al Janoub Stadium"});
            this.cbStade.Location = new System.Drawing.Point(220, 243);
            this.cbStade.Name = "cbStade";
            this.cbStade.Size = new System.Drawing.Size(208, 21);
            this.cbStade.TabIndex = 13;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(129, 311);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(191, 40);
            this.btnAjouter.TabIndex = 14;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Numéro du match:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(220, 35);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(208, 20);
            this.txtNum.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 20;
            // 
            // FormAjouterMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 379);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cbStade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpJourMatch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdversaire);
            this.Controls.Add(this.Adversaire);
            this.Name = "FormAjouterMatch";
            this.Text = "FormAjouterMatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Adversaire;
        private System.Windows.Forms.TextBox txtAdversaire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpJourMatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStade;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}