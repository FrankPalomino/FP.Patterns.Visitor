namespace FP.Patterns.Visitor.Exercice3
{
    public class FirmwareUpdateVisitor : IVisitor
    {
        public void VisitDoorLock(DoorLock doorLock)
        {
            Console.WriteLine("The Firmware update to DoorLock is running...");
        }

        public void VisitLight(Light light)
        {
            Console.WriteLine("The Firmware update to Light is running...");
        }

        public void VisitThermostat(Thermostat thermostat)
        {
            Console.WriteLine("The Firmware update to Thermostat is running...");
        }
    }
}
