using TfcDomain.Models;
using TheFootballClient;

namespace TheFootballClientTests
{
    [TestClass]
    public class PlayersTest
    {
        [TestMethod]
        public void Generator_ValidCSVLocation_NamesCountAbove0()
        {
            //Arrange
            string startupPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\"));
            List<Player> players = new List<Player>();
            var playersGenerator = new Players();
            var firstNameCSV = startupPath + @"Files\Imiona_Męskie.csv";
            var secondNameCSV = startupPath + @"Files\Nazwiska_Męskie.csv";
            var testCountNumber = 0;

            //Act
            players = playersGenerator.Generating(firstNameCSV, secondNameCSV);

            //Assert
            Assert.AreNotEqual(players.Count, testCountNumber);
        }
    }
}
