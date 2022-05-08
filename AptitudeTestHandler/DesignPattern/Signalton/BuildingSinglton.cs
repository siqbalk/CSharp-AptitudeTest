using AptitudeTestHandler.Implementation;
using System.Collections.Generic;

namespace AptitudeTestHandler.DesignPattern.Signalton
{
    public  class BuildingSinglton
    {
        IList<Building> buildingList = null;
        static bool isInitialized = false;
        static bool isbuildInitialized = false;
        public string build = null;
        private BuildingSinglton()
        {
        }

        private static BuildingSinglton _instance;

        public static BuildingSinglton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new BuildingSinglton();
            }
            return _instance;
        }

        public IList<Building> BuildingList
        {
            get
            {
                if (isInitialized == false)
                {
                    buildingList = new List<Building>();
                    isInitialized = true;
                }
                return buildingList;
            }
        }

        public string Build
        {
            get
            {
                if (isbuildInitialized == false)
                {
                    build = string.Empty;
                    isbuildInitialized = true;
                }
                return build;
            }
        }
    }
}
