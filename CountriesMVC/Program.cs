using System;

namespace CountriesMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            bool onContinue = true;
            while (onContinue == true)
            {
                CountryController controler = new CountryController();
                controler.WelcomeAction();
                onContinue = PickAgain();
            }
        }

        public static bool PickAgain()
        {
            Console.WriteLine("Would you like to pick another country? (y/n)");
            string input = Console.ReadLine().ToLower().Trim();

            if(input == "y" || input == "yes")
            {
                Console.Clear();
                return true;
            }
            else if (input == "n" || input == "no")
            {
                Console.WriteLine("Goodbye.");
                return false;
            }
            else
            {
                return PickAgain();
            }
        }
    }
}
