using System;
using System.Data;
using System.Data.SqlClient;
using BiblioICGO;

namespace BiblioICGODAO
{
    public class InscriptionDAO
    {
        private static string connectionString = "your_connection_string_here";

        public static void AjouterUneInscription(Inscription uneInscription)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO INSCRIRE (idCompetence, idStage, idSession, idStagiaire, etatInscription) " +
                               "VALUES ('" + uneInscription.GetLasession().GetLeStage().GetLaCompetence().GetCodeCompetence() + "', " +
                               uneInscription.GetLasession().GetLeStage().GetNumStage() + ", " +
                               uneInscription.GetLasession().GetNumSession() + ", " +
                               uneInscription.GetLeStagiaire().GetNumStagiaire() + ", '" +
                               uneInscription.EtatInscription() + "')";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void ConfirmerInscription(Inscription uneInscription)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE INSCRIRE SET etatInscription = 'confirmée' WHERE " +
                               "idCompetence = '" + uneInscription.GetLasession().GetLeStage().GetLaCompetence().GetCodeCompetence() + "' AND " +
                               "idStage = " + uneInscription.GetLasession().GetLeStage().GetNumStage() + " AND " +
                               "idSession = " + uneInscription.GetLasession().GetNumSession() + " AND " +
                               "idStagiaire = " + uneInscription.GetLeStagiaire().GetNumStagiaire();

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void SupprimerUneInscription(string idCompetence, int idStage, int idSession, int idStagiaire)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM INSCRIRE WHERE " +
                               "idCompetence = '" + idCompetence + "' AND " +
                               "idStage = " + idStage + " AND " +
                               "idSession = " + idSession + " AND " +
                               "idStagiaire = " + idStagiaire;

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static bool VerifierPlacesDisponibles(string idCompetence, int idStage, int idSession)
        {
            bool disponible = false;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT s.nbPlaces, COUNT(i.idStagiaire) AS nbInscrits " +
                               "FROM SESSION s LEFT JOIN INSCRIRE i ON " +
                               "s.idCompetence = i.idCompetence AND s.idStage = i.idStage AND s.idSession = i.idSession " +
                               "WHERE s.idCompetence = '" + idCompetence + "' AND s.idStage = " + idStage + " AND s.idSession = " + idSession + " " +
                               "GROUP BY s.nbPlaces";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int nbPlaces = reader.GetInt32(0);
                    int nbInscrits = reader.GetInt32(1);
                    disponible = nbInscrits < nbPlaces;
                }
            }

            return disponible;
        }
    }
}