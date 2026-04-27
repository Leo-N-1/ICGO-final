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
    public partial class frmSessionStage : Form
    {
        // Booléen indiquant si une session a été choisie dans cboSession
        private bool choixSession;

        public frmSessionStage()
        {
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSessionStage_Load(object sender, EventArgs e)
        {
            // Valorisation de cboAgence
            Manager.ChargerLesAgences(cboAgence);
            // Valorisation de cboStage
            Manager.ChargerLesStages(cboStage);
            // Valorisation de cboSession
            Manager.ChargerLesSessions(cboSession);
        }

        /// <summary>
        /// Valorisation de cboFormateur avec les formateurs compétents pour la session de stage 
        /// </summary>
        /// <param name="idCompetence">Code compétence</param>
        private void ChargerLesFormateursCompetents(string idCompetence)
        {
            List<Formateur> lesFormateurs = new List<Formateur>();

            cboFormateur.Items.Clear();
            // Recherche des formateurs compétents pour la session de stage dans la base de données
            lesFormateurs = FormateurDAO.ChargerLesFormateursCompetents(idCompetence);
            // Création d'un libellé "numéro. nom prénom" et ajout dans cboFormateur pour chaque formateur
            foreach (Formateur unFormateur in lesFormateurs)
            {
                cboFormateur.Items.Add(unFormateur.GetNumFormateur() + ". " + unFormateur.GetNomFormateur() + " " + unFormateur.GetPrenom());
            }
        }


        /// <summary>
        /// Ajout d'une session de stage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int numSession;
            int idStage;
            int numFormateur;
            string idCompetence;
            string nomAgence;
            DateTime dateSession;
            Session uneSession;
            Agence uneAgence;
            Formateur unFormateur;
            dynamic unStage;

            if ((cboStage.SelectedIndex >= 0) && (!txtNumSession.Text.Equals("")))
            {
                if (!int.TryParse(txtNumSession.Text, out numSession))
                {
                    MessageBox.Show("Le numéro de session est incorrect", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        // Récupération des informations saisies et ajout du caractère ' en double si nécessaire pour construire une requête SQL
                        Utilitaires.ExtraireIdStage(cboStage.Text, out idCompetence, out idStage);
                        numFormateur = Utilitaires.ExtraireNumFormateur(cboFormateur.Text);
                        nomAgence = cboAgence.Text;
                        dateSession = dtpDateSession.Value;
                        // Création de l'objet uneAgence
                        uneAgence = new Agence(nomAgence);
                        // Création de l'objet unStage
                        unStage = StageDAO.GetStage(idCompetence, idStage);
                        // Création de l'objet unFormateur
                        unFormateur = FormateurDAO.GetFormateur(numFormateur);
                        // Création de l'objet uneSession
                        uneSession = new Session(numSession, dateSession, unStage, uneAgence, unFormateur);
                        // Création de la session dans la base de données
                        SessionDAO.AjouterUneSession(uneSession);
                        // Valorisation de cboSession
                        Manager.ChargerLesSessions(cboSession);
                        // Remise à vide des zones : déclenchement du bouton annuler
                        btnAnnuler_Click(null, EventArgs.Empty);
                        // Message
                        MessageBox.Show("Session de stage enregistrée", "Mise à jour réussie !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Mise à jour échouée !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Choisir un stage et saisir un numéro session", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Remise à vide de l'ensemble des zones de saisie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            choixSession = false;
            txtNumSession.Clear();
            dtpDateSession.Value = DateTime.Now;
            cboAgence.SelectedIndex = -1;
            cboFormateur.SelectedIndex = -1;
            cboStage.SelectedIndex = -1;
            cboSession.SelectedIndex = -1;
        }

        /// <summary>
        /// Modification de la session
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            int numSession, idSession;
            int idStage;
            int numFormateur;
            string codeCompetence;
            string nomAgence;
            DateTime dateSession;
            Session uneSession;
            Agence uneAgence;
            Formateur unFormateur;
            dynamic unStage;

            // si sélection d'une session : extraction de son identifiant et recherche et affichage de ses caractéristiques
            if (cboSession.SelectedIndex >= 0)
            {
                if (!int.TryParse(txtNumSession.Text, out numSession))
                {
                    MessageBox.Show("Le numéro de session est incorrect", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        // Récupération de l'identifiant de la session (code compétence, numéro stage, numéro session) choisi dans cboSession
                        Utilitaires.ExtraireIdSession(cboSession.Text, out codeCompetence, out idStage, out idSession);
                        // Récupération des informations des zones de saisie et ajout du caractère ' en double si nécessaire pour construire une requête SQL
                        numFormateur = Utilitaires.ExtraireNumFormateur(cboFormateur.Text);
                        nomAgence = cboAgence.Text;
                        dateSession = dtpDateSession.Value;
                        // Création de l'objet uneAgence
                        uneAgence = new Agence(nomAgence);
                        // Création de l'objet unStage
                        unStage = StageDAO.GetStage(codeCompetence, idStage);
                        // Création de l'objet unFormateur
                        unFormateur = FormateurDAO.GetFormateur(numFormateur);
                        // Création de l'objet uneSession
                        uneSession = new Session(numSession, dateSession, unStage, uneAgence, unFormateur);
                        // Mise à jour de la session dans la base de données
                        SessionDAO.ModifierUneSession(uneSession, codeCompetence, idStage, idSession);
                        // Valorisation de cboSession
                        Manager.ChargerLesSessions(cboSession);
                        // Message
                        MessageBox.Show("Session de stage enregistrée", "Mise à jour réussie !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Mise à jour échouée !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Aucune session de stage choisie dans la liste", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Supprimer une session de stage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int idStage;
            int idSession;
            string codeCompetence;
            DialogResult reponse;

            // Si une session est choisie dans cboSession
            if (cboSession.SelectedIndex >= 0)
            {
                reponse = MessageBox.Show("Etes vous sûr de vouloir supprimer cette session de stage ?", "Suppression d'une session de stage", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (reponse == DialogResult.Yes)
                {
                    try
                    {
                        // Récupération de l'identifiant de la session (code compétence, numéro stage, numéro session) choisi dans cboSession
                        Utilitaires.ExtraireIdSession(cboSession.Text, out codeCompetence, out idStage, out idSession);
                        // Supprimer la session identifiée dans la base de données
                        SessionDAO.SupprimerUneSession(codeCompetence, idStage, idSession);
                        Manager.ChargerLesSessions(cboSession);
                        // Remise à vide des zones : déclenchement du bouton annuler
                        btnAnnuler_Click(null, EventArgs.Empty);
                        // Message
                        MessageBox.Show("Session de stage supprimée", "Mise à jour réussie !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Mise à jour échouée !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Aucune session de stage choisie dans la liste", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Valorisation des zones de saisie à la sélection d'une session choisie dans cboSession
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idStage;
            int idSession;
            string codeCompetence;
            Session uneSession;
            int indexFormateur;
            int indexStage;
            string identStage;
            string identFormateur;

            choixSession = true;
            // si sélection d'une session : extraction de son identifiant et recherche et affichage de ses caractéristiques
            if (cboSession.SelectedIndex >= 0)
            {
                Utilitaires.ExtraireIdSession(cboSession.Text, out codeCompetence, out idStage, out idSession);
                uneSession = SessionDAO.GetSession(codeCompetence, idStage, idSession);
                identStage = codeCompetence + ". " + idStage.ToString();
                indexStage = cboStage.FindString(identStage);
                //indexStage = ExtraireIndexStage(codeCompetence, idStage);
                cboStage.SelectedIndex = indexStage;
                txtNumSession.Text = idSession.ToString();
                dtpDateSession.Value = uneSession.GetDateSession();
                cboAgence.Text = uneSession.GetLAgence().GetNomAgence();
                ChargerLesFormateursCompetents(codeCompetence);
                identFormateur = uneSession.GetLeFormateur().GetNumFormateur().ToString();
                indexFormateur = cboFormateur.FindString(identFormateur);
                //indexFormateur = ExtraireIndexFormateur(uneSession.GetLeFormateur().GetNumFormateur());
                cboFormateur.SelectedIndex = indexFormateur;
            }
        }

        /// <summary>
        /// Valorisation des zones de saisie à la sélection d'un stage choisi dans cboStage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboStage_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idStage;
            string codeCompetence;

            // si sélection d'un stage : extraction de son identifiant et recherche et affichage de ses caractéristiques
            if (cboStage.SelectedIndex >= 0)
            {
                if (choixSession) // une session a été choisie précédemment
                {
                    choixSession = false;
                }
                else // un stage a été choisi
                {
                    Utilitaires.ExtraireIdStage(cboStage.Text, out codeCompetence, out idStage);
                    txtNumSession.Clear();
                    dtpDateSession.Value = DateTime.Now;
                    cboAgence.SelectedIndex = -1;
                    ChargerLesFormateursCompetents(codeCompetence);
                    cboFormateur.SelectedIndex = -1;
                    cboSession.SelectedIndex = -1;
                }
            }
        }

    }
}
