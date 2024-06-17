using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210201090_project
{
    public class Course
    {
        [PrimaryKey]
        public string CourseCode { get; set; }
        public string CourseName { get; set; }

    }
}
