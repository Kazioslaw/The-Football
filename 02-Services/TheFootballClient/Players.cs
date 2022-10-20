using TheFootballClient.Models;

namespace TheFootballClient
{
    public class Players
    {
        static void Generating()
        {
            var firstNames = new List<string>();
            var lastName = new List<string>();

            using (var firstNamesCSV = new StreamReader(@"\Files\Imiona_Męskie.csv"))
            {
                var firstCounter= 0;
                var firstRows = 1000;
                while (firstCounter <= firstRows)
                {
                    var line = firstNamesCSV.ReadLine();
                    var values = line.Split(',');
                    firstNames.Add(values[0]);
                    firstCounter++;
                }
                firstNames.RemoveAt(0);
            }

            using (var lastNamesCSV = new StreamReader(@"\Files\NAZWISKA_MĘSKIE.csv"))
            {
                var secondCounter = 0;
                var secondRows = 1000;
                while (secondCounter <= secondRows)
                {
                    var line = lastNamesCSV.ReadLine();
                    var values = line.Split(',');
                    firstNames.Add(values[0]);
                    secondCounter++;
                }
                lastName.RemoveAt(0);
            }

            var playersData = new List<Player>();
            
            var random = new Random();
            DateTime start = new DateTime(1985, 1, 1);
            DateTime end = new DateTime(2005, 12, 31);
            var range = (end - start).Days;
            
            //var cityDeserialized = new GenerationClubs();
            var thirdCounter = 0;
            var thirdRows = 1000;

            while (thirdCounter <= thirdRows)
            {
                var first = random.Next(0, firstNames.Count + 1);
                var second = random.Next(0, lastName.Count + 1);
                var year = start.AddDays(random.Next(range));
                playersData.Add(new Player(firstNames[first] + " " + lastName[second], start.AddDays(random.Next(range))));
                thirdCounter++;
            }
        }
    }
}