using System;

namespace Day7
{
    class Program
    {
        const string PATH_INPUT = "input.dat";
        static void Main(string[] args)
        {
            Rules rews = new Rules(PATH_INPUT);

            Console.Write("Total bags that hold golden bags : " + rews.CountGoldenBags());
        }
    }
}
