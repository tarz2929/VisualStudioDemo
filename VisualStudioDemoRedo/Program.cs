using System;
using System.Collections.Generic;

namespace VisualStudioDemoRedo
{
    class Program
    { 
        static void Main(string[] args)
        {
            Person bob = new Person();
            bob.Name = "Bob";
            bob.Age = 50;

            Person joe = new Person
            {
                Name = "Joe",
                Age = 25
            };

            Person defaultPerson = new Person();

            Console.WriteLine(bob.Greeting());
            Console.WriteLine(joe.Greeting());
            Console.WriteLine(defaultPerson.Greeting());

        }
    }
}

