namespace OOPLab1
{
    abstract class PrivatePlanes : Airplane
    {
        private int passengerSeats;

        public PrivatePlanes(int passengerSeats,string boardNumber, int EngineCount) : base(boardNumber, EngineCount)
        {
            this.passengerSeats = passengerSeats;
        }

        public override void Display()
        {
            base.Display();
            System.Console.WriteLine("PassengerSeats: {0}", passengerSeats);
        }
    }
}
