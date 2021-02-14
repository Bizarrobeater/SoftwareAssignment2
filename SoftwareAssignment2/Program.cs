using System;


namespace SoftwareAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            DIKUPerson student1 = new DIKUStudent("John Doe", DIKUActivity.AttendingAll);
            DIKUPerson student2 = new DIKUStudent("Jane Doe", DIKUActivity.AttendingNone);
            DIKUPerson student3 = new DIKUStudent("Frank Buck", DIKUActivity.AttendingSome);
            DIKUPerson professor = new DIKUStudent("Hireath Under", DIKUActivity.AttendingAll);

            Classroom storeKnirke = new Classroom();

            DIKUPerson semiFinalWinner1 = storeKnirke.Discuss(student1, student2);
            DIKUPerson semiFinalWinner2 = storeKnirke.Discuss(student3, professor);

            DIKUPerson finalWinner = storeKnirke.Discuss(semiFinalWinner1, semiFinalWinner2);

            Console.WriteLine($"Winner of the Final Discussion\n{finalWinner.Name.ToUpper()}");
        }


        
    }
}
