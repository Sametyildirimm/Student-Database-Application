﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210201090_project
{
    public class Student
    {
        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

    }
}
