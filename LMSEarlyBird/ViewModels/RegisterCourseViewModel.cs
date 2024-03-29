using LMSEarlyBird.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSEarlyBird.ViewModels
{
    public class RegisterCourseViewModel
    {
        public int Id {get; set;}
        public string CourseName { get; set; } = string.Empty;
        public string CourseNumber { get; set; } = string.Empty;
        public int CreditHours { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public bool IsRegistered { get; set; } 

        public string InstructorName { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;

        public string DaysOfWeek { get; set; } = string.Empty;

        public List<StudentAssignment> StudentAssignment { get; set; } = new List<StudentAssignment>();
    }
}