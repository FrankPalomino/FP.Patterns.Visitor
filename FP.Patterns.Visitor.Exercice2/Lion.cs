namespace FP.Patterns.Visitor.Exercice2
{
    public class Lion : IAnimal
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitLion(this);
        }
    }
}
