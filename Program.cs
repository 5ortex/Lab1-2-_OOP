namespace Lab1_2__OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Перший трикутник");
            TTriangle triangle1 = new TTriangle();
            triangle1.Input();
            Console.WriteLine();
            Console.WriteLine("Другий трикутник");
            TTriangle triangle2 = new TTriangle();
            triangle2.Input();
            Console.WriteLine();
            if (triangle1.Equals(triangle2))
            {
                Console.WriteLine("Трикутники рівні.");
            }
            else
            {
                Console.WriteLine("Трикутники не рівні.");
            }
            Console.WriteLine();
            Console.WriteLine("Дані першого трикутника:");
            triangle1.Output();
            Console.WriteLine("Дані другого трикутника:");
            triangle2.Output();
            Console.WriteLine();
            Console.WriteLine($"Периметр = {triangle1.Perimeter()}");
            Console.WriteLine($"Площа = {triangle1.Square()}");
            Console.WriteLine($"Периметр = {triangle2.Perimeter()}");
            Console.WriteLine($"Площа = {triangle2.Square()}");
            Console.WriteLine();
            Console.WriteLine("перевірка оператора *");
            TTriangle triangle3 = triangle1 * 2;
            Console.WriteLine("Перший трикутник після множення сторін на 2:");
            triangle3.Output();
            Console.WriteLine("перевірка оператора *");
            TTriangle triangle4 = triangle2 * 2;
            Console.WriteLine("Другий трикутник після множення сторін на 2:");
            triangle4.Output();
            Console.WriteLine();
            Console.WriteLine("трикутна призма");
            TTrianglePrizm prizm = new TTrianglePrizm();
            prizm.Input();
            Console.WriteLine();
            Console.WriteLine("Дані призми:");
            prizm.Output();
            Console.WriteLine();
            Console.WriteLine($"Площа основи = {prizm.Square()}");
            Console.WriteLine($"Периметр основи = {prizm.Perimeter()}");
            Console.WriteLine($"Об'єм призми = {prizm.Volume()}");
            Console.ReadKey();
            TTriangle prizm1 = new TTrianglePrizm();
            prizm1.Equals(triangle1);
        }
    }
}
