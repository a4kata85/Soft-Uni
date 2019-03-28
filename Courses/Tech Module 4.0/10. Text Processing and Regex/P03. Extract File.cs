using System;

namespace P03._Extract_File
{
    class StartUp
    {
        static void Main()
        {
            string path = Console.ReadLine();
            int startIndexOfFile = path.LastIndexOf('\\') + 1;
            string file = path.Substring(startIndexOfFile);

            int starIndexOfExtension = file.LastIndexOf('.') + 1;
            string nameOfFile = file.Substring(0, starIndexOfExtension - 1);
            string extensionOfFile = file.Substring(starIndexOfExtension);
            Console.WriteLine($"File name: {nameOfFile}");
            Console.WriteLine($"File extension: {extensionOfFile}");
        }
    }
}
