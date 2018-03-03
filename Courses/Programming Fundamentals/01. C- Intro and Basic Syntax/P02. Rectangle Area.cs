namespace P02_RectangleArea
{
    using System;

    class StartUp
    {
      public  static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = height * width;
            Console.WriteLine($"{area:f2}");
        }
    }
}
