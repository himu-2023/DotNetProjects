using SchoolMgtLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
       




       
        int choice = 3;
        switch (choice)
        {
            case 1:
                PhoneBookUsingHashTable p = new PhoneBookUsingHashTable();
                p.PopulateEntries();
                Console.WriteLine("Enter the number to fine the name");
                int k = Convert.ToInt32(Console.ReadLine());
                string name = p.FindName(k);
                Console.WriteLine(name);
                Console.WriteLine("===================");
               
                break;
            case 2:

                StudentSortedList student = new StudentSortedList();
                student.display();
                Console.WriteLine("====================");
                student.AddStudent(3, "Gauri");
                Console.WriteLine("===========");
                student.display();
                break;
            case 3:
                ArrayList demo1 = new ArrayList();
                ArrayList list = demo1.GetTheArrayList();
                foreach(var item in list)
                {
                    Console.WriteLine(item);
                }
                demo1.AddElements(4000);
                Console.WriteLine("=================");
                list = demo1.GetTheArrayList();
                foreach(var item in list)
                {
                    Console.WriteLine(item);
                }

                break;

            default:
                break;
        }
    }
}