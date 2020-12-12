using System;

namespace Day9
{
    class Program
    {

        const string PATH_INPUT = "input.dat";
        static void Main(string[] args)
        {
            
            

            int preamble_length = 25;
            Finder fin = new Finder(PATH_INPUT, preamble_length);
            long output = fin.FindWeakness();
            Console.Write("Weak number : " + output);
            System.Collections.Generic.List<long> output_list = fin.FindContiguous(output);
            output_list.Sort();
            long output_seq = output_list[0] + output_list[output_list.Count - 1];
            Console.Write("Sequence total lowest and highest : " + output_seq);
        }
    }
}
