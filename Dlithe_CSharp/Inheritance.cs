using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlithe_CSharp
{
    /// <summary>
    /// Inheritance - Reusability
    /// Types - Single - Base-Derived,multi-level - Base - Derived/Base - Derived,hierarichal - Base - Derived1,Derived2,hybrid
    /// Multiple Inheritance - Not supported instead Interface
    /// </summary>
    internal class Inheritance
    {
        static void Main(string[] args)
        {
            HR hR = new HR(); // Trainer,Trainee
            hR.AcceptTraineeDetails();
            hR.DisplayTraineeDetails();
            hR.AcceptTrainerDetails();
            hR.DisplayTrainerDetails();
            Console.ReadLine();
            
        }
    }
    internal class Trainee //Base
    {
        //Variables/Fields
        public int trainee_id;
        public string trainee_name;
        public void DisplayTraineeDetails()
        {
            Console.WriteLine($"Trainee ID:{trainee_id}");
            Console.WriteLine($"Trainee Name:{trainee_name}");
        }
    }
    internal class Trainer:Trainee//Derived/Base
    {
        //Variables/Fields
        protected int trainer_id;
        public string trainer_name;

        public void DisplayTrainerDetails()
        {
            Console.WriteLine($"Trainer ID:{trainer_id}");
            Console.WriteLine($"Trainer Name:{trainer_name}");
        }
        
    }

    internal class HR:Trainer//Derived
    {
        public void AcceptTraineeDetails()
        {
            trainee_id = 10;
            trainee_name = "John Doe";
        }
        public void AcceptTrainerDetails()
        {
            trainer_id = 1;
            trainer_name = "Jane Doe";
        }
    }


    //Example for protected access specifier
    //internal class ProtectedDemo
    //{

    //    public void Display()
    //    {
    //        Trainer trainer = new Trainer();
    //        trainer.trainer_id = 10;

    //    }
    //}

}
