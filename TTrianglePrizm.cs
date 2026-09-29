using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_2__OOP
{
    internal class TTrianglePrizm : TTriangle
    {
        private double height;
        public TTrianglePrizm() : base()
        {
            height = 1;
        }
        public TTrianglePrizm(double a, double b, double c, double height) : base(a, b, c)
        {
            this.height = height;
        }
        public TTrianglePrizm(TTrianglePrizm prizm) : base(prizm)
        {
            height = prizm.height;
        }
        public override string ToString()
        {
            return $"Призма: a = {a}, b = {b}, c = {c}, h = {height}";
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Введіть висоту призми: ");
            height = Convert.ToDouble(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Висота призми = {height}");
        }
        public double Volume()
        {
            return Square() * height;
        }
        public override double Square()
        {
            return base.Square();
        }
        public override double Perimeter()
        {
            return base.Perimeter();
        }
    }
}
