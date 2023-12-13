namespace FP.Patterns.Visitor.Exercice1
{
    public class Triangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Triangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double Area()
        {
            return Width * Height / 2;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
