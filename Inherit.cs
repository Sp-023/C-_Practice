using System;

namespace Inheritance
{
    public class Inherit
    {
        public string firstname;
        public string lastname;
        public Inherit()
        {
            Console.WriteLine("this is parentclass contructor");
        }
        public void printnames()
        {
            Console.WriteLine(firstname + " " + lastname);
        }

        public Inherit(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class derived : Inherit
    {
        public derived(): base("the message from derived class")
        {
            Console.WriteLine("derived class constructor called");
        }
    }
    public class print2 :Inherit
    {
        public new  void printnames()
        {
            Console.WriteLine(firstname + " " + lastname + "- software developer");
        }
    }
}
