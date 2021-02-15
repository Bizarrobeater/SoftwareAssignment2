using System;
using System.Collections.Generic;

namespace SoftwareAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DIKUPerson> studentList = new List<DIKUPerson>
            {
                new DIKUStudent("John Doe", DIKUActivity.AttendingAll),
                new DIKUStudent("Jane Doe", DIKUActivity.AttendingNone),
                new DIKUStudent("Frank Buck", DIKUActivity.AttendingSome),
                //new DIKUStudent("Hireath Under", DIKUActivity.AttendingAll),
                //new DIKUStudent("Lacey Cuypers", DIKUActivity.AttendingAll),
                //new DIKUStudent("Fortune Marlowe", DIKUActivity.AttendingNone),
                //new DIKUStudent("Diana Peeters", DIKUActivity.AttendingSome),
                //new DIKUStudent("Jonas Alvin", DIKUActivity.AttendingAll),
                //new DIKUStudent("Samule Milford", DIKUActivity.AttendingAll),
                //new DIKUStudent("Carina Steffensen", DIKUActivity.AttendingNone),
                //new DIKUStudent("Vance Hüber", DIKUActivity.AttendingSome),
                //new DIKUStudent("Tobias Henning", DIKUActivity.AttendingAll),
            };

            Classroom storeKnirke = new Classroom();
            storeKnirke.RunDebate(studentList);


        }


        
    }
}
