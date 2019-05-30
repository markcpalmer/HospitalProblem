using System;

namespace HospitalProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            // create employee
            Employee testEmployee = new Employee("john smith", 100, 20000);
            testEmployee.AddEmployee(testEmployee);
            testEmployee.PrintEmployees();
            Menu userMenu = new Menu();


            Console.ReadKey();
            
            
            
            //doctor test drive
            //create doctor
            //Doctor smith = new Doctor();
            //create testPatient
            //Patient testPatient = new Patient();
            // draw blood
            //smith.DrawBlood(testPatient);
            // payday

        }
    }
}
