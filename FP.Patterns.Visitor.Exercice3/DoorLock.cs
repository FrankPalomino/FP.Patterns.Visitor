namespace FP.Patterns.Visitor.Exercice3
{
    public class DoorLock : IDevice
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitDoorLock(this);
        }
    }
}
