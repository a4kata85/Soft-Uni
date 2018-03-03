using System;
class Program
{
    static void Main()
    {
        string word = Console.ReadLine();
        bool endword = word.EndsWith("y");
        bool endword2 = word.EndsWith("o") ||  word.EndsWith("s")|| word.EndsWith("x") || word.EndsWith("z")|| word.EndsWith("ch") || word.EndsWith("sh");
        if (endword)
        {
            int removeletter = word.Length - 1;
            word = word.Remove(removeletter, 1);
            Console.WriteLine($"{word}ies");
        }
        else if (endword2)
        {
            Console.WriteLine($"{word}es");
        }
        else
        {
            Console.WriteLine($"{word}s");
        }
    }
}
