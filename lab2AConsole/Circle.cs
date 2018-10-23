using System;



namespace lab2AConsole
{
    class Circle : Shape
    {
        private double r;

        public Circle() : base()
        {
            name = "Круг";
        }

        public Circle(double R) : this()
        {
            r = R;
            GetArea();
            GetPerimeter();
        }

        public override double GetArea()
        {
            return area = Math.PI * r * r;
        }

        public override double GetPerimeter()
        {
            return perimeter = 2 * Math.PI * r;
        }
    }
}
