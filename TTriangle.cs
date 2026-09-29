using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_2__OOP
{
    internal class TTriangle
    {
    protected double a, b, c; 
        public TTriangle()
        {
            a = 1;
            b = 1;
            c = 1;
        }
        public TTriangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public TTriangle(TTriangle triangle)
        {
            a = triangle.a;
            b = triangle.b;
            c = triangle.c;
        }
        public override string ToString()
        {
            return $"Сторони трикутника: a = {a}, b = {b}, c = {c}";
        }
        public virtual void Input()
        {
            do
            {
                Console.Write("Введіть сторону a: ");
                a = Convert.ToDouble(Console.ReadLine());
                if (a <= 0)
                    Console.WriteLine("Сторона повинна бути більше 0");
            } while (a <= 0);
            do
            {
                Console.Write("Введіть сторону b: ");
                b = Convert.ToDouble(Console.ReadLine());
                if (b <= 0)
                    Console.WriteLine("Сторона повинна бути більше 0");
            } while (b <= 0);
            do
            {
                Console.Write("Введіть сторону c: ");
                c = Convert.ToDouble(Console.ReadLine());
                if (c <= 0)
                    Console.WriteLine("Сторона повинна бути більше 0");
            } while (c <= 0);
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Трикутник з такими сторонами існує.");
            }
            else
            {
                Console.WriteLine("Трикутник з такими сторонами не існує.");
                Console.WriteLine("Встановлюються значення за замовчуванням.");
                a = 1;
                b = 1;
                c = 1;
            }
        }
        public virtual void Output()
        {
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");
        }
        public virtual double Perimeter()
        {
            return a + b + c;
        }
        public virtual double Square()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public bool Equals(TTriangle triangle)
        {
            double[] first = {a,b,c};
            double[] second = { triangle.a, triangle.b, triangle.c};
            for (int i = 0; i < first.Length - 1; i++)
            {
                for (int j = 0; j < first.Length - 1 - i; j++)
                {
                    if (first[j] > first[j + 1])
                    {
                        double temp = first[j];
                        first[j] = first[j + 1];
                        first[j + 1] = temp;
                    }
                    if (second[j] > second[j + 1])
                    {
                        double temp = second[j];
                        second[j] = second[j + 1];
                        second[j + 1] = temp;
                    }
                }
            }
            return first[0] == second[0] && first[1] == second[1] && first[2] == second[2];
        }
        public bool NotEquals(TTriangle triangle)
        {
            return !Equals(triangle);
        }
        public static TTriangle operator *(TTriangle triangle, double number)
        {
            return new TTriangle(triangle.a * number, triangle.b * number, triangle.c * number);
        }
        public static TTriangle operator *(double number, TTriangle triangle)
        {
            return triangle * number;
        }

    }
}
