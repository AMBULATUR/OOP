
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
                Console.WriteLine("Bomb drop type = {0} RemainingAmmo: {1} SpentAmmo: {2}", weaponName, ammoCount, ammoLoss);
            }
            else
            {
                Console.WriteLine("Недостаточно ammo, u want spent: {0} u have: {1}", ammoLoss, ammoCount);
            }

        }
    }
}
