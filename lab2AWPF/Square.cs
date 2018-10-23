using System;

namespace lab2AConsole
{
    class Square : Rect
    {
        public Square() : base()
        {
            name = "Square";
        }

        public Square(string Name, double x) : base(Name, x, x)
        { }
    }
}
