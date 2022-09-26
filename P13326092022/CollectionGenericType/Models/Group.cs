using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionGenericType.Models
{
    class Group : ITest
    {
        public string No;
        public MyCollection<string> StudentsNames;
        public MyCollection<Test> Students;

        public Group()
        {
            StudentsNames = new MyCollection<string>();
            Students = new MyCollection<Student>();
        }
    }
}
