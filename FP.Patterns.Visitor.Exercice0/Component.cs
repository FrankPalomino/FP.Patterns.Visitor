namespace FP.Patterns.Visitor
{
    public abstract class Component
    {
        string _serial;

        public Component(string serial)
        {
            _serial = serial;
        }

        public string Serial
        {
            get { return _serial; }
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(_serial);
        }
    }
}
