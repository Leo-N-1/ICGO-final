using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BiblioICGO;
using BiblioICGODAO;

namespace ProjetICGO
{
    public partial class frmInscription : Form
    {
        public frmInscription()
        {
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Ouverture du formulaire frmStagiaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStagiaire_Click(object sender, EventArgs e)
        {
            frmStagiaire fs = new frmStagiaire();
            cboStagiaire.SelectedIndex = -1;
            fs.Show();
        }

        /// <summary>
        /// Valorisation de cboSession : chargement des sessions non choisies du stagiaire
        /// </summary>
        private void ChargerLesSessionsNonChoisiesDuStagiaire()
        {

        }

        /// <summary>
        /// Ajout d'une inscription
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {




        }

        /// <summary>
        /// Remise à vide de l'ensemble des zones de saisie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            cboStagiaire.SelectedIndex = -1;
            cboSession.SelectedIndex = -1;
            cboEtat.SelectedIndex = -1;
        }

        private void frmInscription_Load(object sender, EventArgs e)
        {
            // Valorisation de cboEtat
            cboEtat.Items.Add("Définitif");
            cboEtat.Items.Add("Provisoire");
            // Valorisation de cboStagiaire

            // Valorisation de cboSession

        }

        /// <summary>
        /// Valorisation de cboSession après la sélection d'un stagiaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboStagiaire_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStagiaire.SelectedIndex >= 0)
            {
                // Charger les sessions auxquelles le stagiaire n'est pas encore inscrit : appel de ChargerLesSessionsNonChoisiesDuStagiaire()
                
            }
            else
            {
                cboStagiaire.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Valorisation de cboStagiaire sur le click de la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboStagiaire_Click(object sender, EventArgs e)
        {
            // Valorisation de cboStagiaire
           
        }
    }
}
