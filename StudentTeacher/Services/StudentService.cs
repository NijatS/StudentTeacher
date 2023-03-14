using StudentTeacher.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentTeacher.Core.Models;
using StudentTeacher.Extentions;

namespace StudentTeacher.Services
{
    internal class StudentService :IService
    {
        Student[] students = { };
        public void Create()
        {
            Student student = new Student();
            Array.Resize(ref students, students.Length + 1);
            Console.Write("Student Name : ");
            string name = Console.ReadLine();
            Console.Write("Student Surname : ");
            string surname = Console.ReadLine();
            Console.Write("Group No : ");
            string groupNo = Console.ReadLine();

            while (!name.CheckName() || !surname.CheckName() || string.IsNullOrWhiteSpace(groupNo))
            {
                Console.WriteLine("Again!!!");
                Console.Write("Student Name : ");
                name = Console.ReadLine();
                Console.Write("Student Surname : ");
                surname = Console.ReadLine();
                Console.Write("Group No : ");
                groupNo = Console.ReadLine();
            }
            student.Surname = surname;
            student.Name = name;
            student.GroupNo = groupNo;
            students[students.Length - 1] = student;
        }

        public void Delete()
        {
            if (students.Length > 0)
            {
                Console.Write("Please enter ID : ");
                int id = int.Parse(Console.ReadLine());
                foreach (Student student in students)
                {
                    if (id == student.Id)
                    {
                        int index = Array.IndexOf(students, student);
                        students = students.Remove(index, students.Length - 1);
                        Console.WriteLine("Removing was successful");
                        return;
                    }
                }
                Console.WriteLine("Not Finding...");
            }
            else
            {
                Console.WriteLine("Student List is empty.Please Add Student...");
            }
            
        }

        public void GetById()
        {
            if (students.Length > 0)
            {
                Console.Write("Please Add Id : ");
                int id = int.Parse(Console.ReadLine());

                foreach (Student student in students)
                {
                    if (id == student.Id)
                    {
                        Console.WriteLine(student);
                        return;
                    }
                }
                Console.WriteLine("Not Finding...");
            }
            else { Console.WriteLine("Student List is empty.Please Add Student..."); }
        }
        public void Show()
        {
            if (students.Length > 0)
            {
                foreach (Student student in students)
                {
                    Console.WriteLine(student);
                }
            }
            else { Console.WriteLine("Student List is empty.Please Add Student..."); }
        }
    }
}

