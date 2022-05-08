using AptitudeTestHandler.DesignPattern.Signalton;
using AptitudeTestHandler.InfraStructure;

namespace AptitudeTestHandler.Implementation
{
    public class Building :IBuilding
    {
        public string Kitchen { get; set; }
        public string Bedroom { get; set; }
        public string Balcony { get; set; }
        BuildingSinglton  buildingSinglton = null;

        public Building()
        {
            buildingSinglton = BuildingSinglton.GetInstance();
        }


        public Building AddBalcony()
        {
            var building = new Building()
            {
                Balcony = "balcony",
            };
            buildingSinglton.BuildingList.Add(building);

            return building;


        }

        public  Building AddBedroom(string bedroomName)
        {
            var building = new Building()
            {
                Bedroom = $"{bedroomName} room",
            };
            buildingSinglton.BuildingList.Add(building);

            return building;
        }

        public  Building AddKitchen()
        {
            var building = new Building()
            {
                Kitchen = "kitchen",
            };
            buildingSinglton.BuildingList.Add(building);

            return building;
        }

        public Building Build()
        {
            foreach(var building in buildingSinglton.BuildingList)
            {
                if(building.Kitchen != null )
                {
                    buildingSinglton.build += building.Kitchen + ", ";
                }
                if (building.Bedroom != null )
                {
                    buildingSinglton.build += building.Bedroom + ", ";
                }
                if (building.Balcony != null )
                {
                    buildingSinglton.build += building.Balcony + ", ";
                }
 
            }
            return new Building();
        }

        public string Describe()
        {
            var build = buildingSinglton.build;
            buildingSinglton.build = null;
            return build.Substring(0, build.LastIndexOf(","));
        }
    }
}
