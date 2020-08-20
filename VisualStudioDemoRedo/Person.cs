using System;
using System.Collections.Generic;
using System.Text;

namespace VisualStudioDemoRedo
{
    public class Person
    {
        private int _age;
        public string Name { get; set; }

        public int Age
        {
            get {
                return _age;
            }
            set {
                if (value > 1000)
                {
                    throw new Exception("You can't be that old!");
                }
                else
                {
                    _age = value;
                }
            }
        }

        public string Greeting()
        {
            return $"Hello! My name is {Name}, I'm {Age} years old and full of energy! Nice to meet you!";
        }

        public Person()
        {
            Name = "John Doe";
            Age = 18;
        }
    }
}
