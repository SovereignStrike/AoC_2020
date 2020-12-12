using System;
using System.Collections.Generic;
using System.Text;
using ChristmasUtils;
using System.Linq;

namespace Day9
{
    public class Finder
    {

        private List<long> numbers = new List<long>();
        private int preamble;

        public Finder(string path, int preamble_length)
        {
            //numbers = FileUtils.Read(path).Cast<int>().ToList();
            numbers = FileUtils.Read(path).Select(Int64.Parse).ToList();
            this.preamble = preamble_length;
        }

        public long FindWeakness()
        {
            int counter = 0;
            long current_number = 0;
            foreach (long num in numbers)
            {
                if (counter > preamble-1 )
                {
                    current_number = numbers[counter];
                    if (!FindMatch(current_number,counter))
                    { return current_number; }

                }
                counter++;
            }
            
            

            return 0;

        }

        private bool FindMatch(long current_number, int curent_pos)
        {
            foreach (long num1 in numbers.GetRange(curent_pos - preamble, preamble))
            {
                foreach (long num2 in numbers.GetRange(curent_pos - preamble, preamble))
                {
                    if (num1 + num2 == current_number)
                    {                        
                        return true;
                    }
                }
            }

            return false;
        }

        public List<long> FindContiguous(long input)
        {
            List<long> output;
            long sum = 0;
            for (int i = 0; i < numbers.Count()-1; i++)
            {
                output =  new List<long>();
                output.Add(numbers[i]);
                sum = numbers[i];
                for (int j = i+1; j < numbers.Count();j++)
                {
                    output.Add(numbers[j]);
                    sum = sum + numbers[j];
                    if (sum == input)
                    {
                        return output;
                    }
                    else if(sum > input)
                    {
                        break;
                    }
                }
            }

            output = new List<long>();
            return output;
        }
    }
}
