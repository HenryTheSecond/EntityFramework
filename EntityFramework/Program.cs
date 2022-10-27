using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (EF_Demo_DBEntities DBEntities = new EF_Demo_DBEntities())
            {
                List<Student> students = DBEntities.Students.ToList();
                foreach (Student student in students)
                {
                    Console.WriteLine($"{student.LastName} {student.FirstName}");
                }
            }
        }
    }
}
