using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BiblioICGO;

namespace BiblioICGODAO
{
    public class SessionDAO
    {
        /// <summary>
        /// Ajouter une session dans la table SESSION
        /// </summary>
        /// <param name="uneSession"></param>
        public static void AjouterUneSession(Session uneSession)
        {
            // Exécution de la requête d'insertion
            string requete = "INSERT INTO SESSION VALUES ( '" + uneSession.GetLeStage().GetLaCompetence().GetCodeCompetence() + "', " + uneSession.GetLeStage().GetNumStage() + ", " + uneSession.GetNumSession() + ", '" + uneSession.GetLAgence().GetNomAgence() + "', " + uneSession.GetLeFormateur().GetNumFormateur() + ", '" + uneSession.GetDateSession() + "')";
            Connexion.ExecuterRequeteMaj(requete);
        }

        /// <summary>
        ///  Charger les sessions de la table SESSION dans une liste de sessions
        /// </summary>
        /// <returns></returns>
        public static List<Session> ChargerLesSessions()
        {

            List<Session> lesSessions = new List<Session>();
            Session uneSession;
            int numSession;
            DateTime dateSession;
            Stage unStage;
            string codeCompetence;
            int numStage;
            Agence uneAgence;
            string nomAgence;
            Formateur unFormateur;
            int numFormateur;

            lesSessions.Clear();

            // Exécuter la requête de sélection 
            string requete = "SELECT CODECOMPETENCE, NUMSTAGE, NUMSESSION, NOMAGENCE, NUMFORMATEUR, DATEDEBUTSESSION FROM SESSION";
            DataTable dt = Connexion.ExecuterRequete(requete);

            // Parcours du résultat de la requête
            foreach (DataRow uneLigne in dt.Rows)
            {
                // Récupération des caractéristiques d'une session à partir du résultat de la requête
                codeCompetence = uneLigne["CODECOMPETENCE"].ToString();
                numStage = int.Parse(uneLigne["NUMSTAGE"].ToString());
                numSession = int.Parse(uneLigne["NUMSESSION"].ToString());
                nomAgence = uneLigne["NOMAGENCE"].ToString();
                numFormateur = int.Parse(uneLigne["NUMFORMATEUR"].ToString());
                dateSession = DateTime.Parse(uneLigne["DATEDEBUTSESSION"].ToString());
                uneAgence = new Agence(nomAgence);
                unStage = StageDAO.GetStage(codeCompetence, numStage);
                unFormateur = FormateurDAO.GetFormateur(numFormateur);
                // Construction de l'objet uneSession avec chargement des stagiaires inscrits à cette session
                uneSession = new Session(numSession, dateSession, unStage, uneAgence, unFormateur, StagiaireDAO.ChargerLesStagiairesDeLaSession(codeCompetence, numStage, numSession));
                // Ajout de la session dans la liste lesSessions
                lesSessions.Add(uneSession);
            }

            return lesSessions;
        }

        /// <summary>
        /// Retourne une session identifiée dans la table SESSION
        /// </summary>
        /// <param name="idCompetence">Code compétence</param>
        /// <param name="idStage">Numéro stage</param>
        /// <param name="idSession">Numéro session</param>
        /// <returns></returns>
        public static Session GetSession(string idCompetence, int idStage, int idSession)
        {
            Session uneSession;
            DateTime dateSession;
            Stage unStage;
            Agence uneAgence;
            string nomAgence;
            Formateur unFormateur;
            int numFormateur;

            // Recherche de la session identifiée dans la table SESSION
            string requete = "SELECT NOMAGENCE, NUMFORMATEUR, DATEDEBUTSESSION FROM SESSION WHERE CODECOMPETENCE = '" + idCompetence + "' AND NUMSTAGE = " + idStage + " AND NUMSESSION = " + idSession;
            DataTable dt = Connexion.ExecuterRequete(requete);

            if (dt.Rows.Count == 1)
            {
                nomAgence = dt.Rows[0]["NOMAGENCE"].ToString();
                numFormateur = int.Parse(dt.Rows[0]["NUMFORMATEUR"].ToString());
                dateSession = DateTime.Parse(dt.Rows[0]["DATEDEBUTSESSION"].ToString());
                uneAgence = new Agence(nomAgence);
                unStage = StageDAO.GetStage(idCompetence, idStage);
                unFormateur = FormateurDAO.GetFormateur(numFormateur);
                // Construction de l'objet uneSession avec chargement des stagiaires inscrits à cette session
                uneSession = new Session(idSession, dateSession, unStage, uneAgence, unFormateur, StagiaireDAO.ChargerLesStagiairesDeLaSession(idCompetence, idStage, idSession));
            }
            else
            {
                uneSession = new Session();
            }

            return uneSession;
        }

