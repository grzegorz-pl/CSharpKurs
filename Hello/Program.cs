using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();

            for (; ; )
            {
                Greeting();
                Age();
                Settings();
            }

        }
        /// <summary>
        /// Wypisuje wielkość typów zmiennych
        /// </summary>
        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
           long maxLong = long.MaxValue;
           long minLong = long.MinValue;

            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("minInt = " + minInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + minLong);
        }

        /// <summary>
        /// Ustawiania
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        /// <summary>
        /// Wypisujemy komunikat o wieku
        /// </summary>
        private static void Age()
        {
            Console.WriteLine("Podaj ile masz lat");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);
            if (age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Jesteś pełnoletni mozesz wypic browara");
            }
            else if (result == false)
            {
                Console.WriteLine("Nie własciwy wiek");
            }
            else
            {
                Console.WriteLine("Możemy zaoferowć mleko");
            }
        }
        /// <summary>
        /// Wypisujemy powitanie uzytkownika
        /// </summary>
        private static void Greeting()
        {
            Console.WriteLine("Wpisz swoje imie");
            string name = Console.ReadLine();

            Console.WriteLine("Witaj, " + name);
        }
    }
    
    
}
