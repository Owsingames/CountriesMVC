using System;
using System.Collections.Generic;
using System.Text;

namespace CountriesMVC
{
    public enum Continent
    {
        NorthAmerica,
        SouthAmerica,
        Europe,
        Asia,
        Africa,
        Australia,
        Antartica
    }
    class Country
    {
        public string Name { get; set; }
        public Continent Continent { get; set; }
        public List<string> Colors { get; set; }

        public Country(string Name, Continent Continent, List<string> Colors)
        {
            this.Name = Name;
            this.Continent = Continent;
            this.Colors = Colors;
        }
    }
}
