using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionGenericType.Models
{
    class Teacher : ITest
    {
        public string Name;
        public MyCollection<string> GroupsNames;
        public MyCollection<double> Grades;

        public Teacher()
        {
            GroupsNames = new MyCollection<string>();
            Grades = new MyCollection<double>();
        }
    }
}
