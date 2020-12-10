using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day7;
namespace Day7Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RuleCleanTest()
        {
            Rule r = new Rule("light red bags contain 1 bright white bag, 2 muted yellow bags.");

            Assert.AreEqual("light red:1 bright white;2 muted yellow", r.cleanedRule);
        }

        [TestMethod]
        public void RuleCleanTestNoOther()
        {
            Rule r = new Rule("faded blue bags contain no other bags.");

            Assert.AreEqual("faded blue:", r.cleanedRule);
        }

        [TestMethod]
        public void RuleCleanTestJustOneBag()
        {
            Rule r = new Rule("bright white bags contain 1 shiny gold bag.");

            Assert.AreEqual("bright white:1 shiny gold;", r.cleanedRule);
        }


        [TestMethod]
        public void fullinputtest()
        {
            Rules r = new Rules("testinput.dat");

            Assert.AreEqual(4, r.CountGoldenBags());
        }

        [TestMethod]
        public void fullinputcounttest()
        {
            Rules r = new Rules("testinput.dat");

            Assert.AreEqual(32, r.CountBagsInBag("shiny gold"));
        }
    }
}
