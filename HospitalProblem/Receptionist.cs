using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalProblem
{
    class Receptionist : Employee
    {

        public bool OnThePhone { get; set; }
        public Receptionist(bool onThePhone) : base("",300,45000)
        {
            OnThePhone = onThePhone;
        }
    }
}
