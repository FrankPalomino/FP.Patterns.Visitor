namespace FP.Patterns.Visitor.Exercice4
{
    public interface IDocumentElement
    {
        void Accept(IVisitor visitor);
    }
}
