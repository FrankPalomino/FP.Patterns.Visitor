namespace FP.Patterns.Visitor.Exercice4
{
    public class SizeCalculationVisitor : IVisitor
    {
        public void Visit(ImageElement imageElement)
        {
            Console.WriteLine("Calculating Image size...");
        }
        public void Visit(TextElement textElement)
        {
            Console.WriteLine("Calculating Text size...");
        }
        public void Visit(TableElement tableElement)
        {
            Console.WriteLine("Calculating Table size...");
        }
    }
}
