using System;
using System.Collections.Generic;
using System.Text;

namespace CountriesMVC
{
    class CountryController
    {
        public List<Country> CountryDB { get; set; } = new List<Country>();
        
        public CountryController()
        {
            //usa
            List<string> usaColors = new List<string>() { "red", "blue", "white" };
            CountryDB.Add(new Country("United States", Continent.NorthAmerica, usaColors));

            //canada
            List<string> canadaColors = new List<string>() { "red", "white" };
            CountryDB.Add(new Country("Canada", Continent.NorthAmerica, canadaColors));

            //mexico
            List<string> mexicoColors = new List<string>() { "green", "white", "red" };
            CountryDB.Add(new Country("Mexico", Continent.NorthAmerica, mexicoColors));

            //england
            List<string> englandColors = new List<string>() { "red", "white", "blue" };
            CountryDB.Add(new Country("England", Continent.Europe, englandColors));

            //fance
            List<string> frenchColors = new List<string>() { "blue", "white", "blue" };
            CountryDB.Add(new Country("France", Continent.Europe, frenchColors));

            //germany
            List<string> germanycolors = new List<string>() { "black", "red", "gold" };
            CountryDB.Add(new Country("Germany", Continent.Europe, germanycolors));

            //egypt
            List<string> egyptColors = new List<string>() { "red", "white", "black" };
            CountryDB.Add(new Country("Egypt", Continent.Africa, egyptColors));

            //kenya
            List<string> kenyaColors = new List<string>() { "black", "red", "green" };
            CountryDB.Add(new Country("Kenya", Continent.Africa, kenyaColors));

            //brazil
            List<string> brazilianColors = new List<string>() { "green", "yellow", "blue" };
            CountryDB.Add(new Country("Brazil", Continent.SouthAmerica, brazilianColors));

            //japan
            List<string> japanColors = new List<string>() { "red", "white"};
            CountryDB.Add(new Country("Japan", Continent.Asia, japanColors));

            //china
            List<string> chinaColors = new List<string>() { "red", "yellow" };
            CountryDB.Add(new Country("China", Continent.Asia, chinaColors));
        }

        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }

        public void WelcomeAction()
        {
            Console.WriteLine("Hello, welcome to the country app. \n");
            CountryListView cv = new CountryListView(CountryDB);
            cv.Display();

            Console.WriteLine();
            Console.WriteLine("Please select a country from the following list:");

            bool rightIndex = true;
            while (rightIndex == true)
            {
                int index;
                int.TryParse(Console.ReadLine().Trim(), out index);
                if (index <= CountryDB.Count && index >= 0)
                {
                   Country pick = CountryDB[index];
                    CountryAction(pick);
                    rightIndex = false;
                }
                else
                {
                    Console.WriteLine("I'm sorry, that number is not on the list");
                    Console.WriteLine("Please select a country by index.");

                }
            }
        }


    }
}
