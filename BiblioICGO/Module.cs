using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblioICGO
{
    public class Module
    {

        #region Attributs privés

        private int numModule;
        private string nomModule, nomSupportCours, nomPresentation, placeSupportCours, placePresentation;
        private List<Stage> lesStages;

        #endregion

        #region Constructeurs

        public Module()
        {
            lesStages = new List<Stage>();
        }

        public Module(int unNumModule, string unNomModule, string unNomSupportCours, string unNomPresentation, string unPlaceSupportCours, string unPlacePresentation)
        {
            numModule = unNumModule;
            nomModule = unNomModule;
            nomPresentation = unNomPresentation;
            nomSupportCours = unNomSupportCours;
            placeSupportCours = unPlaceSupportCours;
            placePresentation = unPlacePresentation;
            lesStages = new List<Stage>();
        }

        public Module(int unNumModule, string unNomModule, string unNomSupportCours, string unNomPresentation, string unPlaceSupportCours, string unPlacePresentation, List<Stage> desStages)
        {
            numModule = unNumModule;
            nomModule = unNomModule;
            nomPresentation = unNomPresentation;
            nomSupportCours = unNomSupportCours;
            placeSupportCours = unPlaceSupportCours;
            placePresentation = unPlacePresentation;
            lesStages = new List<Stage>();
            lesStages = desStages;

        }
        #endregion

        #region Accesseurs

        public int GetNumModule()
        {
            return numModule;
        }

        public void SetNumModule(int value)
        {
            numModule = value;
        }

        public string GetNomModule()
        {
            return nomModule;
        }

        public void SetNomModule(string value)
        {
            nomModule = value;
        }

        public string GetNomSupportCours()
        {
            return nomSupportCours;
        }

        public void SetNomSupportCours(string value)
        {
            nomSupportCours = value;
        }

        public string GetNomPresentation()
        {
            return nomPresentation;
        }

        public void SetNomPresentation(string value)
        {
            nomPresentation = value;
        }

        public string GetPlaceSupportCours()
        {
            return placeSupportCours;
        }

        public void SetPlaceSupportCours(string value)
        {
            placeSupportCours = value;
        }

        public string GetPlacePresentation()
        {
            return placePresentation;
        }

        public void SetPlacePresentation(string value)
        {
            placePresentation = value;
        }

        public List<Stage> GetLesStages()
        {
            return lesStages;
        }

        public void SetLesStages(List<Stage> value)
        {
            lesStages = value;
        }
        #endregion

    }
}