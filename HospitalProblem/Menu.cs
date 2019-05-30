using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalProblem
{
    class Menu
    {
        string userInput = "";
       public  Menu()
        {
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

                        break;
                    case "2":
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
