using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAssignment2
{
    class Classroom
    {
        public DIKUPerson RunDebate(List<DIKUPerson> contestants)
        {
            List<DIKUPerson> winnersList = contestants; ;

            DIKUPerson winner;
            while(winnersList.Count != 1)
            {
                winnersList = new List<DIKUPerson>();

                if (contestants.Count % 2 == 1)
                {
                    winnersList.Add(contestants[0]);
                    contestants.RemoveAt(0);
                }

                for (int i = 1; i < contestants.Count; i += 2)
                {
                    winner = Discuss(contestants[i - 1], contestants[i]);
                    winnersList.Add(winner);
                }

                contestants = winnersList;
            }

            Console.WriteLine($"Final winner of this debate night is: {winnersList[0].Name.ToUpper()}!!!");
            return winnersList[0];
        }

        public DIKUPerson Discuss(DIKUPerson person1, DIKUPerson person2)
        {
            int round = 1;
            DIKUPerson active;
            DIKUPerson inactive;

            Console.WriteLine("\nLet's get ready for DEEEEEEEBATE!");
            if (person1.MaxBrainPower != person2.MaxBrainPower)
            {
                active = person1.MaxBrainPower > person2.MaxBrainPower ? person1 : person2;
                inactive = person1.MaxBrainPower < person2.MaxBrainPower ? person1 : person2;
                Console.WriteLine($"Through the clever use of higher smarts {active.Name} start the debate!");
            }
            else
            {
                int di1Starts = new Random().Next(2);
                active = di1Starts == 1 ? person1 : person2;
                inactive = di1Starts == 0 ? person1 : person2;
                Console.WriteLine($"By being the luckier person - {active.Name} start the debate!");
            }


            while(!active.HasLost() && !inactive.HasLost())
            {
                Console.WriteLine($"\nROUND: {round}\nDISCUSS\n");

                active.Argue(inactive);

                var temp = active;
                active = inactive;
                inactive = temp;
                
                round++;
            }
            
            // currently only the inactive player can lose life - and the losing playing becomes the active at the end of the loop
            // as such, if a winner is found it will be the new inactive player
            Console.WriteLine($"\nThe winner of this debate is:  {inactive.Name}");
            inactive.GetExperience();

            return inactive;
        }

    }
}
