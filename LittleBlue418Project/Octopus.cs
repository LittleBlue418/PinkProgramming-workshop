using System;
using System.Collections.Generic;
using System.Text;

namespace LittleBlue418Project
{
    //Class
    public class Octopus
    {
        // Attributes
        public int size { get; set; }
        public string color;
        public bool swimming = true;

        // Constructor
        public Octopus(int size, string color)
        {
            this.size = size;
            this.color = color;
        }

        //Methods
        public void PrintDescription()
        {
            string swimmingStatus = swimming ? "swimming" : "chilling out with a beer..";
            Console.WriteLine($"I am a {size}cm {color} octopus who is currently {swimmingStatus}.");
        }

        public void rest()
        {
            swimming = false;
        }

        //Static Method
        public static void DoSomething()
        {
            Console.WriteLine("We all love to swim though, and drink beer. It's a god life being an octopus");
        }

    }
}
