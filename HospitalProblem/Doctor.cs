using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalProblem
{
    class Doctor : Employee
    {
        public string SpecialtyArea { get; set; }

        public Doctor(string specialtyArea) : base("", 400, 0,"")
        {
            SpecialtyArea = specialtyArea;
        }
        public override void PayEmployees()
        {
            base.PayEmployees();
            Salary = 90000.00;
        }
        public void DrawBlood(Patient thePatient)
        {

        }
    }
}
