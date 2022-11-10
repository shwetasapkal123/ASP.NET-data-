using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
using System;

namespace TestMoodAnalyzer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMsgReturnHappy()
        {
            //Arrange
            string msg = "I am in sad Mood";
            string expected = "sad";
            //Act
            AnalyzeMood analyzeMood = new AnalyzeMood(msg);
            var actual = analyzeMood.Mood();
            //Assert
            Assert.AreEqual(expected,actual);
            Console.WriteLine(actual);  
        }
    }
}
