
namespace lab2AConsole
{
    class Rect : Shape
    {
        protected double x, y;

        public Rect()
        {
            area = 0;
            perimeter = 0;
            name = "Прямоугольник";
        }

        public Rect(double X, double Y) : this()
        {
            x = X;
            y = Y;
            GetArea();
            GetPerimeter();
        }

        public override double GetArea()
        {
            return area = x * y;
        }

        public override double GetPerimeter()
        {
            return perimeter = 2 * x + 2 * y;
        }

        public double GetX()
        {
            return x;
        }

        public double GetY()
        {
            return y;
        }
    }
}
