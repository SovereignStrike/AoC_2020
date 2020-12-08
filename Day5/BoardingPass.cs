using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    public class BoardingPass
    {
        public int column;
        public int row;
        public string tag;
        public int id
        {
            get => (row * 8) + column;
            set { throw new NotSupportedException(); }
        }
        public BoardingPass(string tag)
                {
            this.tag = tag;
            CalculateCoordinates();
        }

        private void CalculateCoordinates()
        {
            Range range = new Range(0, 127);
            

            foreach(char car in tag.Substring(0,7).ToCharArray())
            {
                if (car.ToString() == "F")
                {
                    range.TakeLowerHalf();
                }
                else
                {
                    range.TakeUpperHalf();
                }

            }
            row = range.lower;

            range = new Range(0, 7);
            foreach (char car in tag.Substring(7, 3).ToCharArray())
            {
                if (car.ToString() == "L")
                {
                    range.TakeLowerHalf();
                }
                else
                {
                    range.TakeUpperHalf();
                }

            }
            column = range.lower;
        }

    }
}