        /// <summary>
        /// Modifier les caractéristiques d'une session identifiée dans la table SESSION
        /// </summary>
        /// <param name="uneSession">Une session</param>
        /// <param name="idCompetence">Code compétence</param>
        /// <param name="idStage">Numéro stage</param>
        /// <param name="idSession">Numéro session</param>
        public static void ModifierUneSession(Session uneSession, string idCompetence, int idStage, int idSession)
        {
            // Exécution de la requête de modification
            string requete = "UPDATE SESSION SET CODECOMPETENCE = '" + uneSession.GetLeStage().GetLaCompetence().GetCodeCompetence() + "', NUMSTAGE = " + uneSession.GetLeStage().GetNumStage() + ", NUMSESSION = " + uneSession.GetNumSession() + ", NOMAGENCE = '" + uneSession.GetLAgence().GetNomAgence() + "', NUMFORMATEUR = " + uneSession.GetLeFormateur().GetNumFormateur() + ", DATEDEBUTSESSION = '" + uneSession.GetDateSession() + "' WHERE CODECOMPETENCE = '" + idCompetence + "' AND NUMSTAGE = " + idStage + " AND NUMSESSION = " + idSession;
            Connexion.ExecuterRequeteMaj(requete);
        }

        /// <summary>
        /// Supprimer une session identifiée dans la table SESSION
        /// </summary>
        /// <param name="idCompetence">Code compétence</param>
        /// <param name="idStage">Numéro stage</param>
        /// <param name="idSession">Numéro session</param>
        public static void SupprimerUneSession(string idCompetence, int idStage, int idSession)
        {
            // Exécution de la requête de suppression
            string requete = "DELETE FROM SESSION WHERE CODECOMPETENCE = '" + idCompetence + "' AND NUMSTAGE = " + idStage + " AND NUMSESSION = " + idSession;
            Connexion.ExecuterRequeteMaj(requete);
        }

