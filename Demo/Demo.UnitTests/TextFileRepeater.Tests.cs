using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo.Lib;

namespace Demo.UnitTests
{
    [TestClass]
    public class TextFileRepeater_Tests
    {
        [TestMethod]
        public void ZeroRepetitions()
        {
            // Arrange 
            var lines = new string[] { "Line1", "Line2", "Line3" };

            // Act
            var result = TextFileRepeater.RepeatLines(lines, 0);

            // Assert
            Assert.AreEqual(0, result.Count);
        }


        [TestMethod]
        public void OneRepetitions()
        {
            // Arrange 
            var lines = new string[] { "Line1", "Line2", "Line3" };

            // Act
            var result = TextFileRepeater.RepeatLines(lines, 1);

            // Assert
            Assert.AreEqual(3, result.Count);
        }


        [TestMethod]
        public void TenRepetitions()
        {
            // Arrange 
            var lines = new string[] { "Line1", "Line2", "Line3" };

            // Act
            var result = TextFileRepeater.RepeatLines(lines, 10);

            // Assert
            Assert.AreEqual(30, result.Count);
        }
    }
}
