using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMgtLibrary
{
    public class StudentOperations
    {
        static Student[] studentList = new Student[3];
       // public static List<Student> studentList = new List<Student>();
        static StudentOperations()
        {
            studentList.Add (new Student(rno: 1, city: "Pune", sname: "Priya"));
            studentList.Add( new Student(2, "Nashi", "Siya"));
            studentList.Add(new Student(3, "Nagpur", "Jiya"));

        }  
        public void AddStudent(Student student)
        {
            //Student s = new Student(rno: student.RollNo, sname: student.StudentName, city: student.City);
            Student s = new Student();
            s.StudentName=student.
          
            studentList.Append(s);
        }
        public void UpdateStudent(Student student)
        {

        }
        public void DeleteStudent(Student student)
        {


        }
        public Student[] GetStudents()
        {
            return studentList;
        }
    }
}
