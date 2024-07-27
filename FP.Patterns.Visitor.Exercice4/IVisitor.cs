namespace FP.Patterns.Visitor.Exercice4
{
    public interface IVisitor
    {
        void Visit(ImageElement imageElement);
        void Visit(TextElement textElement);
        void Visit(TableElement tableElement);
    }
}
