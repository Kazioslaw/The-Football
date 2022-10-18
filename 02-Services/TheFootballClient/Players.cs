using TheFootballClient.Models;

namespace TheFootballClient
{
    public class Players
    {
        static void Generating()
        {
            var firstNames = new List<string>();
            var secondNames = new List<string>();

            using (var firstNamesCSV = new StreamReader(@"\Files\Imiona_Męskie.csv"))
            {
                var counter1 = 0;
                var rows1 = 1000;
                while (counter1 <= rows1)
                {
                    var line = firstNamesCSV.ReadLine();
                    var values = line.Split(',');
                    firstNames.Add(values[0]);
                    counter1++;
                }
                firstNames.RemoveAt(0);
            }

            using (var secondNamesCSV = new StreamReader(@"\Files\NAZWISKA_MĘSKIE.csv"))
            {
                var counter2 = 0;
                var rows2 = 1000;
                while (counter2 <= rows2)
                {
                    var line = secondNamesCSV.ReadLine();
                    var values = line.Split(',');
                    firstNames.Add(values[0]);
                    counter2++;
                }
                secondNames.RemoveAt(0);
            }

            var playerName = new List<Player>();
            var random = new Random();
            DateTime start = new DateTime(1985, 1, 1);
            DateTime end = new DateTime(2005, 12, 31);
            var range = (end - start).Days;
            var cityDeserialized = new GenerationClubs();
            var counter3 = 0;
            var rows3 = 1000;

            while (counter3 <= rows3)
            {
                var first = random.Next(0, firstNames.Count + 1);
                var second = random.Next(0, secondNames.Count + 1);
                var year = start.AddDays(random.Next(range));
                playerName.Add(new Player(firstNames[first] + " " + secondNames[second], start.AddDays(random.Next(range))));
                counter3++;
            }
        }
    }
}
