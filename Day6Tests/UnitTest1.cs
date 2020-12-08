using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day6;
using ChristmasUtils;
namespace Day6Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
          

                QuestionnaireList bL = new QuestionnaireList("testdata.dat");

                Assert.AreEqual(11, bL.PositiveAnswers());

            
        }
    }
}
