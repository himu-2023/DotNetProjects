using SchoolMgtLibrary;
using System.Collections;

internal class Program
{
 private static void Main(string[] args)
    {


        //Stack s = new Stack();
        //s.Push(2);
        //s.Push(3.34f);
        //s.Push(3456);
        //foreach (var item in s)
        //{
        //    Console.WriteLine(item);
        //}
        //s.Pop();
        //s.Peek();
        //// Array array = Array.CreateInstance(typeof(object), 10);

        //object[] myarr = new object[5];
        //s.CopyTo(myarr, 0);
        //int cnt = s.Count;
        //object[] objArr = new object[cnt];
        //objArr = s.ToArray();

        //Queue queue = new Queue();
        //queue.Enqueue(1);
        //queue.Enqueue(2);
        //queue.Enqueue(3);
        //queue.Enqueue(3);
        //queue.Dequeue();
        //queue.Peek();

        Hashtable ht = new Hashtable();
        ht.Add(1, "A");
        ht.Add("1", "A");
        ht.Add(2, "B");
        ht.Add(3, "C");
        ht.Add(4,"D");
        ht.Add(5, "E");
        IDictionaryEnumerator ie = ht.GetEnumerator();
        while (ie.MoveNext())
        {
            Console.WriteLine(ie.Key + " " + ie.Value);

        }
        Console.WriteLine("===================");
        //String name = (String)ht[5];
        //Console.WriteLine(name);



        //WorkingWithArrays();
        StudentOperations operations = new StudentOperations();
        Console.WriteLine("1.Add Student \n 2.Edit Student \n 3.Get All Students \n 4.Delete all \n 5.Exit");
        int userChoice = Convert.ToInt32(Console.ReadLine());
        switch (userChoice)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:

                Student[] students = operations.GetStudents();
                foreach( var student in students)
                {
                    Console.WriteLine(student.RollNo);
                    Console.WriteLine(student.StudentName);
                    Console.WriteLine(student.City);
                }
                break;
            case 4:
                break;
            case 5:
                Environment.Exit(0);
                break;
            default:
                break;
        }
    }

    private static void WorkingWithArrays()
    {
        Console.WriteLine("Hello, World!");
        Object obj;
        // var o1 = "Priya";
        // dynamic o2 = obj as dynamic;
        int i = 10;
        obj = i;//Boxing
        Type t = obj.GetType();
        Console.WriteLine(t);

        float h = (float)obj;
        Console.WriteLine(h);
        Console.WriteLine(h.GetType());

        int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Array.Sort(arr);
        Array.Reverse(arr);
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }



        int[] arr2 = new int[5] { 11, 12, 13, 14, 15 };

        int[] arr3 = new int[5];
        arr[0] = 1;
        arr[1] = 2;
        arr[2] = 3;
        arr[3] = 4;
        arr[4] = 5;

        Array typedArray = Array.CreateInstance(typeof(int), 5);
        typedArray.SetValue(101, 0);
        typedArray.SetValue(102, 1);
        typedArray.SetValue(103, 2);
        typedArray.SetValue(104, 3);
        typedArray.SetValue(105, 4);
    }
}