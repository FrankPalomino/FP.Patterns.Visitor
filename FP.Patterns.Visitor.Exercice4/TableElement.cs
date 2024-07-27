namespace FP.Patterns.Visitor.Exercice4
{
    public class TableElement : IDocumentElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
