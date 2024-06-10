using System;
using System.Data; //Class Library - Input/Ouput
// Above - namespaces - header files(c,c++)

//namespace - collection of classes
namespace Dlithe_CSharp
{
    //comments - explanatory part of the program
    //access specifiers - private,public,protected,internal,protected internal
    //default access specifier for a class - internal
    //class - collection of objects - methods(functions),variables
    //void Main()
    internal class Program         
    {
        static void Main(string[] args)
        {
            //Console-class - WriteLine(method) - "Welcome to CSharp" - parameter
            Console.WriteLine("Welcome to CSharp");
            Console.WriteLine("Test Data again");

            //Datatypes - Value Type - int,float,double,bool,structures,enum
            //Reference Type - class,interface, delegates

            //datatype variable = value;
            int a = 10;
            Console.WriteLine(a);
            Console.WriteLine("Integer value:" + a);
            Console.WriteLine("Integer value:{0}" , a);
            //String Interpolation
            Console.WriteLine($"Integer{a} value:{a}");
            char b = 'A';
            Console.WriteLine(b);
            float f = 12.35f;
            Console.WriteLine(f);
            double d = 12.3654789652;
            Console.WriteLine(d);
            bool e = false;
            Console.WriteLine(e);
            Console.WriteLine("Float:{0},Double:{1}",f,d);
            Console.WriteLine($"character:{b},Boolean:{e}");

            //Give input during runtime
            Console.WriteLine("**********************");
            Console.WriteLine("Enter User Details");
            Console.WriteLine("Enter User Id");//10
            int userid=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"User ID is:{userid}");
            Console.WriteLine("Enter Username");
            string username=Console.ReadLine();
            Console.WriteLine($"Username is:{username}");
            Console.ReadLine();
        }
    }
}
