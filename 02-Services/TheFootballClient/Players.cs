using TfcDomain.Models;
using TheFootballClient.Logic;

namespace TheFootballClient
{
    public class Players
    {
        public List<Player> Generating(string firstCSV = @"Files\Imiona_Męskie.csv", string lastCSV = @"Files\NAZWISKA_MĘSKIE.csv")
        {
            var firstNames = new List<string>();
            var lastNames = new List<string>();

            var counter = 0;
            var rowLimit = 1000;

            using (var firstNamesCSV = new StreamReader(firstCSV))
            {
                while (counter <= rowLimit)
                {
                    var line = firstNamesCSV.ReadLine();
                    var values = line.Split(',');
                    firstNames.Add(values[0]);
                    counter++;
                }
                firstNames.RemoveAt(0);
                counter = 0;

            }

            using (var lastNamesCSV = new StreamReader(lastCSV))
            {
                while (counter <= rowLimit)
                {
                    var line = lastNamesCSV.ReadLine();
                    var values = line.Split(',');
                    lastNames.Add(values[0]);
                    counter++;
                }
                lastNames.RemoveAt(0);
                counter = 0;
            }

            var playersData = new List<Player>();

            var random = new Random();
            DateTime start = new DateTime(1985, 1, 1);
            DateTime end = new DateTime(2005, 12, 31);
            var range = (end - start).Days;

            var citiesDeserialized = new CitiesDeserialization().Deserialize(@"Files\cities.json");

            while (counter <= rowLimit)
            {
                var first = random.Next(0, firstNames.Count);
                var second = random.Next(0, lastNames.Count);
                var year = start.AddDays(random.Next(range));
                var birthplace = citiesDeserialized[random.Next(0, citiesDeserialized.Count)];
                playersData.Add(new Player(firstNames[first] + " " + lastNames[second], year, birthplace.Name));
                counter++;
            }
            counter = 0;
            return playersData;
        }
    }
}