namespace FP.Patterns.Visitor.Exercice3
{
    public class StatusReportVisitor : IVisitor
    {
        public void VisitDoorLock(DoorLock doorLock)
        {
            Console.WriteLine("The Status repost to DoorLock is running...");
        }

        public void VisitLight(Light light)
        {
            Console.WriteLine("The Status repost to Light is running...");
        }

        public void VisitThermostat(Thermostat thermostat)
        {
            Console.WriteLine("The Status repost to Thermostat is running...");
        }
    }
}
