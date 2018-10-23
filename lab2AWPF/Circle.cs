using System;



namespace lab2AConsole
{
    class Circle : Shape
    {
        private double r;

        public Circle() : base()
        {
            name = "Circle";
        }

        public Circle(string Name, double R)
        {
            name = Name;
            r = R;
            area = Math.PI * r * r;
            perimeter = 2 * Math.PI * r;
        }

        public double GetArea()
        {
            return area;
        }

        public double GetPerimeter()
        {
            return perimeter;
        }

        public double GetR()
        {
            return r;
        }
    }
}
