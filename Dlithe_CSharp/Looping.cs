using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlithe_CSharp
{
    internal class Looping
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looping Statements - Entry and Exit");
            int[] a = { 1, 2, 3 };

            Console.WriteLine("Foreach");
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("For Loop");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine("While Loop");
            int j=0;
            while (j<a.Length)
            {
                Console.WriteLine(a[j]);
                if (a[j] == 1)
                {
                    j++;
                    //continue;
                    if (a[j] == 2)
                    {
                        break;
                    }
                }
                j++;
            }

            Console.WriteLine("do-while Loop");
            int k=0;
            do
            {
                Console.WriteLine(a[k]);
                k++;
            }while(k<a.Length);

            Console.WriteLine("Arrays values during runtime");
            int size;
            Console.WriteLine("Enter the size of the array");
            size=Convert.ToInt32(Console.ReadLine());//3
            int[] array = new int[size]; //int[] array =new int[3]

            for (int i = 0;i < size;i++) //int[] array =new int[3]{1,2,3};
            {
                Console.WriteLine("Enter the value of {0} array", (i + 1));//1,2,3
                array[i]=Convert.ToInt32(Console.ReadLine());
            }

            foreach(int i in array)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
            
        }
    }
}
