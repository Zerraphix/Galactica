using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Galactica
{
    class Program
    {
        static void Main(string[] args)
        {
            Star star= new Star();
            Console.WriteLine("Hello World!");
            AddData();   
            
        }
        public static void AddData()
        {
            Star sun = new Star()
            {
                Id = 1,
                Name = "Sun",
                position = (new SpaceObjects.Position() { x = 0, y = 0 }),
                _Position = { x = 0, y = 1 },
                Type = StarType.YellowDwarf,
                Temperature = 5500
            };
            Planet mercury = new Planet()
            {
                Id = 1,
                Name = "Mercury",
                position = (new SpaceObjects.Position() { x = 20, y = 20 }),
                Type = PlanetType.Terrestial,
                Diameter = 4880000,
                RotationPeriod = 1407,
                RevolutionPeriod = 176
            };
            sun.PlanetList.Add(mercury);
            Planet venus = new Planet()
            {
                Id = 2,
                Name = "Venus",
                position = (new SpaceObjects.Position() { x = 30, y = 30 }),
                Type = PlanetType.Terrestial,
                Diameter = 6051800,
                RotationPeriod = 5832,
                RevolutionPeriod = 116
            };
            sun.PlanetList.Add(venus);
            Planet earth = new Planet()
            {
                Id = 3,
                Name = "Earth",
                position = new SpaceObjects.Position() { x = 50, y = 50 },
                Type = PlanetType.Terrestial,
                Diameter = 12742000,
                RotationPeriod = 24,
                RevolutionPeriod = 365
            };
            sun.PlanetList.Add(earth);
            Planet mars = new Planet()
            {
                Id = 4,
                Name = "Mars",
                position = new SpaceObjects.Position() { x = 60, y = 60 },
                Type = PlanetType.Terrestial,
                Diameter = 6779000,
                RotationPeriod = 25,
                RevolutionPeriod = 687
            };
            sun.PlanetList.Add(mars);
            Planet jupiter = new Planet()
            {
                Id = 5,
                Name = "Jupiter",
                position = new SpaceObjects.Position() { x = 80, y = 80 },
                Type = PlanetType.Gas_Giant,
                Diameter = 139820000,
                RotationPeriod = 10,
                RevolutionPeriod = 4380
            };
            sun.PlanetList.Add(jupiter);
            Planet saturn = new Planet()
            {
                Id = 6,
                Name = "Saturn",
                position = new SpaceObjects.Position() { x = 100, y = 100 },
                Type = PlanetType.Gas_Giant,
                Diameter = 116460000,
                RotationPeriod = 11,
                RevolutionPeriod = 10585
            };
            sun.PlanetList.Add(saturn);
            Planet uranus = new Planet()
            {
                Id = 7,
                Name = "Uranus",
                position = new SpaceObjects.Position() { x = 120, y = 120 },
                Type = PlanetType.Giant,
                Diameter = 50724000,
                RotationPeriod = 17,
                RevolutionPeriod = 30660
            };
            sun.PlanetList.Add(uranus);
            Planet neptune = new Planet()
            {
                Id = 8,
                Name = "Neptune",
                position = new SpaceObjects.Position() { x = 140, y = 140 },
                Type = PlanetType.Giant,
                Diameter = 49244000,
                RotationPeriod = 16,
                RevolutionPeriod = 60225
            };
            sun.PlanetList.Add(neptune);
            Moon luna = new Moon()
            {
                Id = 1,
                Name = "Luna",
                position = new SpaceObjects.Position() { x = 55, y = 55 },
                Orbiting = earth,
                Diameter = 3474800,
                RotationPeriod = 648,
                RevolutionPeriod = 27
            };
            earth.MoonList.Add(luna);
            Moon titan = new Moon()
            {
                Id = 2,
                Name = "Titan",
                position = new SpaceObjects.Position() { x = 105, y = 105 },
                Orbiting = saturn,
                Diameter = 5149500,
                RotationPeriod = 384,
                RevolutionPeriod = 16
            };
            saturn.MoonList.Add(titan);
            Moon phobos = new Moon()
            {
                Id = 3,
                Name = "Phobos",
                position = new SpaceObjects.Position() { x = 65, y = 65 },
                Orbiting = mars,
                Diameter = 22533,
                RotationPeriod = 8,
                RevolutionPeriod = 1
            };
            mars.MoonList.Add(phobos);
            Moon europe = new Moon()
            {
                Id = 4,
                Name = "Europe",
                position = new SpaceObjects.Position() { x = 85, y = 85 },
                Orbiting = jupiter,
                Diameter = 3121600,
                RotationPeriod = 85,
                RevolutionPeriod = 4
            };
            jupiter.MoonList.Add(europe);
            Moon deimos = new Moon()
            {
                Id = 5,
                Name = "Deimos",
                position = new SpaceObjects.Position() { x = 67, y = 67 },
                Orbiting = mars,
                Diameter = 12400,
                RotationPeriod = 30,
                RevolutionPeriod = 2
            };
            mars.MoonList.Add(deimos);
            Moon ganymedes = new Moon()
            {
                Id = 6,
                Name = "Ganymedes",
                position = new SpaceObjects.Position() { x = 87, y = 87 },
                Orbiting = jupiter,
                Diameter = 5268200,
                RotationPeriod = 171,
                RevolutionPeriod = 7
            };
            jupiter.MoonList.Add(ganymedes);
            Moon io = new Moon()
            {
                Id = 7,
                Name = "Io",
                position = new SpaceObjects.Position() { x = 78, y = 78 },
                Orbiting = jupiter,
                Diameter = 3643200,
                RotationPeriod = 42,
                RevolutionPeriod = 2
            };
            jupiter.MoonList.Add(io);
            Moon mimas = new Moon()
            {
                Id = 8,
                Name = "Mimas",
                position = new SpaceObjects.Position() { x = 97, y = 97 },
                Orbiting = saturn,
                Diameter = 396400,
                RotationPeriod = 23,
                RevolutionPeriod = 1
            };
            saturn.MoonList.Add(mimas);


            //Console.WriteLine(sun._Position);
            foreach (var planet in sun.PlanetList)
            {
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(planet))
                {
                    string name = descriptor.Name;
                    object value = descriptor.GetValue(planet);
                    Console.WriteLine($"{name}: {value}");
                    
                }
                Console.WriteLine("Distance to the sun: " + planet.Distance(sun));
                foreach (var moon in planet.MoonList)
                {
                    foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(moon))
                    {
                        string name = descriptor.Name;
                        object value = descriptor.GetValue(moon);
                        Console.WriteLine($"{name}: {value}");

                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
