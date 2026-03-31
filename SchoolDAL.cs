using Microsoft.Extensions.Configuration;
using SchoolDbCodeFirstApp.Models;
using SchoolDbCodeFirstApp.Services;

internal class SchoolDAL
{
    public string _ConStr;
    public SchoolDbContext Context;
    public SchoolDAL()
    {
        IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();
        _ConStr = config.GetConnectionString("SchoolCon");
        Context = new SchoolDbContext(_ConStr);
    }

    internal void AddStudent(Student student)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<object> GetAllStudents()
    {
        throw new NotImplementedException();
    }
}