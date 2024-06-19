namespace SchoolMgtLibrary
{
    public class Student
    {
        public int RollNo { get; set; }
        public string StudentName { get; set; }
        public string City { get; set; }
        public Student()
        {

        }
        public Student(int rno,string sname,string city)
        {
            this.RollNo = rno;
            this.StudentName = sname;
            this.City = city;
        }
    }
}
