using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    public class Student
    {
        public Student(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }

    public class Teacher
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
    }

    public  class Group
    {
        public List<Student> Students { get; set; }
        public Teacher Teacher { get; set; }
        public ushort Capacity { get; set; }
        public string Source = new string("Error out of range!");


        public string get_Source()
        {
             return Source;
        }
         
        public void AddStudent(Student newStudent)
        {
            if (Capacity >= Students.Count)
            {
                Students.Add(newStudent);
            }
            else
            {
                throw new StudentException() { HResult = 1, Source = "МЕСТ НЕТ!" };
            }
        }
    }
}
