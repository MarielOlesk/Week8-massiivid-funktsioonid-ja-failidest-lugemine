using System;
using System.IO;

namespace ChuckNorris
{
    class Program
    {
        //Programm kuvab konsoolis juhuslikku nalja Chuck Norris'i kohta failist chuck.txt.

        static void Main(string[] args)
        {
            string randomJoke;

            randomJoke = GetRandomFromFile("chuck.txt");

            Console.WriteLine($"Random Chuck Norris joke is {randomJoke}");
        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static string GetRandomFromFile(string fileName)
        {
            string filePath = $@"D:\visual_studio_failid\{fileName}";
            string[] dataFromFile = File.ReadAllLines(filePath);

            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];
            return randomElement;
        }
    }
}
