using System.Text.Json;
using TheFootballClient.JsonModels;

namespace TheFootballClient.Logic
{
    public class CitiesDeserialization
    {
        public List<City> Deserialize(string citiesFileLocation)
        {
            //var citiesFile = File.ReadAllText(@"Files\cities.json");
            var citiesDeserialized = JsonSerializer.Deserialize<List<City>>(citiesFileLocation);
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
