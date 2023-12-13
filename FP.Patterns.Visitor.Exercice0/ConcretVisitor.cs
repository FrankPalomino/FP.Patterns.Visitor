namespace FP.Patterns.Visitor
{
    public class ConcretVisitor : IVisitor
    {
        public void Visit(string serial)
        {
            System.Console.WriteLine("Serial: {0}", serial);
        }
    }

    public class ConcretVisitor2 : IVisitor
    {
        public void Visit(string serial)
        {
            System.Console.WriteLine("El número de serie es: {0}", serial);
        }
    }
}
