namespace FP.Patterns.Visitor.Exercice3
{
    public class DiagnosticsVisitor : IVisitor
    {
        public void VisitDoorLock(DoorLock doorLock)
        {
            Console.WriteLine("The Diagnostic to DoorLock is running...");
        }

        public void VisitLight(Light light)
        {
            Console.WriteLine("The Diagnostic to Light is running...");
        }

        public void VisitThermostat(Thermostat thermostat)
        {
            Console.WriteLine("The Diagnostic to Thermostat is running...");
        }
    }
}
