namespace FP.Patterns.Visitor.Exercice3
{
    public interface IVisitor
    {
        void VisitLight(Light light);
        void VisitThermostat(Thermostat thermostat);
        void VisitDoorLock(DoorLock doorLock);
    }
}