        /// <summary>
        /// Charger les sessions de la table INSCRIRE d'un stagiaire identifié par son numéro
        /// </summary>
        /// <param name="idStagiaire">Numéro stagiaire</param>
        /// <returns></returns>
        public static List<Session> ChargerLesSessionsDuStagiaire(int idStagiaire)
        {
            List<Session> lesSessions = new List<Session>();
            Stage unStage;
            string codeCompetence;
            int numStage;
            Session uneSession;
            int numSession;
            DateTime dateSession;
            Agence uneAgence;
            string nomAgence;
            Formateur unFormateur;
            int numFormateur;

            // Recherche des sessions auxquelles le stagiaire est inscrit
            lesSessions.Clear();
            string requete = "SELECT S.CODECOMPETENCE, S.NUMSTAGE, S.NUMSESSION, DATEDEBUTSESSION, NOMAGENCE, NUMFORMATEUR FROM SESSION AS S INNER JOIN INSCRIRE AS I ON S.CODECOMPETENCE = I.CODECOMPETENCE AND S.NUMSTAGE = I.NUMSTAGE AND S.NUMSESSION = I.NUMSESSION WHERE NUMSTAGIAIRE = " + idStagiaire;
            DataTable dt = Connexion.ExecuterRequete(requete);

            foreach (DataRow uneLigne in dt.Rows)
            {
                // Récupération des caractéristiques d'une session à partir du résultat de la requête
                codeCompetence = uneLigne["CODECOMPETENCE"].ToString();
                numStage = int.Parse(uneLigne["NUMSTAGE"].ToString());
                unStage = StageDAO.GetStage(codeCompetence, numStage);
                numSession = int.Parse(uneLigne["NUMSESSION"].ToString());
                dateSession = DateTime.Parse(uneLigne["DATEDEBUTSESSION"].ToString());
                nomAgence = uneLigne["NOMAGENCE"].ToString();
                uneAgence = new Agence(nomAgence);
                numFormateur = int.Parse(uneLigne["NUMFORMATEUR"].ToString());
                unFormateur = FormateurDAO.GetFormateur(numFormateur);
                // Création de l'objet uneSession et ajout dans la liste des sessions 
                uneSession = new Session(numSession, dateSession, unStage, uneAgence, unFormateur);
                lesSessions.Add(uneSession);
            }

            return lesSessions;
        }

        /// <summary>
        /// Charger les sessions n'appartenant pas à la table INSCRIRE d'un stagiaire identifié par son numéro
        /// </summary>
        /// <param name="idStagiaire">Numéro stagiaire</param>
        /// <returns></returns>
        public static List<Session> ChargerLesSessionsNonChoisiesDuStagiaire(int idStagiaire)
        {
            List<Session> lesSessions = new List<Session>();
            Stage unStage;
            string codeCompetence;
            int numStage;
            Session uneSession;
            int numSession;
            DateTime dateSession;
            Agence uneAgence;
            string nomAgence;
            Formateur unFormateur;
            int numFormateur;

            // Recherche des sessions auxquelles le stagiaire n'est pas encore inscrit
            lesSessions.Clear();
            string requete = "SELECT CODECOMPETENCE, NUMSTAGE, NUMSESSION, DATEDEBUTSESSION, NOMAGENCE, NUMFORMATEUR FROM SESSION AS S";
            requete = requete + " WHERE NOT EXISTS (SELECT CODECOMPETENCE, NUMSTAGE, NUMSESSION";
            requete = requete + " FROM INSCRIRE AS I";
            requete = requete + " WHERE I.CODECOMPETENCE = S.CODECOMPETENCE";
            requete = requete + " AND I.NUMSTAGE = S.NUMSTAGE";
            requete = requete + " AND I.NUMSESSION = S.NUMSESSION";
            requete = requete + " AND NUMSTAGIAIRE = " + idStagiaire + ");";
            DataTable dt = Connexion.ExecuterRequete(requete);

            foreach (DataRow uneLigne in dt.Rows)
            {
                // Récupération des caractéristiques d'une session à partir du résultat de la requête
                codeCompetence = uneLigne["CODECOMPETENCE"].ToString();
                numStage = int.Parse(uneLigne["NUMSTAGE"].ToString());
                unStage = StageDAO.GetStage(codeCompetence, numStage);
                numSession = int.Parse(uneLigne["NUMSESSION"].ToString());
                dateSession = DateTime.Parse(uneLigne["DATEDEBUTSESSION"].ToString());
                nomAgence = uneLigne["NOMAGENCE"].ToString();
                uneAgence = new Agence(nomAgence);
                numFormateur = int.Parse(uneLigne["NUMFORMATEUR"].ToString());
                unFormateur = FormateurDAO.GetFormateur(numFormateur);
                // Création de l'objet uneSession et ajout dans la liste des sessions 
                uneSession = new Session(numSession, dateSession, unStage, uneAgence, unFormateur);
                lesSessions.Add(uneSession);
            }

            return lesSessions;
        }
    }
}
