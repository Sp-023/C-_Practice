using System;

namespace static_and_Instance
{
    public class Radius
    {
        public static float pi;
        int radius;

        //static constructor
        static Radius()
        {
            Console.WriteLine("first static constructor is called");
            Radius.pi = 3.141f;
        }

        //instance constructor

        public Radius(int radius)
        {
            Console.WriteLine("second instance constructor is called");
            this.radius = radius;

        }

        public float area()
        {
            return  pi * radius * radius;
        }
    }

    
}
