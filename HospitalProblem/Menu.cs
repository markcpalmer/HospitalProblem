using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalProblem
{
    class Menu
    {
        string userInput = "";
        Employee testEmployee;

       public  Menu()
        {
            testEmployee = new Employee("", 0, 0,"");
            do
            {
                Console.WriteLine("1. Add Employee to list");
                Console.WriteLine("2. View Employee's ");
                Console.WriteLine("3. Pay Employee");
                Console.WriteLine("4. Assign nurse to draw blood");
                Console.WriteLine("5. Assign Janator to Sweep.");
                Console.WriteLine("6. Assign receptionist to pick up phone");
                Console.WriteLine("9. exit.");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        testEmployee.AddEmployee(testEmployee);
                        break;
                    case "2":
                        testEmployee.PrintEmployees();
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "9":
                        break;
                    
                }

            } while (userInput != "9");
        }
    }
}
