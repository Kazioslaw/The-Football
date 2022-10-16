using System.Text.Json;
using TheFootballClient.JsonModels;
using TheFootballClient.Models;

namespace TheFootballClient
{
    public class GenerationClubs
    {
        /// <summary>
        /// Deserializalization from json file
        /// and generation club names with club foundation date
        /// </summary>
        public static void Generator()
        {
            var citiesFile = File.ReadAllText(@"Files\cities.json");
            var citiesDeserialized = JsonSerializer.Deserialize<List<City>>(citiesFile);

            var random = new Random();
            DateTime start = new DateTime(1900, 1, 1);
            DateTime end = new DateTime(2020, 12, 31);
            int range = (end - start).Days;

            var clubs = new List<Club>();

            if (citiesDeserialized != null)
            {
                foreach (var city in citiesDeserialized)
                {                    
                    if (city.Name != null && city.Name.Length > 1)
                    {                        
                        DateTime founded = start.AddDays(random.Next(range));
                        clubs.Add(new Club($"KS {city.Name}", founded));
                    }
                }
            }
        }
    }
}
