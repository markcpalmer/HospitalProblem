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
        public string EmployeeType { get; set; }

        public Employee(string employeeName,int employeeNumber,double salary,string employeeType)
        {
            EmployeeName = employeeName;
            EmployeeNumber = employeeNumber;
            Salary = salary;
            HaveBeenPaid = false;
            EmployeeType = EmployeeType;
        }
        public void AddEmployee(Employee testEmployee)
        {
            string empName = "";
            int empNumber =0;
            double empSalary = 0.0;
            string empType = "";
            

            Console.Write("type employee name");
            empName = Console.ReadLine();
            Console.Write("type employee number");
            empNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("type in employee salary");
            empSalary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the employee position");
            empType = Console.ReadLine();

            this.EmployeeName = empName;
            this.EmployeeNumber = empNumber;
            this.Salary = empSalary;
            this.EmployeeType = empType;

           
            employeesList.Add(testEmployee);
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
            if (HaveBeenPaid == false)
            {
               
                Console.WriteLine("The employee has been paid.");
            }
            else
            {
                Console.WriteLine("This employee has already been paid.");
            }
        }
        //public void ChooseEmployee()
        //{
        //    //may have to return Employee
        //}

    }
}
