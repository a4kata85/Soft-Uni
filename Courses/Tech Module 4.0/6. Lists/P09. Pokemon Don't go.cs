using System;
using System.Collections.Generic;
using System.Linq;

namespace P09._PokemonDontGo
{
    class StartUp
    {
        static void Main()
        {
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            int removedElement = -1;

            while (true)
            {
                if (inputList.Count == 0)
                {
                    break;
                }

                int currentIndex = int.Parse(Console.ReadLine());
                if (currentIndex < 0)
                {
                    removedElement = inputList[0];
                    inputList.RemoveAt(0);
                    inputList.Insert(0, inputList[inputList.Count - 1]);
                    UpdateList(inputList, removedElement);
                }
                else if (currentIndex > inputList.Count-1)
                {
                    removedElement = inputList[inputList.Count-1];
                    inputList.RemoveAt(inputList.Count-1);
                    inputList.Add(inputList[0]);
                    UpdateList(inputList, removedElement);
                }
                else
                {
                    removedElement = inputList[currentIndex];
                    inputList.RemoveAt(currentIndex);
                    UpdateList(inputList, removedElement);
                }
                sum += removedElement;
            }
            Console.WriteLine(sum);
        }     

        public static void UpdateList(List<int> someList, int removedElem)
        {
             for (int i = 0; i < someList.Count; i++)
                    {
                        if (someList[i] > removedElem)
                        {
                            someList[i] -= removedElem;
                        }
                        else
                        {
                            someList[i] += removedElem;
                        }
                    }
        }
    }
}
