using System;
using System.Collections.Generic;

namespace CorporatePolymorphism
{
  class Program
  {
        static void Main(string[] args)
        {
            //*********************************
            //******* Task3 Test Code *********
            //*********************************
            Employee hrRep = new HR();

            hrRep.ClockIn();
            hrRep.Work();
            hrRep.SubmitDailyReport();
            Console.WriteLine(); //Line break
                                 //*********************************
                                 //******* Task3 Test Code *********
                                 //*********************************

            // Placeholder for list of employees
            Employee employee1 = new Engineer();
            employee1.SubmitDailyReport();
            Employee employee2 = new Manager();
            Employee employee3 = new Intern();
            Console.WriteLine();
            employee2.ClockIn();
            employee2.Work();
            Console.WriteLine();
            employee3.ClockIn();
            employee3.Work();

            // Placeholder for adding employees to the list
            Engineer engineer1 = employee1 as Engineer;
            if (engineer1 == null)
            {
                engineer1.SubmitDailyReport();
            }
            else
            {
                Console.WriteLine("failed");
            }
            var employees = new List<Employee>();
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            foreach (var temp in employees)
            {
                if (temp is Engineer)
                {
                    Console.WriteLine("This is an Engineer");
                }
                else if (temp is Manager)
                {
                    Console.WriteLine("This is an Manager");
                }
                else
                {
                    Console.WriteLine("This is an Intern");
                }
                temp.ClockIn();
                temp.Work();
                temp.SubmitDailyReport();
                Console.WriteLine("\n");
            }
            
            

        }
  }
}
