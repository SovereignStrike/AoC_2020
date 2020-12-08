using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class Range
    {
        public int lower;
        public int upper;
        public int Gap
        { get {return (upper - lower + 1);}}
            
        public Range(int lower, int upper)
        {
            this.lower = lower;
            this.upper = upper;
        }

        public void TakeLowerHalf()
        {
            
            upper = lower + ((Gap / 2) - 1);
        }

        public void TakeUpperHalf()
        {
            
            lower = upper - ((Gap / 2) - 1);

        }
    }
}
