namespace FP.Patterns.Visitor.Exercice4
{
    public class ImageElement : IDocumentElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
