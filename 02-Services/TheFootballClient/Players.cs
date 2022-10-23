using System.Collections.Specialized;
using System.Diagnostics;
using TheFootballClient.Logic;
using TheFootballClient.Models;

namespace TheFootballClient
{
    public class Players
    {
        public static void Generating()
        {
            var firstNames = new List<string>();
            var lastName = new List<string>();

            var counter = 0;
            var rowLimit = 1000;

            using (var firstNamesCSV = new StreamReader(@"Files\Imiona_Męskie.csv"))
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

            using (var lastNamesCSV = new StreamReader(@"Files\NAZWISKA_MĘSKIE.csv"))
            {
                while (counter <= rowLimit)
                {
                    var line = lastNamesCSV.ReadLine();
                    var values = line.Split(',');
                    lastName.Add(values[0]);
                    counter++;
                }
                lastName.RemoveAt(0);
                counter = 0;
            }

            var playersData = new List<Player>();

            var random = new Random();
            DateTime start = new DateTime(1985, 1, 1);
            DateTime end = new DateTime(2005, 12, 31);
            var range = (end - start).Days;

            var citiesDeserialized = new CitiesDeserialization().Deserialize();

            while (counter <= rowLimit)
            {
                var first = random.Next(0, firstNames.Count);
                var second = random.Next(0, lastName.Count);
                var year = start.AddDays(random.Next(range));
                var birthplace = citiesDeserialized[random.Next(0, citiesDeserialized.Count)];
                playersData.Add(new Player(firstNames[first] + " " + lastName[second], year, birthplace.Name));
                counter++;
            }
            counter = 0;
        }

    }
}