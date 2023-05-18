using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.DAL.Data.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string? Description { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Name { get; set; }
        public int? Price { get; set; }
        public DateTime? StartDate { get; set; }
        public ICollection<Resource>? Resources { get; set; }
        public ICollection<HomeworkSubmission>? HomeworkSubmissions { get; set; }
        public ICollection<StudentCourse>? StudentCources { get; set; }
    }
}
