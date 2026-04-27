using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblioICGO
{
    public class Inscription
    {
        #region Attributs privés

        private Session laSession;
        private Stagiaire leStagiaire;
        private string etatInscription;

        #endregion

        #region Constructeurs

        public Inscription()
        {

        }

        public Inscription(Session uneSession, Stagiaire unStagiaire, string unetatInscription)
        {
            laSession = uneSession;
            leStagiaire = unStagiaire;
            etatInscription = unetatInscription;
        }

        #endregion

        #region Accesseurs

        public Session GetLasession()
        {
            return laSession;
        }

        public void SetLaSession(Session uneSession)
        {
            laSession = uneSession;
        }

        public Stagiaire GetLeStagiaire()
        {
            return leStagiaire;
        }

        public void SetLeStagiaire(Stagiaire unStagiaire)
        {
            leStagiaire = unStagiaire;
        }

        public string EtatInscription()
        {
            return etatInscription;
        }

        public void SetEtatInscription(string unetatInscription)
        {
            etatInscription = unetatInscription;
        }

        #endregion
    }
}