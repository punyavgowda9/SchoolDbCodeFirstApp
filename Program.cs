using SchoolDbCodeFirstApp.Models;
using SchoolDbCodeFirstApp.Services;
using SchoolDbCodeFirstApp.Services;

SchoolDAL dal = new SchoolDAL();

// Example usage
dal.AddStudent(new Student
{
    Name = "Punya",
    RollNumber = 101,
    GradeId = 1
});

foreach (var s in dal.GetAllStudents())
{
    Console.WriteLine(value: $"{s.StudentId} - {s.Name}");
}
