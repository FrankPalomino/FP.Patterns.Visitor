namespace FP.Patterns.Visitor.Exercice2
{
    public interface IVisitor
    {
        void VisitLion(Lion lion);
        void VisitTiger(Tiger tiger);
        void VisitBear(Bear bear);
    }
}
