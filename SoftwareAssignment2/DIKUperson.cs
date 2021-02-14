using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareAssignment2
{
    abstract class DIKUPerson
    {
        public string Name { get; set; }
            
        public int MaxBrainPower { get; protected set; }
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

            if (CounterArgument > counterArgRoll)
            {
                Console.WriteLine($"{Name} dodged the argument!");
                return false;
            }
            else
            {
                BrainPower -= amount;
                return true;
            }
        }

        public virtual void Argue(DIKUPerson opponent)
        {
            int argMultiplier = 1;
            string argumentText = "an";
            if (CheckForCrit())
            {
                argMultiplier = 2;
                argumentText = "a CRITICAL";
            }

            Console.WriteLine($"{this.Name} strikes {argumentText} at {opponent.Name} for {argMultiplier * StrengthOfArgument} points of draining");
            opponent.BeDrained(argMultiplier * StrengthOfArgument);           
        }

        private bool CheckForCrit()
        {
            int critRoll = _random.Next(101);
            return DoubleArgument > critRoll;
        }

        public virtual void GetExperience()
        {
            StrengthOfArgument += 2;
            MaxBrainPower += Activity == DIKUActivity.AttendingNone ? 20 : 10;
            CounterArgument += Activity != DIKUActivity.AttendingNone ? 10 : 5;
            DoubleArgument += Activity == DIKUActivity.AttendingAll ? 10 : 5;
            BrainPower = MaxBrainPower;
        }

    }
}
