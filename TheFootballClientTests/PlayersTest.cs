using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            List<Player> players = new List<Player>();
            var playersGenerator = new Players();
            var firstNameCSV = "";
            var secondNameCSV = "";
            var testCountNumber = 0;

            //Act
            players = playersGenerator.Generating(firstNameCSV, secondNameCSV);

            //Assert
            Assert.AreNotEqual(players.Count, testCountNumber);
        }
    }
}
