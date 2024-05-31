using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlithe_CSharp
{
    internal class Arrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-D Array");
            int[] a = { 1, 2, 3 };
            int[] b = new int[] { 11, 22, 33 };
            int[] c = new int[3] { 111, 222, 333 };
            int[] d = { 4, 1, 8, 3, 2 };

            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
            foreach (int i in b)
            {
                Console.WriteLine(i);
            }
            foreach (int i in c)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Array Methods");
            Console.WriteLine(d.Length);
            Console.WriteLine(d.Max());
            Console.WriteLine(d.Min());
            Console.WriteLine(d.Average());
            Console.WriteLine(d.Sum());
            Console.WriteLine("Sorted Array");
            Array.Sort(d);

            foreach (int i in d)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Sorted Array in Reverse order");
            Array.Reverse(d);

            foreach (int i in d)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("2-D Array");

            int[,] e = new int[,]
            {
                { 1, 2,3},
                { 4, 5,6},
                { 6, 7,8}
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(e[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Jagged Array");
            int[][] jaggedArray = new int[3][]
            {
                new int[3]{1,2,3}, //jaggedArray[0].3  jaggedArray[0][0]-1,jaggedArray[0][1]-2,jaggedArray[0][2]-3
                //jaggedArray[1][0]-1,jaggedArray[1][1]-2,jaggedArray[1][2]-4 etc
                new int[5]{1,2,4,5,6},  //jaggedArray[1].5 
                //jaggedArray[2][0]-1,jaggedArray[2][1]-2
                new int[2]{1,2} //jaggedArray[2].2 
            };

            for(int i = 0;i < jaggedArray.Length;i++)
            {
                for(int j = 0;j < jaggedArray[i].Length;j++)
                {
                    Console.Write(jaggedArray[i][j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }


            Console.ReadLine();

        }
    }
}
