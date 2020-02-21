namespace OOPLab1
{
    class PassengerPlane : CivilPlanes
    {
        public PassengerPlane(string boardNumber, int EngineCount) : base(boardNumber, EngineCount)
        {
        }
        public override void Display()
        {
            base.Display();
            System.Console.WriteLine("Passenger plane");
        }

        public override void MoveTo(string dest)
        {
            System.Console.WriteLine("Move to {0}",dest);
        }
    }
}
