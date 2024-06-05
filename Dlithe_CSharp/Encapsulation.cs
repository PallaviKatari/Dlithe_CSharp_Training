using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlithe_CSharp
{
    /// <summary>
    /// Encapsulation - Bundling Data
    /// </summary>
    internal class Encapsulation
    {
        /// <summary>
        /// What is a Summary - Explanation about your method
        /// summary - XML(eXtensible Markup language) format
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            EncapsulationDemo demo = new EncapsulationDemo();
            //demo.id = 1;
            //demo.name= "test";
            //Console.WriteLine($"{demo.id}:{demo.name}");
            demo.Id = 10;
            demo.Name = "John Doe";
            Console.WriteLine($"{demo.Id}:{demo.Name}");
            Console.WriteLine(demo.Name);
            Console.ReadLine();

        }
    }

    internal class EncapsulationDemo
    {
        int id;
        string name;

        /// <summary>
        /// Property - prop tab - get/set
        /// </summary>
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }

        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


    }
}
