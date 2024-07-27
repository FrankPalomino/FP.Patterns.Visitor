namespace FP.Patterns.Visitor.Exercice4
{
    public class ExportVisitor : IVisitor
    {
        public void Visit(ImageElement imageElement)
        {
            Console.WriteLine("Exporting Imagen...");
        }

        public void Visit(TextElement textElement)
        {
            Console.WriteLine("Exporting Text...");
        }

        public void Visit(TableElement tableElement)
        {
            Console.WriteLine("Exporting Table...");
        }
    }
}
