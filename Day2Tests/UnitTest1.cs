using ChristmasUtils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Day2;

namespace Day2Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PassWorlistTest()
        {
            
            List<string> testInput = new List<string>();
            testInput.Add("1-3 a: abcde");
            testInput.Add("1-3 b: cdefg");
            testInput.Add("2-9 c: ccccccccc");
            // Act


            PasswordList pL = new PasswordList(FileUtils.CreateTempFileFromList(testInput));

            Assert.AreEqual(2, pL.ValidPasswordsCount());
        }
    }
}
