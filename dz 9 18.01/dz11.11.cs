using System.Collections.Generic;

namespace BuildingSystem
{
    public static class BuildingCreator
    {
        private static Dictionary<int, Building> buildings = new Dictionary<int, Building>();
        private static int nextBuildingNumber = 1;
        public static int CreateBuild()
        {
            var building = new Building(nextBuildingNumber);
            buildings[nextBuildingNumber] = building;
            nextBuildingNumber++;
            return building.BuildingNumber;
        }
        public static bool RemoveBuilding(int buildingNumber)
        {
            return buildings.Remove(buildingNumber);
        }
    }
}
