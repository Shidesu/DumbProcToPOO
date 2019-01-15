using System;

namespace HawkExo1
{
    internal class Program
    {

        public struct Cat
        {
            public string name;
            public int age;
            public string favoriteFood;
        }
        
        public struct Dog
        {
            public string name;
            public int age;
            public string favoriteFood;
        }
        
        public static void Main(string[] args)
        {
            Cat cat = InitializeCat("test", 17, "pâté");
            Dog dog = InitializeDog("doggy", 28, "croquettes");
            PrintCatData(cat);
            PrintDogData(dog);
        }

        public static Cat InitializeCat(string name, int age, string favoriteFood)
        {
            Cat cat = new Cat();
         
            cat.name = name;
            cat.age = age;
            cat.favoriteFood = favoriteFood;

            return cat;
        }

        public static void PrintCatData(Cat cat)
        {
            string catData = String.Format("Le chat se nomme {0}, a {1} ans, et aime l'aliment suivant : {2}.", cat.name, cat.age,
                cat.favoriteFood);
            Console.WriteLine(catData);
        }
        public static Dog InitializeDog(string name, int age, string favoriteFood)
        {
            Dog dog = new Dog();
         
            dog.name = name;
            dog.age = age;
            dog.favoriteFood = favoriteFood;

            return dog;
        }

        public static void PrintDogData(Dog dog)
        {
            string dogData = String.Format("Le chat se nomme {0}, a {1} ans, et aime l'aliment suivant : {2}.", dog.name, dog.age,
                dog.favoriteFood);
            Console.WriteLine(dogData);
        }
        
        
        
    }
}