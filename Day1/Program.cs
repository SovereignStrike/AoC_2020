using System;

namespace Day1
{
    class Program
    {
        const string PATH_INPUT = "input.dat";
        static void Main(string[] args)
        {
            Report rep = new Report(PATH_INPUT);
            Console.Write("Two numbers: " + rep.Compute());
            Console.Write("Three numbers: " + rep.ComputeTriple());
        }



        
    }
}
