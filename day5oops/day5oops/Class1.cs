using System;
using System.Collections.Generic;
using System.Text;

namespace day5oops
{
    class Student
    {
        int StudentID;
        string StudentName;
       string Studentbranch;
        string StudentGender;

        public void Getstudentdata()
        {
            Console.WriteLine("Please enter Student Id");
            StudentID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Student Name");
            StudentName = Console.ReadLine();
            Console.WriteLine("Please enter Student Salary");
            Studentbranch = Console.ReadLine();
            Console.WriteLine("Please enter Student Gender");
            StudentGender = Console.ReadLine();
        }

        public void ShowStudentData()
        {
            Console.WriteLine("Student Data :-");
            Console.WriteLine("Student Id : {0}", StudentID);
            Console.WriteLine("Student Name : {0}", StudentName);
            Console.WriteLine("Student Branch : {0}", Studentbranch);
            Console.WriteLine("Student Gender : {0}", StudentGender);

        }
    }
    class Class1
    {
        static void Main2(string[] args)
        {



            Student student = new Student();
            student.Getstudentdata();
            student.ShowStudentData();
            Console.WriteLine("Hello World!");
        }
    }
}
