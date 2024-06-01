namespace FP.Patterns.Visitor.Exercice3
{
    public class Light : IDevice
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitLight(this);
        }
    }
}
