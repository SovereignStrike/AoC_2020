using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    public class Toboggan
    {
        private int x;
        private int y;
        private int xSpeed;
        private int ySpeed;
        private Terrain terr;
        public int treeCount;
        public Toboggan(int startX, int startY, Terrain terr)
        {
            this.x = startX;
            this.y = startY;
            this.terr = terr;
            this.xSpeed = 3;
            this.ySpeed = 1;

        }

        public Toboggan(int startX, int startY, Terrain terr, int xSpeed, int ySpeed)
        {
            this.x = startX;
            this.y = startY;
            this.terr = terr;
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;

        }

        public void Run()
        {
            while (y < terr.slopeLength-1)
            {
                x = x + xSpeed;
                y= y+ ySpeed;
                treeCount = treeCount + terr.IsThereATree(x, y);
            }
        }



    }
}
