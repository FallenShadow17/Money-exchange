using System;

namespace Casa_De_Cambio
{
    class Program
    {

        class Employee
        {
            int workID;
            string name;
            
            //Setters
            void SetWorkID(int i)
            {
                workID = i;
            }
            void SetName(string s)
            {
                name = s;
            }

            //Getters
            int GetWorkID()
            {
                return workID;
            }

            string GetName()
            {
                return name;
            }


        }


        static void Main(string[] args)
        {

            // create start up for program.
            int option = 1;
            while(option != 1 || option != 2)
            {
                Console.WriteLine("1. new employee\n2. existing employee\n");
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("input: {0}", option);
            }


            //make a main interface.
            Console.WriteLine("Casa de cambio");
        }
    }
}
