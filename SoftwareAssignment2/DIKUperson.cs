using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareAssignment2
{
    abstract class DIKUPerson
    {
        public string Name { get; set; }
            
        public int MaxBrainPower { get; init; }
        public int BrainPower { get; protected set; }
        public int StrengthOfArgument { get; set; }
        public int CounterArgument { get; set; }
        public int DoubleArgument { get; set; }
        public DIKUActivity Activity { get; set; }

        private Random _random;

        public DIKUPerson(string name, DIKUActivity activity)
        {
            Name = name;
            Activity = activity;
            _random = new Random();
        }

        public virtual bool HasLost()
        {
            return BrainPower <= 0;
        }

        public virtual bool BeDrained(int amount)
        {
            int counterArgRoll = _random.Next(101);
            int critCounterROll;
            if (CounterArgument >= counterArgRoll)
            {
                critCounterROll = _random.Next(101);
                return false;
            }
            else
            {
                BrainPower -= amount;
                return true;
            }
        }

    }
}
