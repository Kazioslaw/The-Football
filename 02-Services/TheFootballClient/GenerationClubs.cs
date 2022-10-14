using Microsoft.AspNetCore.Mvc.Diagnostics;
using System.Diagnostics;
using System.Text.Json;

namespace TheFootballClient
{
    public class GenerationClubs
    {
        static void Generator()
        {
            // Retrives and deserialize data from file 
            var citiesFile = File.ReadAllText(@"Files\cities.json");
            var cityDeserialized = JsonSerializer.Deserialize<List<Cities>>(citiesFile);

            Random year = new Random();
            DateTime start = new DateTime(1900, 1, 1);
            DateTime end = new DateTime(2020, 12, 31);
            int range = (end - start).Days;

            var clubs = new List<string>();
            var cityYear = new List<string>();

            // Adding to list
            for (int i = 0; i < cityDeserialized.Count; i++)
            {
                DateTime founded = start.AddDays(year.Next(range));
                clubs.Add($"Club Name: KS {cityDeserialized[i]}");
                cityYear.Add($"Founded: {founded}");
            }

        }

    }
}
