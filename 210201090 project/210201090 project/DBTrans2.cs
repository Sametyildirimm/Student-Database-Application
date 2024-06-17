using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210201090_project
{
    public class DBTrans2
    {
        public string dbPath1;

        private SQLiteConnection conn;

        public DBTrans2(string dbpath)
        {
            this.dbPath1 = dbpath;
        }

        public void Init()
        {
            conn = new SQLiteConnection(this.dbPath1);
            conn.CreateTable<Course>();
        }

        public List<Course> GetCourses()
        {
            Init();
            return conn.Table<Course>().ToList();
        }

        public void Add23(Course course)
        {
            conn = new SQLiteConnection(this.dbPath1);
            conn.Insert(course);
        }

        public void Delete(Course course)
        {
            conn = new SQLiteConnection(this.dbPath1);
            conn.Delete(course);
        }

    }
}
