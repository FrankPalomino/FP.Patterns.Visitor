using FP.Patterns.Visitor.Exercice4;

List<IDocumentElement> documentElements = new List<IDocumentElement>()
{
    new ImageElement(),
    new TextElement(),
    new TableElement()
};

foreach(var element in documentElements)
{
    element.Accept(new ExportVisitor());
    Console.WriteLine("---------------");
    element.Accept(new RenderVisitor());
    Console.WriteLine("---------------");
    element.Accept(new SizeCalculationVisitor());
    Console.WriteLine("---------------");
}
