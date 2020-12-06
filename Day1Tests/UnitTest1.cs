using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using Day1;
using ChristmasUtils;


namespace Day1Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodTwoNumbers()
        {
                        // Arrange
            List<string> testInput = new List<string>();
            testInput.Add("1721");
            testInput.Add("979");
            testInput.Add("366");
            testInput.Add("299");
            testInput.Add("675");
            testInput.Add("1456");
            int output;  
            
            // Act
                               
            Report rep = new Report(FileUtils.CreateTempFileFromList(testInput));
            output = rep.Compute();
            // Assert

            Assert.AreEqual(514579, output);

        }
        [TestMethod]
        public void TestMethodThreeNumbers()
        {
            
int output;
            // Arrange?
            List<string> testInput = new List<string>();
            testInput.Add("1721");
            testInput.Add("979");
            testInput.Add("366");
            testInput.Add("299");
            testInput.Add("675");
            testInput.Add("1456");
            
            // Act
            

            Report rep = new Report(FileUtils.CreateTempFileFromList(testInput));
            output = rep.ComputeTriple();
            // Assert

            Assert.AreEqual(241861950, output);



        }

    }
}
