namespace SchoolDbCodeFirstApp.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int RollNumber { get; set; }

        public int GradeId { get; set; }
        public Grade grade { get; set; }
    }
}
