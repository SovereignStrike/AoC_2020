using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day8;
namespace Day8Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Boot boo = new Boot("testinput.dat");
            boo.Run();
            Assert.AreEqual(5, boo.state.accumulator);

        }
    }
}
