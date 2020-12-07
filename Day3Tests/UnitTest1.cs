using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Day3;
using ChristmasUtils;

namespace Day3Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SampleTerrainTest()
        {
            List<string> testInput = new List<string>();
            testInput.Add("..##.......");
            testInput.Add("#...#...#..");
            testInput.Add(".#....#..#.");
            testInput.Add("..#.#...#.#");
            testInput.Add(".#...##..#.");
            testInput.Add("..#.##.....");
            testInput.Add(".#.#.#....#");
            testInput.Add(".#........#");
            testInput.Add("#.##...#...");
            testInput.Add("#...##....#");
            testInput.Add(".#..#...#.#");
            // Act

            //generate terrain
            Terrain TR = new Terrain(FileUtils.CreateTempFileFromList(testInput));
            //Start Tobbogan
            Toboggan TB = new Toboggan(0, 0, TR);
            TB.Run();
            Assert.AreEqual(7, TB.treeCount);
        }

        [TestMethod]
        public void SampleFindOptimalSpeed()
        {
            List<string> testInput = new List<string>();
            testInput.Add("..##.......");
            testInput.Add("#...#...#..");
            testInput.Add(".#....#..#.");
            testInput.Add("..#.#...#.#");
            testInput.Add(".#...##..#.");
            testInput.Add("..#.##.....");
            testInput.Add(".#.#.#....#");
            testInput.Add(".#........#");
            testInput.Add("#.##...#...");
            testInput.Add("#...##....#");
            testInput.Add(".#..#...#.#");
            // Act

            //generate terrain
            Terrain TR = new Terrain(FileUtils.CreateTempFileFromList(testInput));
            //Start Tobbogan
            Toboggan TB1 = new Toboggan(0, 0, TR,1,1);
            TB1.Run();
            Toboggan TB2 = new Toboggan(0, 0, TR,3,1);
            TB2.Run();
            Toboggan TB3 = new Toboggan(0, 0, TR,5,1);
            TB3.Run();
            Toboggan TB4 = new Toboggan(0, 0, TR,7,1);
            TB4.Run();
            Toboggan TB5 = new Toboggan(0, 0, TR, 1, 2);
            TB5.Run();
            Assert.AreEqual(336, TB1.treeCount * TB2.treeCount * TB3.treeCount * TB4.treeCount* TB5.treeCount);
        }
    }
}
