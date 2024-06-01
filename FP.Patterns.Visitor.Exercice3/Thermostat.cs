namespace FP.Patterns.Visitor.Exercice3
{
    public class Thermostat : IDevice
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitThermostat(this);
        }
    }
}
