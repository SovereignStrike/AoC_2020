using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using Day1;


namespace Day1Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodTwoNumbers()
        {
            //create tempinputfile

            // Arrange
            List<string> testInput = new List<string>();
            testInput.Add("1721");
            testInput.Add("979");
            testInput.Add("366");
            testInput.Add("299");
            testInput.Add("675");
            testInput.Add("1456");
            Guid gUID = Guid.NewGuid();

            string testInputFilePath = Path.GetTempPath() + gUID + ".temp";
            StreamWriter sw = new StreamWriter(testInputFilePath);
            foreach (string val in testInput)
            { sw.WriteLine(val); }
            sw.Close();
            // Act

            int output;            
            Report rep = new Report(testInputFilePath);
            output = rep.Compute();
            // Assert

            Assert.AreEqual(514579, output);



        }
        [TestMethod]
        public void TestMethodThreeNumbers()
        {
            //create tempinputfile

            // Arrange?
            List<string> testInput = new List<string>();
            testInput.Add("1721");
            testInput.Add("979");
            testInput.Add("366");
            testInput.Add("299");
            testInput.Add("675");
            testInput.Add("1456");
            Guid gUID = Guid.NewGuid();
            string testInputFilePath = Path.GetTempPath() + gUID + ".temp";
            StreamWriter sw = new StreamWriter(testInputFilePath);
            foreach (string val in testInput)
            { sw.WriteLine(val); }
            sw.Close();
            // Act
            int output;

            Report rep = new Report(testInputFilePath);
            output = rep.ComputeTriple();
            // Assert

            Assert.AreEqual(241861950, output);



        }

    }
}
