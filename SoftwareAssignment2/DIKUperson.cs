using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareAssignment2
{
    class DIKUPerson
    {
        public string Name { get; set; }
            
        public int MaxBrainPower { get; set; }
        public int BrainPower { get; set; }
        public int StrengthOfArgument { get; set; }
        public int CounterArgument { get; set; }
        public int DoubleArgument { get; set; }
        public DIKUActivity Activity { get; set; }

        public DIKUPerson(string name, DIKUActivity activity)
        {
            Name = name;
            Activity = activity;
        }

    }
}
