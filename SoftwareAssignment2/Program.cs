using System;


namespace SoftwareAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            DIKUPerson student = new DIKUStudent("Hans", DIKUActivity.AttendingAll);
            DIKUPerson professor = new DIKUProfessor("Frank", DIKUActivity.AttendingSome);

            Console.WriteLine(student);
            Console.WriteLine(professor);
        }


        
    }
}
