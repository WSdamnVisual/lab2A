using System;

namespace lab2AConsole
{
    class Square : Rect
    {
        public Square() : base()
        {
            name = "Квадрат";
        }

        public Square(double x) : base(x, x)
        {
            name = "Квадрат";
        }

    }
}
