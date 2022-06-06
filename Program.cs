using Inheritance;
using static_and_Instance;
using System;
using ptf=ClassA.Class1;

namespace C_Sharp_Practice_Report
{
    class Program
    {
        public static void person(int st,int et,out int sum, out int product)
        {
            sum = st + et;
            product = st * et;
        }

        public static void paramsMethod(params int[] numbers)
        {
            Console.WriteLine("there are {0} elements ", numbers.Length);

            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");

            Console.WriteLine("===================================");

            //Reading and writing to console
            
            Console.WriteLine("-------Reading and writing to Console------------");
            Console.WriteLine("Enter the fav sport");
            string fav = Console.ReadLine();

            Console.WriteLine("I like {0}", fav);

            Console.WriteLine("===================================");

            Console.WriteLine("------> Built-in datatypes <------------");

            //boolean :
            string ans = "y";
            bool b = true;
            while (ans == "y")
            {
                if (b)
                {
                    b = false;
                    Console.WriteLine("b holds true");
                }
                else
                {
                    b = true;
                    Console.WriteLine("b holds false");
                }
                Console.WriteLine("to continue type y or n");
                ans = Console.ReadLine();

            }
            //Integral datatypes
            Console.WriteLine("===================================");

            Console.WriteLine("------> Int and Float  datatypes <------------");

            // to find min and max

            int i = 0;
            Console.WriteLine("min= {0}", int.MinValue);
            Console.WriteLine("max = {0}", int.MaxValue);


            // floating-types
            Console.WriteLine("float is 32bit and its precision is 7 digits");
            Console.WriteLine("Double is 64bit and its precision is 15-16 digits");
            Console.WriteLine("Decimal is 128bit and its precision is 28-29 digits");


            // Strings
            Console.WriteLine("===================================");

            Console.WriteLine("------> Srings datatypes <------------");

            // Escape character "\"
            string name = "\".netImmersion Training\" \n starts today";
            Console.WriteLine(name);

            // @ :- Verbatim Literal
            string nam2 = @"C:\\home\\shared";
            Console.WriteLine(nam2);
            Console.WriteLine("===================================");

            Console.WriteLine("------> Commom Operators <------------");
            //Arithmetic operators

            // ternary operators
            int a = 10;
            bool iscorrect = a == 10 ? true : false;
            Console.WriteLine(iscorrect);

            //Nullable values

            // to make nullable  use "?"
*/
            int? j = null;

            //Example
            bool? AreYoukind = null;

            if(AreYoukind == true)
            {
                Console.WriteLine("user is kind");
            }
            else if(AreYoukind ==false)
            {
                Console.WriteLine("user is not kind");
            }
            else
            {
                Console.WriteLine("user is not answered");
            }

            // null Coalescing Operator

            int? ticket = null;
            int allticket = ticket ?? 0;
            Console.WriteLine("allticket ={0}", allticket);


            //conversions

            int k = 100;
            float f = k; //implicit coversion

            float ff = 12234.43F;
            int ii = (int)ff; //Explicit conversion

            string strn = "1000";
            int ress = 0;
           bool IsCoversionSuccess =  int.TryParse(strn, out ress);
           
            if(IsCoversionSuccess)
            {
                Console.WriteLine(ress);

            }
            else
            {
                Console.WriteLine("please the enter valid number");
            }

            //Switch

            /*Console.WriteLine("enter the number");
            int un = int.Parse(Console.ReadLine());

            switch(un)
            {
                case 10:
                    Console.WriteLine("YOur number is 10");
                    break;
                case 20:
                    Console.WriteLine("your number is 20");
                    break;
            }*/


            //Foreach and for

            int[] numbers = new int[3];
            numbers[0] = 100;
            numbers[1] = 101;
            numbers[2] = 102;
            foreach(int p in numbers)
            {
                Console.WriteLine(p);
            }

            //Methods
            int sum = 0;
            int product = 0;
            person(10,30,out sum,out product);
            Console.WriteLine("sum = {0} and product = {1}", sum, product);


            //param array
            paramsMethod(1, 2, 3, 4, 5);

            //-------->namespace

            ptf.print(); // using namespace from another class


            Console.WriteLine("===================================");

            Console.WriteLine("------> static and instance<------------");

            Radius r = new Radius(5);
            float ans = r.area();
            Console.WriteLine("the area is {0}", ans);

            //Inheritance

            //creating derived class instance
            Console.WriteLine("===================================");

            Console.WriteLine("------> Inheritance <------------");

            derived dd = new derived();
            Inherit fff = new print2();
            fff.firstname = "myname";
            fff.lastname = "surya";
            fff.printnames();

            //Polymorphism :
            //--> Polymorphism allows you to invoke derived class methods
            
         


        }

        

    }
}
