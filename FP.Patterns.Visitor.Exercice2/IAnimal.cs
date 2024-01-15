namespace FP.Patterns.Visitor.Exercice2
{
    public interface IAnimal
    {
        void Accept(IVisitor visitor);
    }
}
