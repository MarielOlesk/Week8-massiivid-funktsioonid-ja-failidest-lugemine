using System;

namespace FridayNightRandomReturn
{
    class Program
    {
        //Kasuta PickRandomElementFromArray() funktsiooni, et valida juhuslikku filmi massivist movies (massiivi movies loo ja täida ise).
        //Salvesta valikut randomMovie muutujasse ja kuva seda käsuga:
        //Console.WriteLine($"Tonight you will have some {randomFood} with {randomDrink} and watch {randomMovie}");
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
            string[] drinks = { "apple juice", "coke", "fanta", "sprite" };
            string[] movies = { "Matrix", "Spider-Man", "Venom", "Fight-Club", "Batman" };

            randomFood =  PickRandomElementFromArray(foods);
            randomDrink =  PickRandomElementFromArray(drinks);
            randomMovie =  PickRandomElementFromArray(movies);

            Console.WriteLine($"Tonight you will have some {randomFood} with {randomDrink} and watch {randomMovie}");
        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static string PickRandomElementFromArray(string[] someArray)
        {
            string randomElement = someArray[GenerateRandomIndex(someArray)];
            return randomElement;
        }
    }
}
