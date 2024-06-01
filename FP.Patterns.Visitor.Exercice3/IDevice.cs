namespace FP.Patterns.Visitor.Exercice3
{
    public interface IDevice
    {
        void Accept(IVisitor visitor);
    }
}
