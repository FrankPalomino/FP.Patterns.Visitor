namespace FP.Patterns.Visitor.Exercice1
{
    public interface IVisitor
    {
        void Visit(Triangle triangle);
        void Visit(Circle circle);
    }
}
