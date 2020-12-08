using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day5;
using ChristmasUtils;
namespace Day5Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            BoardingPassList bL = new BoardingPassList("testdata.dat");

            Assert.AreEqual(820, bL.HighestId());

        }

        [TestMethod]
        public void verbose_example()
        {
            BoardingPass bp = new BoardingPass("FBFBBFFRLR");

            Assert.AreEqual(44, bp.row);
            Assert.AreEqual(5, bp.column);
            Assert.AreEqual(357, bp.id);
        }

        [TestMethod]
        public void boardingpass_test1()
        {

            BoardingPass bp = new BoardingPass("BFFFBBFRRR");

            Assert.AreEqual(70, bp.row);
            Assert.AreEqual(7, bp.column);
            Assert.AreEqual(567, bp.id);

        }

        [TestMethod]
        public void boardingpass_test2()
        {

            BoardingPass bp = new BoardingPass("FFFBBBFRRR");

            Assert.AreEqual(14, bp.row);
            Assert.AreEqual(7, bp.column);
            Assert.AreEqual(119, bp.id);

        }

        [TestMethod]
        public void boardingpass_test3()
        {

            BoardingPass bp = new BoardingPass("BBFFBBFRLL");

            Assert.AreEqual(102, bp.row);
            Assert.AreEqual(4, bp.column);
            Assert.AreEqual(820, bp.id);

        }

    }
}

