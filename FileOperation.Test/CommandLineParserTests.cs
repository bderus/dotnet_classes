using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FileOperation.Test
{
    [TestClass]
    public class CommandLineParserTests
    {
        [TestMethod]
        public void ArgParserShouldReturnCorrectListOfStrings()
        {
            //Arrange
            var expectedList = new List<string>();
            var expectedFirstParsedString = "C:\\Users\\piotr\\OneDrive\\Pulpit\\abc.txt";
            var expectedSecondParsedString = "C:\\Users\\piotr\\OneDrive\\Pulpit\\RA.txt";
            expectedList.Add(expectedFirstParsedString);
            expectedList.Add(expectedSecondParsedString);

            //Act
            var args = new string[] {"/FileName=C:\\Users\\piotr\\OneDrive\\Pulpit\\abc.txt", "/DestFileName=C:\\Users\\piotr\\OneDrive\\Pulpit\\RA.txt"};
            var parser = new CommandLineParser();
            var list = parser.ArgumentParser(args);

            //Assert
            Assert.AreEqual(expectedList[0],list[0]);
            Assert.AreEqual(expectedList[1], list[1]);
        }
    }
}
