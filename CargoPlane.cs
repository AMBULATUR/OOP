namespace OOPLab1
{
    class CargoPlane : CivilPlanes
    {
        public CargoPlane(string boardNumber, int EngineCount) : base(boardNumber, EngineCount)
        {
        }
        public override void Display()
        {
            base.Display();
            System.Console.WriteLine("Cargo Plane");
        }

        public override void MoveTo(string dest)
        {
            System.Console.WriteLine("Move to {0}",dest);
        }
    }


}
