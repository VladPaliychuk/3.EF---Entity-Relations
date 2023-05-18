using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.DAL.Data.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public DateTime? Birthday { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime? RegisteredOn { get; set; }
        public ICollection<StudentCourse>? StudentCources { get; set; }
        public ICollection<HomeworkSubmission>? HomeworkSubmissions { get; set; }
    }
}
