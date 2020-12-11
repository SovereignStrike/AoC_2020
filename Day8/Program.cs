using System;

namespace Day8
{
    class Program
    {
        const string PATH_INPUT = "input.dat";
        static void Main(string[] args)
        {
            Boot boo = new Boot(PATH_INPUT);
            boo.Run();
            Console.Write("Accumulator before loop : " + boo.state.accumulator);
        }
    }
}
