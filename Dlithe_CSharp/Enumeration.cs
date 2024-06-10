using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlithe_CSharp
{
    enum departments
    {
        hr = 10,
        finance,
        training,
        development = 21,
        designing,
        testing,
        systemadmin
    }
    /// <summary>
    /// Enum - Value Type - Special datatype which have constants with integral values
    /// </summary>
    internal class Enumeration
    {
        static void Main(string[] args)
        {
            Enumeration enumeration = new Enumeration();
            int value = (int)departments.hr;
            Console.WriteLine(value);
            Console.WriteLine(departments.hr + ":" + value);
            Console.WriteLine(departments.finance);
            Console.WriteLine("****************************");
            enumeration.Bonus(departments.hr);
            enumeration.Bonus(departments.designing);
            Console.ReadLine();
        }

        public void Bonus(departments dep)
        {
            int value;
            value = (int)dep;
            if (value == 10 || value==21)
            {
                Console.WriteLine("Bonus will be given");
            }
            else
            {
                Console.WriteLine("No Bonus will be given");
            }

        }
    }
}
