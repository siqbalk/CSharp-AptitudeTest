using AptitudeTestHandler.Implementation;

namespace AptitudeTestHandler.InfraStructure
{
    public interface IBuilding
    {
        Building Build();
        Building AddBedroom(string bedroomName);
        Building AddBalcony();
        Building AddKitchen();
        string Describe();

    }
}
