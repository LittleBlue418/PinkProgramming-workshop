using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus_Game
{
    public class Food
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        private int gridSize;

        public Food(int x, int y, int gridSize)
        {
            this.X = x;
            this.Y = y;
            this.gridSize = gridSize;
        }

        public void Respawn()
        {
            Random randomGenerator = new Random();
            X = randomGenerator.Next(gridSize);
            Y = randomGenerator.Next(gridSize);
        }


    }
}
