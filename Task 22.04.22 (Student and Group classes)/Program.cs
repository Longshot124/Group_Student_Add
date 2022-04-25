using System;

namespace Task_22._04._22__Student_and_Group_classes_
{
    class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("p324",3);

            Student student = new Student();

            Console.WriteLine("Enter student name");
            student.Name = Console.ReadLine();

            Console.WriteLine("Enter student surname");
            student.Surname = Console.ReadLine();

            Student student2 = new Student();

            Console.WriteLine("Enter student name");
            student2.Name = Console.ReadLine();

            Console.WriteLine("Enter student surname");
            student2.Surname = Console.ReadLine();
            
            Student student3 = new Student();

            Console.WriteLine("Enter student name");
            student3.Name = Console.ReadLine();

            Console.WriteLine("Enter student surname");
            student3.Surname = Console.ReadLine();
            
            Student student4 = new Student();

            Console.WriteLine("Enter student name");
            student4.Name = Console.ReadLine();

            Console.WriteLine("Enter student surname");
            student4.Surname = Console.ReadLine();


            

            group.AddStudents(student);
            group.AddStudents(student2);
            group.AddStudents(student3);
            group.AddStudents(student4);
            
            
            
            


            
        }
    }
}
