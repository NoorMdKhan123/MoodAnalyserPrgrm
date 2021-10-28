using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodApp;

namespace MoodAppMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MoodAnalyserTest()
        {
            //Arrange
            string message = "I am in Sad mood";
            string except = "SAD";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);


            //Act
            var mood = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual(except, mood);

        }
    }
}
