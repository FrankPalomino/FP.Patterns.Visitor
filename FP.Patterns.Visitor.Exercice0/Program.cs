using FP.Patterns.Visitor;

IVisitor visitor = new ConcretVisitor();
IVisitor visitor2 = new ConcretVisitor2();

Component hardDisk = new HardDisk("12341234-DR");
Component cpu = new CPU("12341234-CPU");
Component motherBoard = new MotherBoard("12341234-MB");

hardDisk.Accept(visitor);
cpu.Accept(visitor);
motherBoard.Accept(visitor);

hardDisk.Accept(visitor2);
cpu.Accept(visitor2);
motherBoard.Accept(visitor2);