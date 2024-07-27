namespace FP.Patterns.Visitor.Exercice4
{
    public class RenderVisitor : IVisitor
    {
        public void Visit(ImageElement imageElement)
        {
            Console.WriteLine("Rendering Image...");
        }

        public void Visit(TextElement textElement)
        {
            Console.WriteLine("Rendering Text...");
        }

        public void Visit(TableElement tableElement)
        {
            Console.WriteLine("Rendering Table...");
        }
    }
}
