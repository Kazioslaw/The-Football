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
    public class GenerationClubsTest
    {
        [TestMethod]
        public void Generator_ValidClubGeneration_ClubsCountAbove0()
        {
            //Arrange
            var generate = new GenerationClubs();
            List<Club> testClubList = new List<Club>();
            var testCountNumber = 0;

            //Act
            testClubList = generate.Generator();

            //Assert
            Assert.AreNotEqual(testClubList.Count, testCountNumber);
        }
    }
}
