using System;
using System.Collections.Generic;
using System.Text;

namespace CountriesMVC
{
    class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country Country)
        {
            DisplayCountry = Country;
        }

        public void Display()
        {
            Console.WriteLine($"Country name: {DisplayCountry.Name}");
            Console.WriteLine($"Country Colors: {DisplayCountry.Colors[0]}, {DisplayCountry.Colors[1]}");
            Console.WriteLine($"Continent: {DisplayCountry.Continent}");
        }
    }
}
