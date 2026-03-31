using System.Collections.Generic;

namespace SchoolDbCodeFirstApp.Models
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string Section { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
