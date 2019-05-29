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

        
        public List<Employee> employeesList= new List<Employee>();


        public void PrintEmployees()
        {

        }
        public void PayEmployees()
        {

        }
        public void ChooseEmployee()
        {
            //may have to return Employee
        }

    }
}
