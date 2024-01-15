namespace FP.Patterns.Visitor.Exercice2
{
    public class FeedVisitor : IVisitor
    {
        public void VisitBear(Bear bear)
        {
            Console.WriteLine("Feed The Bear");
        }

        public void VisitLion(Lion lion)
        {
            Console.WriteLine("Feed The Lion");
        }

        public void VisitTiger(Tiger tiger)
        {
            Console.WriteLine("Feed The Tiger");
        }
    }
}
