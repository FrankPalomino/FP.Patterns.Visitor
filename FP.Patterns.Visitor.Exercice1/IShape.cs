namespace FP.Patterns.Visitor.Exercice1
{
    public interface IShape
    {
        void Accept(IVisitor visitor);
    }
}
