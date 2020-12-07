using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day3
{
    public class Terrain
    {
        int[,] baseMatrix;
        int baseXSize;
        public int slopeLength;
        public Terrain(string inputpath) 
        {
            List<string> inputlist = new List<string>();
            inputlist = Read(inputpath);
            int y;
            int x;
            y = 0;
            baseMatrix = new int[inputlist[0].Length, inputlist.Count];
            foreach (string line in inputlist)
            {
                x = 0;
                char[] arr = line.ToCharArray();
                foreach (char car in arr)
                {
                    baseMatrix[x, y] = Translate(car);
                    ++x;
                }
                this.baseXSize = x;
                ++y;
            }
            this.slopeLength = y;
        }

        private int Translate(char car)
        {
            if (car == '#')
            { return 1; }
            else { return 0; }
        }

        public int IsThereATree(int x, int y) {

           return baseMatrix[ConvertX(x), y]; 
            }

        private int ConvertX(int x)
        {
            return x % baseXSize;
        }

        protected List<string> Read(string testInputFilePath)
        {
            StreamReader sr = new StreamReader(testInputFilePath);
            List<string> values = new List<string>();
            while (sr.Peek() != -1)
            {
                values.Add(sr.ReadLine());

            }
            return values;


        }


    }
}
