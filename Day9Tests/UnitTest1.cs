using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day9;
namespace Day9Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Preamble5WeaknessFinder()


        {
            int preamble_length = 5;
            Finder fin = new Finder("testinput.dat", preamble_length);
            Assert.AreEqual(127, fin.FindWeakness());

        }

        [TestMethod]
        public void Preamble5Series()


        {
            int preamble_length = 5;

            Finder fin = new Finder("testinput.dat", preamble_length);
            System.Collections.Generic.List<long> output_list = fin.FindContiguous(fin.FindWeakness());
            output_list.Sort();
            long output = output_list[0] + output_list[output_list.Count - 1];
            Assert.AreEqual(62, output);

        }


    }
}
