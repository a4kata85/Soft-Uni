using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class StartUp
    {
        static void Main()
        {
            string[] firstLine = Console.ReadLine().Split(' ').ToArray();
            string[] secondLine = Console.ReadLine().Split(' ').ToArray();

            int firstLenght = firstLine.Length;
            int secondLenght = secondLine.Length;

            int smallerLenght = Math.Min(firstLenght, secondLenght);

            int leftCounter = 0;
            int rightCounter = 0;

            for (int i = 0; i < smallerLenght; i++)
            {
                if (firstLine[i] == secondLine[i])
                {
                    leftCounter++;
                }
                else
                {
                    break;
                }
            }

            string[] reversedFirstLine = firstLine.Reverse().ToArray();
            string[] reversedSecondLine = secondLine.Reverse().ToArray();

            for (int i = 0; i < smallerLenght; i++)
            {
                if (reversedFirstLine[i] == reversedSecondLine[i])
                {
                    rightCounter++;
                }
                else
                {
                    break;
                }
            }

            if (leftCounter >= rightCounter)
            {
                Console.WriteLine(leftCounter);

            }
            else
            {
                Console.WriteLine(rightCounter);
            }
        }
    }
}
