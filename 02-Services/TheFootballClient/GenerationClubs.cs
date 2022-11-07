using TfcDomain.Models;
using TheFootballClient.Logic;

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
            var random = new Random();
            DateTime start = new DateTime(1900, 1, 1);
            DateTime end = new DateTime(2020, 12, 31);
            int range = (end - start).Days;

            var clubs = new List<Club>();

            var citiesDeserialized = new CitiesDeserialization().Deserialize(@"Files\cities.json");

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