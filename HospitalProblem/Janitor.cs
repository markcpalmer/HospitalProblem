﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalProblem
{
    class Janitor : Employee
    {
        public bool Sweeping { get; set; }

        public Janitor(bool sweeping) : base("", 500, 0, "janitor")
        {
            Sweeping = sweeping;
            
        }
    }
}
