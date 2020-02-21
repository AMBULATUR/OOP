
using System;

namespace OOPLab1
{
    abstract class Airplane
    {
        string boardNumber { get; set; } //todo
        private int engineCount;

        private bool engineState = false;
        private bool lightState = false;
        private bool gearsState = true;




        public Airplane(string boardNumber, int EngineCount)
        {
            this.boardNumber = boardNumber;
            this.engineCount = EngineCount;
        }

        public virtual void Display()
        {
            Console.WriteLine("Airplane : BoardNumber: {0} EngineCount: {1} GearsState: {2} lightState {3}", boardNumber, engineCount, gearsState,lightState);
        }
        public void ToggleEngine()
        {
            if (engineState == false)
                engineState = true;
            else
                engineState = false;
                Console.WriteLine("Engine : " + engineState);
        }
        public void ToggleLight()
        {
            if (lightState == false)
                lightState = true;
            else
                lightState = false;
            Console.WriteLine("Light : " + lightState);
        }
        public void ToggleGears()
        {
            if (gearsState == false)
                gearsState = true;
            else
                gearsState = false;
            Console.WriteLine("Gears : " + gearsState);
        }

    }
}
