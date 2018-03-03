namespace P12.RectangleProperties
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimeter = 2 * width + 2 * height;
            double area = width * height;
            double diagonal = Math.Sqrt(width * width + height * height);

            Console.WriteLine("{0}", perimeter);
            Console.WriteLine("{0}", area);
            Console.WriteLine("{0}", diagonal);

        }
    }
}
