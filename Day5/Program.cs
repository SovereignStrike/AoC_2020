using System;

namespace Day5
{
    class Program
    {
        const string PATH_INPUT = "input.dat";
        static void Main(string[] args)
        {
            BoardingPassList passes = new BoardingPassList(PATH_INPUT);

            Console.Write("Highest boarding pass : " + passes.HighestId());
            Console.Write("First empty seat : " + passes.FirstEmptySeat());
        }
    }
}
