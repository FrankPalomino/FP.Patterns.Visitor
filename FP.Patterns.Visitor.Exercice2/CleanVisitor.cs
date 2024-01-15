namespace FP.Patterns.Visitor.Exercice2
{
    public class CleanVisitor : IVisitor
    {
        public void VisitBear(Bear bear)
        {
            Console.WriteLine("Clear the room of the Bear");
        }

        public void VisitLion(Lion lion)
        {
            Console.WriteLine("Clear the room of the Lion");
        }

        public void VisitTiger(Tiger tiger)
        {
            Console.WriteLine("Clear the room of the Tiger");
        }
    }
}
