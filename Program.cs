
using System;
using System.Collections;
using System.Collections.Generic;

namespace OOPLab1
{


    class Program
    {
        static void Main(string[] args)
        {
            List<Bomber> Bombers = new List<Bomber>();
            List<Fighter> Fighters = new List<Fighter>();
            List<LargeJet> LargeJets = new List<LargeJet>();
            List<PassengerPlane> PassengerPlanes = new List<PassengerPlane>();
            List<CargoPlane> CargoPlanes = new List<CargoPlane>();

            Bomber AC130 = new Bomber("BombMK2", 30, "TT130AC", 4);
            Bomber AC145 = new Bomber("BombMK2", 60, "TT135", 6);
            Fighter F35b = new Fighter("GAU-8", 300, "aMC40", 1);
            LargeJet BiT17 = new LargeJet(30, "TTAC155", 2);
            PassengerPlane Airbus10 = new PassengerPlane("AT130ZZ", 2);
            CargoPlane AN12 = new CargoPlane("TT11", 2);

            Bombers.Add(AC130);
            Bombers.Add(AC145);
            Fighters.Add(F35b);
            LargeJets.Add(BiT17);
            PassengerPlanes.Add(Airbus10);


            foreach (var bomber in Bombers)
            {
                bomber.Display();
                bomber.ToggleEngine();
                bomber.ToggleLight();
                bomber.ToggleGears();
                bomber.Shoot(29);
                bomber.Shoot(3);

                Console.WriteLine();
            }

            foreach (var fighter in Fighters)
            {
                fighter.Display();
                fighter.ToggleEngine();
                fighter.ToggleLight();
                fighter.ToggleGears();
                fighter.Shoot(280);
                fighter.Shoot(30);
                Console.WriteLine();
            }

            foreach (var jet in LargeJets)
            {
                jet.Display();
                jet.ToggleEngine();
                jet.ToggleGears();
                jet.ToggleLight();
                Console.WriteLine();
            }
            foreach (var plane in PassengerPlanes)
            {
                plane.Display();
                plane.ToggleLight();
                plane.ToggleEngine();
                plane.ToggleGears();
                Console.WriteLine();
            }
            foreach (var plane in CargoPlanes)
            {
                plane.Display();
                plane.MoveTo("Destination");
                plane.ToggleEngine();
                plane.ToggleGears();
                plane.ToggleLight();
            }


            Console.ReadKey();
        }
    }
}
