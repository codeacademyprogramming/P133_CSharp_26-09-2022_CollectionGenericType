using CollectionGenericType.Models;
using System;

namespace CollectionGenericType
{
    class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group();
            group.No = "P133";
            group.StudentsNames.Add("Samed");
            group.StudentsNames.Add("Orxan");
            group.StudentsNames.Add("Nurlan");

            string name = group.StudentsNames.Get(15);

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Deyeri NullDir");
            }

            Console.WriteLine();

            Console.WriteLine(group.StudentsNames.CheckValue("nurlan"));

            Teacher teacher = new Teacher();
            teacher.Name = "Hamid";
            teacher.GroupsNames.Add("P133");
            teacher.GroupsNames.Add("P229");

            Console.WriteLine(teacher.GroupsNames.Get(1));
        }
    }
}
