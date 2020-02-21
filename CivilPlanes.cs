namespace OOPLab1
{
    abstract class CivilPlanes : Airplane
    {

        public CivilPlanes(string boardNumber, int EngineCount) : base(boardNumber, EngineCount)
        {
            
        }
        public override void Display()
        {
            base.Display();
        }
        public abstract void MoveTo(string dest);
    }


}
