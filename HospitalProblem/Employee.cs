using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalProblem
{
   
    class Employee
    {
        public string EmployeeName { get; set; }
        public int EmployeeNumber { get; set; }
        public double Salary { get; set; }
        public bool HaveBeenPaid { get; set; }

        public Employee(string employeeName,int employeeNumber,double salary)
        {
            EmployeeName = employeeName;
            EmployeeNumber = employeeNumber;
            Salary = salary;
            HaveBeenPaid = false;
        }
        public void AddEmployee(Employee theEmployee)
        {
            string nameInput = "";
            int numberInput =0;
            double salaryInput = 0.0;
            

            Console.Write("type employee name");
            nameInput = Console.ReadLine();
            Console.Write("type employee number");
            numberInput = Convert.ToInt32(Console.ReadLine());
            Console.Write("type in employee salary");
            salaryInput = Convert.ToDouble(Console.ReadLine());
            Employee testEmployee = new Employee(nameInput, numberInput, salaryInput);
            employeesList.Add(theEmployee);
            Console.WriteLine("The employee has been added to list.");
            
        }
        public List<Employee> employeesList= new List<Employee>();


        public void PrintEmployees()
        {
            foreach(Employee element in employeesList)
            {
                Console.WriteLine($"{element.EmployeeName} {element.EmployeeNumber}");
            }
        }
        public virtual void PayEmployees()
        {
            Console.WriteLine("The employee has been paid.");
        }
        //public void ChooseEmployee()
        //{
        //    //may have to return Employee
        //}

    }
}
