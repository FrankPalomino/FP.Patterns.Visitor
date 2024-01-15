namespace FP.Patterns.Visitor.Exercice2
{
    public class Bear : IAnimal
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitBear(this);
        }
    }
}
