using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus_Game
{
        public class Octopus
        {
        public int X { get; private set; }
        public int Y { get; private set; }
        private int gridSize;

        public Octopus(int x, int y, int gridSize) 
        { 
            this.X = x;
            this.Y = y;
            this.gridSize = gridSize;
        }

        public void moveUp()
        {
            if (Y >= 1)
            {
                Y--;
            }
        }

        public void moveDown()
        {
            if (Y < (gridSize -1))
            {
                Y++;
            }
        }
        public void moveLeft()
        {
            if (X >= 1)
            {
                X--;
            }
        }
        public void moveRight()
        {
            if (X < (gridSize - 1))
            {
                X++;
            }
        }

    }
}
