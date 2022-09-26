using CollectionGenericType.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionGenericType
{
    class Program
    {
        static void Main(string[] args)
        {
            //Group group = new Group();
            //group.No = "P133";
            //group.StudentsNames.Add("Samed");
            //group.StudentsNames.Add("Orxan");
            //group.StudentsNames.Add("Nurlan");

            //string name = group.StudentsNames.Get(15);

            //if (string.IsNullOrWhiteSpace(name))
            //{
            //    Console.WriteLine("Deyeri NullDir");
            //}

            //Console.WriteLine();

            //Console.WriteLine(group.StudentsNames.CheckValue("nurlan"));

            //Teacher teacher = new Teacher();
            //teacher.Name = "Hamid";
            //teacher.GroupsNames.Add("P133");
            //teacher.GroupsNames.Add("P229");

            //Console.WriteLine(teacher.GroupsNames.Get(1));

            //Write<string>("Hamid");
            //Write<bool>(true);
            //Write<double>(15.5);

            //String str = new String();


            #region Non Generic Type Collection
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("Test");
            //arrayList.Add(15);

            //ArrayList arrayList1 = new ArrayList();
            //arrayList1.AddRange(arrayList);
            //arrayList.Clear();

            //SortedList sortedList = new SortedList();
            //sortedList.Add(1, "Yeddi");
            //sortedList.Add(0, "Doqquz");
            //sortedList.Add(2, "Sekkiz");

            //foreach (var item in sortedList.Values)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < sortedList.Count; i++)
            //{
            //    Console.WriteLine($"{sortedList.Keys}");
            //}

            //FIFO - First In First Out
            //Queue queue = new Queue();
            //queue.Enqueue("Test");
            //queue.Enqueue(15);
            //queue.Enqueue(true);
            //queue.Enqueue(15.5);

            //Console.WriteLine(queue.Count);

            //var a = queue.Dequeue();
            //a = queue.Dequeue();

            //Console.WriteLine(a);

            //var a = queue.Peek();

            //Console.WriteLine(a);
            //Console.WriteLine(queue.Count);

            //LIFO - Last In First Out
            //Stack stack = new Stack();
            //stack.Push("Test");
            //stack.Push(15);
            //stack.Push(true);
            //stack.Push(15.5);

            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Count);
            //Console.WriteLine(stack.Peek());

            #endregion

            #region Generic Type Collection
            //List<string> strList = new List<string>();
            ////strList.Add("Test");
            //string[] arr = { };

            //var a= arr[0];
            //Console.WriteLine(strList[0]);

            //foreach (var item in strList)
            //{
            //    Console.WriteLine(item);
            //}
            //SortedList<int, string> myList = new SortedList<int, string>();

            //myList.Add(54654,"Test");

            //Dictionary<string, string> myList = new Dictionary<string, string>();
            //myList.Add("bir", "Birinci");

            //foreach (var item in myList)
            //{
            //    Console.WriteLine($"{item.Key} {item.Value}");
            //}

            //Queue<string> myList = new Queue<string>();
            //myList.Enqueue("Test");

            Stack<string> myList = new Stack<string>();

            myList.Push("Test");
            #endregion
        }

        //static void Write<T,U>(T str) /*where T : c*/
        //{
        //    Console.WriteLine(str);
        //}

        //static void Write(bool val)
        //{

        //}
    }
}
