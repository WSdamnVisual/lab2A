using System;

namespace lab2AWPF
{
    abstract class Shape
    {
        protected double area, perimeter;
        protected string name;

        public Shape()
        {
            area = 0;
            perimeter = 0;
            name = "Без названия";
        }

        public string GetName()
        {
            return name;
        }
        
        public void Show()
        {
            Console.WriteLine(this.ToString());
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            return "Название = " + name + "; Периметр = " + perimeter + "; Площадь = " + area + ";";
        }
    }
}
