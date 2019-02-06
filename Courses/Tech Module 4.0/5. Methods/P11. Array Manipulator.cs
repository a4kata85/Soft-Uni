using System;
using System.Linq;

namespace P11._Array_Manipulator
{
    class StartUp
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                string[] tokens = line.Split();
                string command = tokens[0];

                if (command == "exchange")
                {
                    int index = int.Parse(tokens[1]);
                    if (index > array.Length-1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    Exchange(array, index);
                }

                else if (command == "max")
                {
                    string typeNumber = tokens[1];
                    int index = -1;
                    if (typeNumber == "odd")
                    {
                        index = GetMaxEvenOrOddIndez(array, 1);
                    }
                    else
                    {
                        index = GetMaxEvenOrOddIndez(array, 0);

                    }
                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                        continue;
                    }
                    Console.WriteLine(index);
                }
                else if (command == "min")
                {
                    string typeNumber = tokens[1];
                    int index = -1;
                    if (typeNumber == "odd")
                    {
                        index = GetMinEvenOrOddIndez(array, 1);
                    }
                    else
                    {
                        index = GetMinEvenOrOddIndez(array, 0);

                    }
                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                        continue;
                    }
                    Console.WriteLine(index);
                }
                else if (command == "first")
                {
                    int count = int.Parse(tokens[1]);
                    if (count > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    string typeNumber = tokens[2];
                    int[] result = new int[0];
                    if (typeNumber == "odd")
                    {
                        result = GetFirstCountEvenOrOddNumbers(array, count, 1);
                    }
                    else
                    {
                        result = GetFirstCountEvenOrOddNumbers(array, count, 0);
                    }
                    Console.WriteLine("[" + string.Join(", ", result) + "]");
                }
                else if (command == "last")
                {
                    int count = int.Parse(tokens[1]);
                    if (count > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    string typeNumber = tokens[2];
                    int[] result = new int[0];
                    if (typeNumber == "odd")
                    {
                        result = GetLastCountEvenOrOddNumbers(array, count, 1);
                    }
                    else
                    {
                        result = GetLastCountEvenOrOddNumbers(array, count, 0);
                    }
                    Console.WriteLine("["+ string.Join(", ", result)+ "]");
                }
            }
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        private static int[] GetLastCountEvenOrOddNumbers(int[] array, int count, int divisionResult)
        {
            int[] arrResult = new int[count];
            int currentCount = 0;
            for (int i = array.Length-1; i >= 0; i--)
            {
                if (array[i] % 2 == divisionResult && currentCount < count)
                {
                    arrResult[currentCount] = array[i];
                    currentCount++;
                }
            }
            if (currentCount >= count)
            {
                return arrResult.Reverse().ToArray();
            }
            else
            {
                int[] temp = new int[currentCount];
                Array.Copy(arrResult, temp, currentCount);
                return temp.Reverse().ToArray();
            }
        }

        private static int[] GetFirstCountEvenOrOddNumbers(int[] array, int count, int divisionResult)
        {
            int[] arrResult = new int[count];
            int currentCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] %2 == divisionResult && currentCount < count)
                {
                    arrResult[currentCount] = array[i];
                    currentCount++;
                }
            }
            if (currentCount >= count)
            {
                return arrResult;
            }
            else
            {
                int[] temp = new int[currentCount];
                Array.Copy(arrResult, temp, currentCount);
                return temp;
            }
        }

        private static int GetMinEvenOrOddIndez(int[] array, int v)
        {
            int minNumber = int.MaxValue;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= minNumber && array[i] % 2 == v)
                {
                    minNumber = array[i];
                    index = i;
                }
            }
            return index;
        }

        private static int GetMaxEvenOrOddIndez(int[] array, int divisionResult)
        {
            int maxNumber = int.MinValue;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= maxNumber && array[i] % 2 == divisionResult)
                {
                    maxNumber = array[i];
                    index = i;
                }
            }
            return index;
        }

        private static void Exchange(int[] array, int index)
        {
            for (int i = 0; i < index+1; i++)
            {
                int firstNumber = array[0];
                for (int j = 0; j < array.Length-1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Length - 1] = firstNumber;
            }
        }
    }
}
