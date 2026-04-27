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
    public partial class frmAffecterModule : Form
    {
        // Déclaration d'un objet dynamic qui sera soit un stage étalé soit un stage groupé lors de l'exécution


        /// <summary>
        /// Constructeur du formulaire
        /// </summary>
        /// <param name="leStage">Stage transmis par le formulaire frmStage</param>
        public frmAffecterModule(                           )
        {
            InitializeComponent();
            // Valorisation de l'objet unStage



        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAffecterModule_Load(object sender, EventArgs e)
        {


        }

        /// <summary>
        /// Ajout d'un module choisi dans lstModule au stage et mise à jour du datagrid dgvCompetence et de la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {



        }

        /// <summary>
        /// Valorisation de la liste lstModule
        /// </summary>
        private void ChargerListeModules()
        {



        }

        /// <summary>
        /// Suppression d'un module d'un stage en cliquant sur le bouton supprimer (X)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvModule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Suppression de modules (sélection de un ou plusieurs) d'un stage par l'intermédiaire de la touche SUPPR du clavier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvModule_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

        }
    }
}
