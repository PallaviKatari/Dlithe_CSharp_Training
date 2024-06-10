using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlithe_CSharp
{
    /// <summary>
    /// C# - Value Type Datatypes - Cannot accept NULL values
    /// Nullables - Value Type Datatypes - To accept NULL values 
    /// </summary>
    internal class Nullables
    {
        int? a=20;
        Nullable<int> num=null;
        int b = 10;
        int? c;

        static void Main(string[] args)
        {
            Nullables nullable = new Nullables();
            //Console.WriteLine("Hello" + "Hello");
            //Console.WriteLine("Hello"+nullable.a+"Hello");
            nullable.c = nullable.a; //NULL
            //?? NULL Coaleasing operator
            //Result=sem1??sem2
            nullable.c = nullable.a ?? nullable.b; //10
            Console.WriteLine(nullable.c);                                      
            Console.ReadLine();
            
        }
    }
}
