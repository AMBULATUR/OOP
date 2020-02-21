namespace OOPLab1
{
    class LargeJet : PrivatePlanes
    {
        public LargeJet(int passengerSeats, string boardNumber, int EngineCount) : base(passengerSeats, boardNumber, EngineCount)
        {
        }
        public override void Display()
        {
            base.Display();
            System.Console.WriteLine("Large Jet");
        }
    }


}
