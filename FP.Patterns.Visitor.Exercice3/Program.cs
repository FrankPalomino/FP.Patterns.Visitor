using FP.Patterns.Visitor.Exercice3;

DiagnosticsVisitor diagnosticsVisitor = new DiagnosticsVisitor();
FirmwareUpdateVisitor firmwareUpdateVisitor = new FirmwareUpdateVisitor();
StatusReportVisitor statusReportVisitor = new StatusReportVisitor();

Light light = new Light();
light.Accept(diagnosticsVisitor);
Console.WriteLine("----------------------");

light.Accept(firmwareUpdateVisitor);
Console.WriteLine("----------------------");

light.Accept(statusReportVisitor);
Console.WriteLine("----------------------");
Console.WriteLine("----------------------");

DoorLock doorLock = new DoorLock();
doorLock.Accept(diagnosticsVisitor);
Console.WriteLine("----------------------");

doorLock.Accept(firmwareUpdateVisitor);
Console.WriteLine("----------------------");

doorLock.Accept(statusReportVisitor);
Console.WriteLine("----------------------");
