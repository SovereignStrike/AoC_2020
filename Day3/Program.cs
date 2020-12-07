using System;

namespace Day3
{
    class Program
    {
        const string PATH_INPUT = "input.dat";
        static void Main(string[] args)
        {
            Terrain ter = new Terrain(PATH_INPUT);
            Toboggan tob= new Toboggan(0,0, ter);
            tob.Run();
            Console.Write("trees encountered " + tob.treeCount);

            Toboggan TB1 = new Toboggan(0, 0, ter, 1, 1);
            TB1.Run();
            Toboggan TB2 = new Toboggan(0, 0, ter, 3, 1);
            TB2.Run();
            Toboggan TB3 = new Toboggan(0, 0, ter, 5, 1);
            TB3.Run();
            Toboggan TB4 = new Toboggan(0, 0, ter, 7, 1);
            TB4.Run();
            Toboggan TB5 = new Toboggan(0, 0, ter, 1, 2);
            TB5.Run();
            long large = (Convert.ToInt64(TB1.treeCount) * Convert.ToInt64(TB2.treeCount) * Convert.ToInt64(TB3.treeCount) * Convert.ToInt64(TB4.treeCount) * Convert.ToInt64(TB5.treeCount));
            Console.Write("trees encountered multi-run " + large.ToString());
        }
    }
}
