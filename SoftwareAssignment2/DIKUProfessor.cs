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

        public override bool BeDrained(int amount)
        {
            amount = amount / 4;
            return base.BeDrained(amount);
        }

        public override void GetExperience()
        {
            Console.WriteLine("I have already finished my degree, I cannot be greater");
        }

        public override string ToString()
        {
            return $"Name: {Name}\nActivity: {Activity}\nCurrent brainpower: {BrainPower}";
        }
    }
}
