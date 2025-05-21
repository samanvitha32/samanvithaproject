using System;
using System.Collections.Generic;

namespace BuildingApp
{
    // Class representing a building
    class Building
    {
        public string Name { get; set; }
        public int Floors { get; set; }
        public string Location { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine("Building Name: " + Name);
            Console.WriteLine("Number of Floors: " + Floors);
            Console.WriteLine("Location: " + Location);
            Console.WriteLine("--------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Building> buildings = new List<Building>();
            bool exit = false;

            Console.WriteLine("=== Simple Building Info App ===");

            while (!exit)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Building");
                Console.WriteLine("2. View Buildings");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option (1-3): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Building building = new Building();

                        Console.Write("Enter building name: ");
                        building.Name = Console.ReadLine();

                        Console.Write("Enter number of floors: ");
                        building.Floors = int.Parse(Console.ReadLine());

                        Console.Write("Enter location: ");
                        building.Location = Console.ReadLine();

                        buildings.Add(building);
                        Console.WriteLine("Building added successfully!");
                        break;

                    case "2":
                        Console.WriteLine("\n--- Building List ---");
                        foreach (var b in buildings)
                        {
                            b.DisplayInfo();
                        }
                        if (buildings.Count == 0)
                            Console.WriteLine("N

