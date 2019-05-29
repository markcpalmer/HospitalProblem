using System;

namespace HospitalProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //doctor test drive
            //create doctor
            Doctor smith = new Doctor();
            //create testPatient
            Patient testPatient = new Patient();
            // draw blood
            smith.DrawBlood(testPatient);
            // payday

        }
    }
}
