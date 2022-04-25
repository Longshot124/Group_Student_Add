using System;
using System.Collections.Generic;
using System.Text;

namespace Task_22._04._22__Student_and_Group_classes_
{
    class Group
    {
        public string GroupNum;
        public byte StudentLimit;
        public Student[] _students;
        public Group(string grnumber,byte sdlim)
        {
            GroupNum = grnumber;
            StudentLimit = sdlim;
            _students = new Student[0];

        }


        public void AddStudents(Student student) 
        
        {
            if (StudentLimit>_students.Length)
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = student;
                Console.WriteLine("Student added");
            }
            else
            {
                Console.WriteLine("Group is full");
            }

        }

        public void GetStudents()
        {
            foreach (var students in _students)
            {
                Console.WriteLine(students.Name, students.Surname);
            }
        }

    }
    
}
