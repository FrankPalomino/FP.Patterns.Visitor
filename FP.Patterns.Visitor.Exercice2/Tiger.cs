namespace FP.Patterns.Visitor.Exercice2
{
    public class Tiger : IAnimal
    {

        public void Accept(IVisitor visitor)
        {
            visitor.VisitTiger(this);
        }
    }
}
