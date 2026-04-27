using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BiblioICGO;

namespace BiblioICGODAO
{
    public class ModuleDAO
    {
        /// <summary>
        /// Ajouter un module dans la table MODULE
        /// </summary>
        /// <param name="unModule">Un module</param>
        public static void AjouterUnModule(Module unModule)
        {
            string requette;

            requette = "INSERT INTO MODULE(numModule, nomModule, nomPresentation, nomSupportCours, placeSupportCours, placePresentation) VALUES ('" +
                        unModule.GetNumModule() + "', '" +
                        unModule.GetNomModule() + "', '" +
                        unModule.GetNomPresentation() + "', '" +
                        unModule.GetNomSupportCours() + "', '" +
                        unModule.GetPlaceSupportCours() + "', '" +
                        unModule.GetPlacePresentation() + "')";
            Connexion.ExecuterRequeteMaj(requette);
        }

        /// <summary>
        /// Charger les modules de la table MODULE dans une liste de modules
        /// </summary>
        /// <returns></returns>
        public static List<Module> ChargerLesModules()
        {
            List<Module> lesModules = new List<Module>();
            Module unModule;
            int numModule;
            string nomModule, nomSupportCours, nomPresentation, placeSupportCours, placePresentation;

            lesModules.Clear();

            // Requête pour récupérer les modules affectés à un stage donné
            string requete = "SELECT NUMMODULE, NOMMODULE, NOMPRESENTATION, NOMSUPPORTCOURS, PLACESUPPORTCOURS, PLACEPRESENTATION " +
                             "FROM MODULE";

            DataTable dt = Connexion.ExecuterRequete(requete);

            foreach (DataRow uneLigne in dt.Rows)
            {
                // Récupération des caractéristiques d'un module
                numModule = int.Parse(uneLigne["NUMMODULE"].ToString());
                nomModule = uneLigne["NOMMODULE"].ToString();
                nomPresentation = uneLigne["NOMPRESENTATION"].ToString();
                nomSupportCours = uneLigne["NOMSUPPORTCOURS"].ToString();
                placeSupportCours = uneLigne["PLACESUPPORTCOURS"].ToString();
                placePresentation = uneLigne["PLACEPRESENTATION"].ToString();

                // Création de l'objet Module
                unModule = new Module(numModule, nomModule, nomPresentation, nomSupportCours, placeSupportCours, placePresentation);

                // Ajout du module à la liste
                lesModules.Add(unModule);
            }

            return lesModules;
        }


        /// <summary>
        /// Retourne un module identifié par son numéro dans la table MODULE
        /// </summary>
        /// <param name="idModule">Numéro module</param>
        /// <returns></returns>
        /// <summary>
        /// Retourne un module identifié par son numéro dans la table MODULE
        /// </summary>
        /// <param name="idModule">Numéro module</param>
        /// <returns>Un objet Module</returns>
        public static Module GetModule(int idModule)
        {
            Module unModule;
            int numModule;
            string nomModule, nomPresentation, nomSupportCours, placeSupportCours, placePresentation;

            // Requête SQL pour récupérer les informations du module
            string requete = "SELECT numModule, nomModule, nomPresentation, nomSupportCours, placeSupportCours, placePresentation " +
                             "FROM MODULE WHERE numModule = " + idModule;

            DataTable dt = Connexion.ExecuterRequete(requete);

            if (dt.Rows.Count == 1)
            {
                numModule = int.Parse(dt.Rows[0]["numModule"].ToString());
                nomModule = dt.Rows[0]["nomModule"].ToString();
                nomPresentation = dt.Rows[0]["nomPresentation"].ToString();
                nomSupportCours = dt.Rows[0]["nomSupportCours"].ToString();
                placeSupportCours = dt.Rows[0]["placeSupportCours"].ToString();
                placePresentation = dt.Rows[0]["placePresentation"].ToString();

                // Création de l'objet Module avec les données récupérées
                unModule = new Module(numModule, nomModule, nomPresentation, nomSupportCours, placeSupportCours, placePresentation);
            }
            else
            {
                // Si aucun module trouvé, retourner un module vide
                unModule = new Module();
            }

            return unModule;
        }


        /// <summary>
        /// Modifier les caractéristiques d'un module identifié par son numéro dans la table MODULE
        /// </summary>
        /// <param name="unModule">Un module</param>
        /// <param name="idModule">Numéro module</param>
        public static void ModifierUnModule(Module unModule, int idModule)
        {
            // Construction de la requête SQL avec interpolation sécurisée
            string requete = "UPDATE MODULE SET " +
                             "nomModule = '" + unModule.GetNomModule() + "', " +
                             "nomPresentation = '" + unModule.GetNomPresentation() + "', " +
                             "nomSupportCours = '" + unModule.GetNomSupportCours() + "', " +
                             "placeSupportCours = '" + unModule.GetPlaceSupportCours() + "', " +
                             "placePresentation = '" + unModule.GetPlacePresentation() + "' " +
                             "WHERE numModule = " + idModule;

            Connexion.ExecuterRequeteMaj(requete);
        }


        /// <summary>
        /// Supprimer un module identifié par son numéro dans la table MODULE
        /// </summary>
        /// <param name="idModule">Numéro module</param>
        public static void SupprimerUnModule(int idModule)
        {
            string requete = "DELETE FROM MODULE WHERE numModule = " + idModule;

            Connexion.ExecuterRequeteMaj(requete);
        }


        /// <summary>
        /// Charger les modules affectés à un stage identifié par son code compétence et numéro stage
        /// </summary>
        /// <param name="idCompetence">Code compétence</param>
        /// <param name="idStage">Numéro stage</param>
        /// <returns>Liste des modules</returns>
        public static List<Module> ChargerLesModulesDuStage(string idCompetence, int idStage)
        {
            List<Module> lesModules = new List<Module>();
            Module unModule;
            int numModule;
            string nomModule, nomPresentation, nomSupportCours, placeSupportCours, placePresentation;

            lesModules.Clear();

            // Requête SQL pour récupérer les modules liés à une compétence et un stage
            string requete = "SELECT M.NUMMODULE, NOMMODULE, NOMPRESENTATION, NOMSUPPORTCOURS, PLACESUPPORTCOURS, PLACEPRESENTATION " +
                             "FROM MODULE AS M " +
                             "INNER JOIN COMPOSER AS C ON M.NUMMODULE = C.NUMMODULE " +
                             "WHERE NUMSTAGE = " + idStage + " AND CODECOMPETENCE = '" + idCompetence + "'";

            DataTable dt = Connexion.ExecuterRequete(requete);

            foreach (DataRow uneLigne in dt.Rows)
            {
                numModule = int.Parse(uneLigne["NUMMODULE"].ToString());
                nomModule = uneLigne["NOMMODULE"].ToString();
                nomPresentation = uneLigne["NOMPRESENTATION"].ToString();
                nomSupportCours = uneLigne["NOMSUPPORTCOURS"].ToString();
                placeSupportCours = uneLigne["PLACESUPPORTCOURS"].ToString();
                placePresentation = uneLigne["PLACEPRESENTATION"].ToString();

                unModule = new Module(numModule, nomModule, nomPresentation, nomSupportCours, placeSupportCours, placePresentation);
                lesModules.Add(unModule);
            }

            return lesModules;
        }

    }
}