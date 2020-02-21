
using System;

namespace OOPLab1
{
    abstract class MilitaryPlanes : Airplane
    {
        protected string weaponName;
        protected int ammoCount;

        public MilitaryPlanes(string weaponName, int ammoCount, string boardNumber, int EngineCount) : base(boardNumber, EngineCount)
        {
            this.weaponName = weaponName;
            this.ammoCount = ammoCount;
        }

        public override void Display()
        {
            base.Display(); 
            Console.WriteLine("Weapon on board: {0} CurrentAmmoCount: {1}",weaponName,ammoCount);
        }
        public abstract void Shoot(int ammoLoss);

    }
}
