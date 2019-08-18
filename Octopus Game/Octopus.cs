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

        private int hunger;
        public int Hunger
        {
            get { return hunger; }

            set
            {
                if (value < 0)
                {
                    hunger = 0;
                }
                else if (value > 100)
                {
                    hunger = 100;
                }
                else
                {
                    hunger = value;
                }
            }
        }


        public Octopus(int x, int y, int gridSize) 
        { 
            this.X = x;
            this.Y = y;
            this.gridSize = gridSize;
            Hunger = 100;
        }

        public void moveUp()
        {
            if (Y >= 1)
            {
                Y--;
                Hunger -= 5;
            }
        }

        public void moveDown()
        {
            if (Y < (gridSize -1))
            {
                Y++;
                Hunger -= 5;
            }
        }
        public void moveLeft()
        {
            if (X >= 1)
            {
                X--;
                Hunger -= 5;
            }
        }
        public void moveRight()
        {
            if (X < (gridSize - 1))
            {
                X++;
                Hunger -= 5;
            }
        }

    }
}
