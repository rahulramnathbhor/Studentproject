using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Studentproject
{
    internal class Student
    {
        int id, age;
        string name, address;
        public void AssignValue()
        {
            id = 11;
            name = "Shubhangi";
            age = 21;
            address = "D.Awari";
        }
        public string DisplayValue()
        {
            return $"Student detail:{id}/{name}/{age}/{address}";
        }


    }
}
