using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalProblem
{
    class Patient
    {
        public int HealthLevel { get; set; }
        public int BloodLevel { get; set; }
        public List<Patient> listOfPatients = new List<Patient>();
        public Patient()
        {
            HealthLevel = 100;
            BloodLevel = 100;
        }
        Patient testPatient = new Patient();
    }
}
