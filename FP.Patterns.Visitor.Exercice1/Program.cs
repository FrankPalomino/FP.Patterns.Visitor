using FP.Patterns.Visitor.Exercice1;

IVisitor spanish = new SpanishVisitor();
IVisitor english = new EnglishVisitor();

var triangle = new Triangle(3, 4);
var circle = new Circle(5);

triangle.Accept(spanish);
triangle.Accept(english);

circle.Accept(spanish);
circle.Accept(english);