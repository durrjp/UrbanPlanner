using System;
using System.Collections.Generic;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building Carillon = new Building("1800 4th Ave N")
            {
                Width = 2000,
                Depth = 500,
                Stories = 7
            };
            Building Icon = new Building("100 Gulch Way")
            {
                Width = 1000,
                Depth = 4000,
                Stories = 20
            };
            Building RedBrickLodge = new Building("5 Forest Tree Drive")
            {
                Width = 100,
                Depth = 50,
                Stories = 1
            };
            List<Building> Buildings = new List<Building>()
            {
                Carillon,Icon,RedBrickLodge
            };
            
            Carillon.Contruct();
            Icon.Contruct();
            RedBrickLodge.Contruct();
            Carillon.Purchase("Tony Stark");
            Icon.Purchase("Donald Trump");
            RedBrickLodge.Purchase("Grandma");
            
            foreach (Building building in Buildings)
            {
                Console.WriteLine(building);
            }


        }
    }
}
