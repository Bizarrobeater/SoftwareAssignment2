using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareAssignment2
{
    class DIKUProfessor : DIKUPerson
    {
        public DIKUProfessor(string name, DIKUActivity activity)
            : base(name, activity)
        {
            MaxBrainPower = 10000;
            BrainPower = 10000;
            StrengthOfArgument = 500;
            CounterArgument = 75;
            DoubleArgument = 45;
        }

        public override bool HasLost()
        {
            Console.WriteLine("I can not lose!");
            return base.HasLost();
        }

        public override string ToString()
        {
            return $"Name: {Name}\nActivity: {Activity}\nCurrent brainpower: {BrainPower}";
        }
    }
}
