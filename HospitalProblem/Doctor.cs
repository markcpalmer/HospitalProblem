using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalProblem
{
    class Doctor : Employee
    {
        public string SpecialtyArea { get; set; }

        public Doctor(string specialtyArea) : base("", 400, 90000)
        {
            SpecialtyArea = specialtyArea;
        }
        public override void PayEmployees()
        {
            base.PayEmployees();
        }
        public void DrawBlood(Patient thePatient)
        {

        }
    }
}
