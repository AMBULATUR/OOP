
using System;

namespace OOPLab1
{
    class Bomber : MilitaryPlanes
    {
        public Bomber(string weaponName, int ammoCount, string boardNumber, int EngineCount)
            : base(weaponName, ammoCount, boardNumber, EngineCount)
        {

        }

        public override void Shoot(int ammoLoss)
        {
            if (ammoCount >= ammoLoss)
            {
                ammoCount -= ammoLoss;
                Console.WriteLine("Bomb drop type = {0} ammoCount: {1} ammoLoss: {2}", weaponName, ammoCount, ammoLoss);
            }
            else
            {
                Console.WriteLine("Недостаточно ammo");
            }

        }
    }
}
