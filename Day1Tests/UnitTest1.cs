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
        public void TestMethod1()
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
            Guid gUID = new Guid();
            string testInputFilePath = Path.GetTempPath() + gUID + ".temp";
            StreamWriter sw = new StreamWriter(testInputFilePath);
            foreach (string val in testInput)
            { sw.WriteLine(val); }
            sw.Close();
            // Act?

            int output;
            output = 1;

            
                Report rep = new Report(testInputFilePath);
            output = rep.Compute();
            // Assert?

            Assert.AreEqual(514579, output);



        }

    }
}
