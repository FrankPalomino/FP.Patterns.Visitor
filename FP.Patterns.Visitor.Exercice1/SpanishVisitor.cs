namespace FP.Patterns.Visitor.Exercice1
{
    internal class SpanishVisitor : IVisitor
    {
        public void Visit(Triangle triangle)
        {
            Console.WriteLine($"El área del triángulo es {triangle.Area()}");
        }

        public void Visit(Circle circle)
        {
            Console.WriteLine($"El área del círculo es {circle.Area()}");
        }
    }
}
