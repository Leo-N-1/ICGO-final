using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblioICGO
{
    public class Session
    {
        #region Attributs privés

        private int numSession;
        private DateTime dateSession;
        private Stage leStage;
        private Agence lAgence;
        private Formateur leFormateur;
        private List<Stagiaire> lesStagiaires;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur
        /// </summary>
        public Session()
        {
            lesStagiaires = new List<Stagiaire>();
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="unNumSession">Numéro session</param>
        /// <param name="uneDate">Date session</param>
        /// <param name="unStage">Stage lié à la session</param>
        /// <param name="uneAgence">Agence où a lieu le stage</param>
        /// <param name="unFormateur">Formateur assurant la session</param>
        public Session(int unNumSession, DateTime uneDate, Stage unStage, Agence uneAgence, Formateur unFormateur)
        {
            numSession = unNumSession;
            dateSession = uneDate;
            leStage = unStage;
            lAgence = uneAgence;
            leFormateur = unFormateur;
            lesStagiaires = new List<Stagiaire>();
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="unNumSession">Numéro session</param>
        /// <param name="uneDate">Date session</param>
        /// <param name="unStage">Stage lié à la session</param>
        /// <param name="uneAgence">Agence où a lieu le stage</param>
        /// <param name="unFormateur">Formateur assurant la session</param>
        /// <param name="desStagiaires">Liste des stagiaires participant à la session</param>
        public Session(int unNumSession, DateTime uneDate, Stage unStage, Agence uneAgence, Formateur unFormateur, List<Stagiaire> desStagiaires)
        {
            numSession = unNumSession;
            dateSession = uneDate;
            leStage = unStage;
            lAgence = uneAgence;
            leFormateur = unFormateur;
            lesStagiaires = new List<Stagiaire>();
            lesStagiaires = desStagiaires;
        }

        #endregion

        #region Accesseurs

        /// <summary>
        /// Accesseur Get
        /// </summary>
        /// <returns>Numéro session</returns>
        public int GetNumSession()
        {
            return numSession;
        }

        /// <summary>
        /// Accesseur Set
        /// </summary>
        /// <param name="value">Numéro session</param>
        public void SetNumSession(int value)
        {
            numSession = value;
        }

        /// <summary>
        /// Accesseur Get
        /// </summary>
        /// <returns>Date session</returns>
        public DateTime GetDateSession()
        {
            return dateSession;
        }

        /// <summary>
        /// Accesseur Set
        /// </summary>
        /// <param name="value">Date session</param>
        public void SetDateSession(DateTime value)
        {
            dateSession = value;
        }

        /// <summary>
        /// Accesseur Get
        /// </summary>
        /// <returns>Stage</returns>
        public Stage GetLeStage()
        {
            return leStage;
        }

        /// <summary>
        /// Accesseur Set
        /// </summary>
        /// <param name="value">Stage</param>
        public void SetLeStage(Stage value)
        {
            leStage = value;
        }

        /// <summary>
        /// Accesseur Get
        /// </summary>
        /// <returns>Agence</returns>
        public Agence GetLAgence()
        {
            return lAgence;
        }

        /// <summary>
        /// Accesseur Set
        /// </summary>
        /// <param name="value">Agence</param>
        public void SetLAgence(Agence value)
        {
            lAgence = value;
        }

        /// <summary>
        /// Accesseur Get
        /// </summary>
        /// <returns>Formateur</returns>
        public Formateur GetLeFormateur()
        {
            return leFormateur;
        }

        /// <summary>
        /// Accesseur Set
        /// </summary>
        /// <param name="value">Formateur</param>
        public void SetLeFormateur(Formateur value)
        {
            leFormateur = value;
        }

        /// <summary>
        /// Accesseur Get
        /// </summary>
        /// <returns>Liste des stagiaires</returns>
        public List<Stagiaire> GetLesStagiaires()
        {
            return lesStagiaires;
        }

        /// <summary>
        /// Accesseur Set
        /// </summary>
        /// <param name="value">Liste des stagiaires</param>
        public void SetLesStagiaires(List<Stagiaire> value)
        {
            lesStagiaires = value;
        }

        #endregion


    }
}
