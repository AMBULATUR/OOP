namespace OOPLab1
{
    class LightJet : PrivatePlanes
    {
        public LightJet(int passengerSeats, string boardNumber, int EngineCount) : base(passengerSeats,boardNumber, EngineCount)
        {
        }
        public override void Display()
        {
            base.Display();
            System.Console.WriteLine("Light Jet");
        }
    }
}
