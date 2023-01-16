using System.Text.Json;
using TheFootballClient.JsonModels;
using TheFootballClient.Logic;

namespace TheFootballClientTests
{
    [TestClass]
    public class CitiesDeserializationTest
    {
        [TestMethod]
        public void Deserialize_ValidPathToJson_CitiesCountAbove0()
        {
            //Arrange
            string startupPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\"));
            var testFileLocation = startupPath + @"Files\cities.json";
            var deserialization = new CitiesDeserialization();
            List<City> testCityList = new List<City>();
            var testCountNumber = 0;

            //Act
            testCityList = deserialization.Deserialize(testFileLocation);


            //Assert
            Assert.AreNotEqual(testCityList.Count, testCountNumber);

        }
        [TestMethod]
        public void Deserialize_EmptyJsonFile_ThrowsJsonException()
        {
            //Arrange
            string startupPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\"));
            var testFileLocation = startupPath + @"Files\testList.json";
            var deserialization = new CitiesDeserialization();
            List<City> testCityList = new List<City>();
            
            //Act

            //Assert
            Assert.ThrowsException<JsonException>(() => deserialization.Deserialize(testFileLocation));

        }
    }
}