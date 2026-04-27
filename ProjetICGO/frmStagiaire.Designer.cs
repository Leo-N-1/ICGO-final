namespace ProjetICGO
{
    partial class frmStagiaire
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mskCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.mskTelephone = new System.Windows.Forms.MaskedTextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrenomStagiaire = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomStagiaire = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.txtNumStagiaire = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboStagiaire = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.mskCodePostal);
            this.groupBox1.Controls.Add(this.mskTelephone);
            this.groupBox1.Controls.Add(this.txtVille);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPrenomStagiaire);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNomStagiaire);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.btnSupprimer);
            this.groupBox1.Controls.Add(this.btnModifier);
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Controls.Add(this.txtRue);
            this.groupBox1.Controls.Add(this.txtNumStagiaire);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFermer);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 191);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(2245, 866);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mise à jour";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(120, 639);
            this.label11.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 39);
            this.label11.TabIndex = 60;
            this.label11.Text = "Téléphone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(101, 494);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 39);
            this.label7.TabIndex = 59;
            this.label7.Text = "Code postal";
            // 
            // mskCodePostal
            // 
            this.mskCodePostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCodePostal.Location = new System.Drawing.Point(371, 486);
            this.mskCodePostal.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.mskCodePostal.Mask = "00000";
            this.mskCodePostal.Name = "mskCodePostal";
            this.mskCodePostal.Size = new System.Drawing.Size(121, 45);
            this.mskCodePostal.TabIndex = 56;
            // 
            // mskTelephone
            // 
            this.mskTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelephone.Location = new System.Drawing.Point(371, 625);
            this.mskTelephone.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.mskTelephone.Mask = "00 00 00 00 00";
            this.mskTelephone.Name = "mskTelephone";
            this.mskTelephone.Size = new System.Drawing.Size(260, 45);
            this.mskTelephone.TabIndex = 55;
            // 
            // txtVille
            // 
            this.txtVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVille.Location = new System.Drawing.Point(1589, 479);
            this.txtVille.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(596, 45);
            this.txtVille.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1397, 494);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 39);
            this.label8.TabIndex = 53;
            this.label8.Text = "Ville";
            // 
            // txtPrenomStagiaire
            // 
            this.txtPrenomStagiaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenomStagiaire.Location = new System.Drawing.Point(1589, 188);
            this.txtPrenomStagiaire.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtPrenomStagiaire.Name = "txtPrenomStagiaire";
            this.txtPrenomStagiaire.Size = new System.Drawing.Size(609, 45);
            this.txtPrenomStagiaire.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1355, 188);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 39);
            this.label6.TabIndex = 51;
            this.label6.Text = "Prénom";
            // 
            // txtNomStagiaire
            // 
            this.txtNomStagiaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomStagiaire.Location = new System.Drawing.Point(371, 188);
            this.txtNomStagiaire.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtNomStagiaire.Name = "txtNomStagiaire";
            this.txtNomStagiaire.Size = new System.Drawing.Size(609, 45);
            this.txtNomStagiaire.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(224, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 39);
            this.label5.TabIndex = 49;
            this.label5.Text = "Nom";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(653, 744);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(237, 91);
            this.btnAnnuler.TabIndex = 48;
            this.btnAnnuler.Text = "A&nnuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(1331, 744);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(248, 88);
            this.btnSupprimer.TabIndex = 47;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(981, 744);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(248, 88);
            this.btnModifier.TabIndex = 46;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(315, 746);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(237, 86);
            this.btnAjouter.TabIndex = 44;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtRue
            // 
            this.txtRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRue.Location = new System.Drawing.Point(371, 336);
            this.txtRue.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(873, 45);
            this.txtRue.TabIndex = 43;
            // 
            // txtNumStagiaire
            // 
            this.txtNumStagiaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumStagiaire.Location = new System.Drawing.Point(371, 74);
            this.txtNumStagiaire.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtNumStagiaire.Name = "txtNumStagiaire";
            this.txtNumStagiaire.Size = new System.Drawing.Size(260, 45);
            this.txtNumStagiaire.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 351);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 39);
            this.label2.TabIndex = 41;
            this.label2.Text = "Rue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 39);
            this.label1.TabIndex = 40;
            this.label1.Text = "Numéro stagiaire";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(1693, 744);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(245, 91);
            this.btnFermer.TabIndex = 0;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 39);
            this.label3.TabIndex = 57;
            this.label3.Text = "un stagiaire";
            // 
            // cboStagiaire
            // 
            this.cboStagiaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStagiaire.FormattingEnabled = true;
            this.cboStagiaire.Location = new System.Drawing.Point(483, 50);
            this.cboStagiaire.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cboStagiaire.Name = "cboStagiaire";
            this.cboStagiaire.Size = new System.Drawing.Size(876, 46);
            this.cboStagiaire.TabIndex = 45;
            this.cboStagiaire.SelectedIndexChanged += new System.EventHandler(this.cboStagiaire_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboStagiaire);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 29);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Size = new System.Drawing.Size(2245, 148);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rechercher";
            // 
            // frmStagiaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2280, 1085);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmStagiaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stagiaire";
            this.Load += new System.EventHandler(this.frmStagiaire_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskCodePostal;
        private System.Windows.Forms.MaskedTextBox mskTelephone;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrenomStagiaire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomStagiaire;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txtNumStagiaire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboStagiaire;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}