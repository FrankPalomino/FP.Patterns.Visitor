namespace FP.Patterns.Visitor.Exercice1
{
    public class Circle : IShape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Area()
        {
            return Radius * Radius * System.Math.PI;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
