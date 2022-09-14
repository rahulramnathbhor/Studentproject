using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Studentproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.AssignValue();
            string student = student.DisplayValue();
            Console.WriteLine(student);
        }
    }
}
