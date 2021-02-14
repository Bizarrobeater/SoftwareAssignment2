using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareAssignment2
{
    class DIKUStudent : DIKUPerson
    {
        public int Semester { get; set; }
        public DIKUStudent(string name, DIKUActivity activity) 
            : base(name, activity)
        {
            Semester = 1;
            MaxBrainPower = 20;
            BrainPower = 20;
            StrengthOfArgument = 4;
            CounterArgument = 10;
            DoubleArgument = 10;
        }
    }
}
