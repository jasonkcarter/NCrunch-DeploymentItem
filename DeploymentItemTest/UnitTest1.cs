using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeploymentItemTest
{
    [TestClass]
    [DeploymentItem(@"SubFolder\TextFile1.txt")]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            const string expectedContents = "Contents";

            // Act
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"TextFile1.txt");
            string actualContents = File.ReadAllText(filePath);

            // Assert
            Assert.AreEqual(expectedContents, actualContents);
        }
    }
}