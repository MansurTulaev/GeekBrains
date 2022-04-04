using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Building firstBuilding = new Building(30, 11, 45, 3);
            Console.WriteLine($"UniqueID: {Building._genereatedId}. Floor Height: {firstBuilding.GetFloorHeight()}. Flats in Entrance: {firstBuilding.GetFlatsEntrance()}. Flats on Floor: {firstBuilding.GetFlatsFloor()}");
            Building secondBuilding = new Building(45, 14, 60, 4);
            Console.WriteLine($"UniqueID: {Building._genereatedId}. Floor Height: {secondBuilding.GetFloorHeight()}. Flats in Entrance: {secondBuilding.GetFlatsEntrance()}. Flats on Floor: {secondBuilding.GetFlatsFloor()}");
            Console.ReadKey();
        }

        class Building
        {
            private int _buildingId;
            private int _buildongHeight;
            private int _buildingFloors;
            private int _buildingFlats;
            private int _buildingEntrance;
            public static int _genereatedId;

            public int BuildingId { get; set; }
            public int BuildingHeight { get; set; }
            public int BuildingFloors { get; set; }
            public int BuildingFlats { get; set; }
            public int BuildingEntrance { get; set; }

            public static void GenerateId() => ++_genereatedId;

            public Building(int totalHeight, int totalFloors, int totalFlats, int totalEntrance)
            {

                this.BuildingHeight = totalHeight;
                this.BuildingFloors = totalFloors;
                this.BuildingFlats = totalFlats;
                this.BuildingEntrance = totalEntrance;
                GenerateId();
            }


            public int GetFloorHeight()
            {
                return this.BuildingHeight / this.BuildingFloors;
            }

            public int GetFlatsEntrance ()
            {
                return this.BuildingFlats / this.BuildingEntrance;
            }

            public int GetFlatsFloor()
            {
                return this.BuildingFlats / this.BuildingFloors;
            }
        }
    }
}
