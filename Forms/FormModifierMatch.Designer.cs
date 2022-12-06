namespace EquipeFrance.Forms
{
    partial class FormModifierMatch
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpJourMatch = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdversaire = new System.Windows.Forms.TextBox();
            this.Adversaire = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(-17, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(515, 3);
            this.label2.TabIndex = 6;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(220, 36);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(208, 20);
            this.txtNum1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numéro du match:";
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
            this.cbStade.Location = new System.Drawing.Point(220, 249);
            this.cbStade.Name = "cbStade";
            this.cbStade.Size = new System.Drawing.Size(208, 21);
            this.cbStade.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Stade:";
            // 
            // dtpJourMatch
            // 
            this.dtpJourMatch.CustomFormat = "dd MMMM yyyy";
            this.dtpJourMatch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJourMatch.Location = new System.Drawing.Point(220, 176);
            this.dtpJourMatch.Name = "dtpJourMatch";
            this.dtpJourMatch.Size = new System.Drawing.Size(208, 20);
            this.dtpJourMatch.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Date du match:";
            // 
            // txtAdversaire
            // 
            this.txtAdversaire.Location = new System.Drawing.Point(220, 108);
            this.txtAdversaire.Name = "txtAdversaire";
            this.txtAdversaire.Size = new System.Drawing.Size(208, 20);
            this.txtAdversaire.TabIndex = 15;
            // 
            // Adversaire
            // 
            this.Adversaire.AutoSize = true;
            this.Adversaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adversaire.Location = new System.Drawing.Point(20, 108);
            this.Adversaire.Name = "Adversaire";
            this.Adversaire.Size = new System.Drawing.Size(99, 20);
            this.Adversaire.TabIndex = 14;
            this.Adversaire.Text = "Adversaire:";
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(128, 326);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(191, 40);
            this.btnModifier.TabIndex = 23;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // FormModifierMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 408);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.cbStade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpJourMatch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdversaire);
            this.Controls.Add(this.Adversaire);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label1);
            this.Name = "FormModifierMatch";
            this.Text = "FormModifierMatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpJourMatch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdversaire;
        private System.Windows.Forms.Label Adversaire;
        private System.Windows.Forms.Button btnModifier;
    }
}