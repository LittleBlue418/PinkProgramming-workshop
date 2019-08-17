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

        public Octopus(int x, int y) 
        { 
            this.X = x;
            this.Y = y;
        }

        public void moveUp()
        {
            Y--;
        }

        public void moveDown()
        {
            Y++;
        }
        public void moveLeft()
        {
            X--;
        }
        public void moveRight()
        {
            X++;
        }

    }
}
