
using System;
using System.Collections;
using System.Collections.Generic;

namespace OOPLab1
{
    abstract class Airplane
    {
        string boardNumber { get; set; } //todo
        private int engineCount;
        private const int wings = 2;


        public Airplane(string boardNumber, int EngineCount)
        {
            this.boardNumber = boardNumber;
            this.engineCount = EngineCount;
        }

        public virtual void Display()
        {
            Console.WriteLine("Airplane : BoardNumber: {0} EngineCount: {1} WingsCount: {2}", boardNumber, engineCount, wings);
        }
        public virtual void StartEngine()
        {
            Console.WriteLine("Engine ON");
        }
        public virtual void TurnOnLight()
        {
            Console.WriteLine("Light ON");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Bomber> Bombers = new List<Bomber>();
            List<Fighter> Fighters = new List<Fighter>();
    

            Bomber AC130 = new Bomber("BombMK2", 30, "TT130AC", 4);
            Bomber AC145 = new Bomber("BombMK2", 60, "TT135", 6);
            Fighter F35b = new Fighter("GAU-8", 300, "aMC40", 1);
            Bombers.Add(AC130);
            Bombers.Add(AC145);
            Fighters.Add(F35b);

            
            foreach (var bomber in Bombers)
            {
                bomber.Display();
                bomber.StartEngine();
                bomber.TurnOnLight();
                bomber.Shoot(29);
                bomber.Shoot(3);
                Console.WriteLine();
            }

            foreach (var fighter in Fighters)
            {
                fighter.Display();
                fighter.StartEngine();
                fighter.TurnOnLight();
                fighter.Shoot(280);
                fighter.Shoot(30);
                Console.WriteLine();
            }




            Console.ReadKey();
        }
    }
}
