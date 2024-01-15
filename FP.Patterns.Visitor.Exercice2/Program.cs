using FP.Patterns.Visitor.Exercice2;

IVisitor cleanVisitor = new CleanVisitor();
IVisitor feedVisitor =  new FeedVisitor();

Tiger tiger = new();
Lion lion = new();
Bear bear = new();

tiger.Accept(cleanVisitor);
lion.Accept(cleanVisitor);
bear.Accept(cleanVisitor);

Console.WriteLine("____________________");

tiger.Accept(feedVisitor);
lion.Accept(feedVisitor);
bear.Accept(feedVisitor);