using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210201090_project
{
    public class DBTrans
    {
        public string dbPath;
        private SQLiteConnection conn;



        public DBTrans(string _dbPath)
        {
            this.dbPath = _dbPath;
        }

        public void Init()
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.CreateTable<Student>();
        }

        public List<Student> GetStudents()
        {
            Init();
            return conn.Table<Student>().ToList();
        }

        public void Add(Student student)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(student);
        }

        public void Delete(Student student)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(student);
        }

    }
}
