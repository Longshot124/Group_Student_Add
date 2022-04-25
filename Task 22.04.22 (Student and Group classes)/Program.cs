using System;

namespace Task_22._04._22__Student_and_Group_classes_
{
    class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("p324",3);

            Student student = new Student("Kamran", "Qasimov");
            Student student1 = new Student("Elshan", "Aliyev");
            Student student2 = new Student("Ismayil", "Ibrahimli");
            Student student3 = new Student("Hesen", "Umudov");


            group.AddStudents(student);
            group.AddStudents(student1);
            group.AddStudents(student2);
            group.AddStudents(student3);
        }
    }
}
