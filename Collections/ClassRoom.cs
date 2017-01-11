using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class ClassRoom
    {
        private Dictionary<string, Student> students = new Dictionary<string, Student>();

        public void Register(Student student)
        {
            if (!students.ContainsValue(student))
            {
                student.ClassRoom = this;
                students.Add(student.Name, student);
            }
        }

        public IReadOnlyList<Student> Students
        {
            get
            {
                return students.Values.ToList();
            }
        }

        public int AverageStudentAge
        {
            get
            {
                var average = students.Values.Average(person => person.Age);
                return (int) Math.Round(average);
            }
        }

        public int RegisteredStudents
        {
            get
            {
                return students.Count;
            }
        }

        public bool IsRegistered(string name)
        {
            return students.ContainsKey(name);
        }

        public Student GetStudentByName(string name)
        {
            if (students.ContainsKey(name))
            {
                return students[name];
            }

            return null;
        }
    }
}
