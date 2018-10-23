using System;

namespace lab2AConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exception BullshitException = new Exception();
            int fType = 0;
            double x, y;
            do
            {
                Console.Clear();
                Console.WriteLine("Типы фигур:\n1 - Прямоугольник\n2 - Квадрат\n3 - Круг");
                Console.Write("Введите номер фигуры: ");
                if (Int32.TryParse(Console.ReadLine(), out fType) && (fType > 0 && fType < 4))
                {
                    if (fType == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("*****Выбранная фигура - прямоугольник*****\n");
                        do
                        {
                            Console.Write("Введите длину: ");
                            if (Double.TryParse(Console.ReadLine(), out x))
                                break;
                            else
                            {
                                Console.WriteLine("Неверный ввод!");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("*****Выбранная фигура - прямоугольник*****\n");
                            }
                        } while (true);

                        do
                        {
                            Console.Write("Введите ширину: ");
                            if (Double.TryParse(Console.ReadLine(), out y))
                                break;
                            else
                            {
                                Console.WriteLine("Неверный ввод!");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("*****Выбранная фигура - прямоугольник*****\n");
                                Console.WriteLine("Введите длину: " + x);
                            }
                        } while (true);

                        Rect rect = new Rect(x, y);
                        Console.WriteLine("Введённая фигура:\n" + rect.ToString());
                    }

                    if (fType == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("*****Выбранная фигура - квадрат*****\n");
                        do
                        {
                            Console.Write("Введите длину: ");
                            if (Double.TryParse(Console.ReadLine(), out x))
                                break;
                            else
                            {
                                Console.WriteLine("Неверный ввод!");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("*****Выбранная фигура - квадрат*****\n");
                            }
                        } while (true);

                        Square square = new Square(x);
                        Console.WriteLine("Введённая фигура:\n" + square.ToString());

                    }

                    if (fType == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("*****Выбранная фигура - круг*****\n");
                        do
                        {
                            Console.Write("Введите радиус: ");
                            if (Double.TryParse(Console.ReadLine(), out x))
                                break;
                            else
                            {
                                Console.WriteLine("Неверный ввод!");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("*****Выбранная фигура - круг*****\n");
                            }
                        } while (true);

                        Circle circle = new Circle(x);
                        Console.WriteLine("Введённая фигура:\n" + circle.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод. Было введено не число или введённое число не относится ни к какой фигуре");
                    Console.WriteLine("Esc - выход, любая клавиша - продолжить");
                    if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                        break;
                    else
                        continue;
                }
                Console.WriteLine("Esc - выход, любая клавиша - продолжить");
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                    break;
            } while (true);

        }
    }
}
