using System;
using System.IO;

namespace PickRandomFromFile
{
    class Program
    {
        //Loo uus kaust.
        //Laadi alla kaheksanda nädala failid ja pane need failid kausta.
        //Projektikoodis:
        //Vali juhuslkikku jooki ja juhuslikku filmi failidest drinks.txt ja movies.txt.Salvesta need väärtused muutujatesse randomDrink ja randomMovie.
        //Kuva need valikud lausega: 
        //Console.WriteLine($"Tonight you will have some {randomFood} with {randomDrink} and watch {randomMovie}")


        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;

            randomFood = GetRandomFromFile("foods.txt");
            randomDrink = GetRandomFromFile("drinks.txt");
            randomMovie = GetRandomFromFile("movies.txt");

            Console.WriteLine($"Tonight you will have some {randomFood} with {randomDrink} and watch {randomMovie}");
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
