namespace FP.Patterns.Visitor.Exercice1
{
    public class EnglishVisitor : IVisitor
    {
        public void Visit(Triangle triangle)
        {
            System.Console.WriteLine($"The area of the triangle is {triangle.Area()}");
        }

        public void Visit(Circle circle)
        {
            System.Console.WriteLine($"The area of the circle is {circle.Area()}");
        }
    }
}
