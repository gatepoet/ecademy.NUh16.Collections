using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var classRoom = new ClassRoom();

            classRoom.Register(new Student { Name = "Kristoffer", Age = 34 });
            classRoom.Register(new Student { Name = "Åge", Age = 54 });
            classRoom.Register(new Student { Name = "Stine", Age = 44 });

            Console.WriteLine("Gjennomsnittlig alder: " + classRoom.AverageStudentAge);

            Console.ReadKey();
        }
    }
}
