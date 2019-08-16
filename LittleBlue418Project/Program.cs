using System;

namespace LittleBlue418Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // create object | making an instance of it | set the instance | create a new one | of this class | input the missing variables from the object.
            Octopus myOctopus1 = new Octopus(20, "purple");
            // calling our instance | calling a function from within the class
            myOctopus1.PrintDescription();

            Octopus myOctopus2 = new Octopus(10, "yello");
            myOctopus2.rest();
            myOctopus2.PrintDescription();

            Octopus myOctopus3 = new Octopus(2, "black");
            myOctopus3.PrintDescription();

            // class | calling the static function within the Octopus class
            Octopus.DoSomething();



        }
    }
}
