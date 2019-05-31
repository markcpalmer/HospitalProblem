using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalProblem
{
    class Nurse : Employee
    {
        public int NumberOfPatients { get; set; }
        public Nurse(int numberOfPatients) : base("", 200, 0, "")
        {
            NumberOfPatients = numberOfPatients;
        }
        public void Drawblood(Patient thePatient)
        {
            //effects health level and blood level differently for nurse than doctor
        }
    }
}
