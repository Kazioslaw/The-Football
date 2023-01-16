using System.Text.Json;
using TheFootballClient.JsonModels;

namespace TheFootballClient.Logic
{
    public class CitiesDeserialization
    {
        public List<City> Deserialize(string citiesFileLocation = @"Files\cities.json")
        {
            var citiesFile = File.ReadAllText(citiesFileLocation);
            var citiesDeserialized = JsonSerializer.Deserialize<List<City>>(citiesFile);
            if (citiesDeserialized != null)
            {
                return citiesDeserialized;
            }
            else
            {
                return null;
            }
        }

    }
}
