using System.Diagnostics;
using System.Text.Json;

namespace TheFootballClient
{
    public class GenerationClubs
    {
        static void Generator()
        {
            var jsonCity = File.ReadAllText(@"Files\cities.json");
            var cityJson = JsonSerializer.Deserialize<List<Cities>>(jsonCity);
            List<string> cities = new List<string>();

            foreach (var c in cityJson)
            {
                cities.Add($"KS {c.name}");
            }

        }

    }
}
