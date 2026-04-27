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
    public partial class frmConfirmerInscription : Form
    {
        public frmConfirmerInscription()
        {
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Confirmer une inscription (état définitif)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmer_Click(object sender, EventArgs e)
        {




        }

        private void frmConfirmerInscription_Load(object sender, EventArgs e)
        {
            // Valorisation de cboStagiaire

        }

        /// <summary>
        /// Valorisation de cboSession : chargement des sessions du stagiaire
        /// </summary>
        private void ChargerLesSessionsDuStagiaire()
        {



        }



        private void cboStagiaire_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Valorisation de cboSession
            ChargerLesSessionsDuStagiaire();
        }

        /// <summary>
        /// Suppression d'une inscription
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }

 
    }
}
