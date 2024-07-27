namespace FP.Patterns.Visitor.Exercice4
{
    public class TextElement : IDocumentElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this); 
        }
    }
}
