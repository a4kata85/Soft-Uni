using System;

namespace _01._Ages
{
    class Ages
    {
        static void Main(string[] args)
        {
            int ages = int.Parse(Console.ReadLine());

            if (ages <= 2)
            {
                Console.WriteLine("baby");
            }
            else if (ages>2 && ages <14)
            {
                Console.WriteLine("child");
            }
            else if (ages > 13 && ages < 20)
            {
                Console.WriteLine("teenager");
            }
            else if (ages >=20 && ages < 66)
            {
                Console.WriteLine("adult");
            }
            else if (ages >= 66)
            {
                Console.WriteLine("elder");
            }
        
        }
    }
}
