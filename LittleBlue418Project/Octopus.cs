using System;
using System.Collections.Generic;
using System.Text;

namespace LittleBlue418Project
{
    //Class
    public class Octopus
    {
        // Attributes
        int size;
        string color;

        // Constructor
        public Octopus(int size, string color)
        {
            this.size = size;
            this.color = color;
        }

        //Function
        public void PrintDescription()
        {
            Console.WriteLine($"I am a {size}cm {color} octopus");
        }

    }
}
