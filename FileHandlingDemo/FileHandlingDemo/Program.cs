using System.IO;
using System.Security.AccessControl;
using ExceptionProjectLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        //WorkingWithFilesAndDirs();
        // WorkingWithFileInfoAndDirInfo();

        DateTime dt = new DateTime();

        //string s = DateTime.Now.ToShortDateString();
        //string s1 = DateTime.Now.ToLongTimeString();
        string date = DateTime.Now.ToString("yyyy/MM/ddHHmmssffff");

        string filename = string.Concat("customerLog.txt", date);
        //string path =  @"C:\\Users\\CDAC\\Desktop\\PriyaDotNet\\DemoFiles\\p1.txt";";
        string path = @"C:\Users\CDAC\Desktop\PriyaDotNet\DemoFiles\" + filename + ".txt";
        FileStream fs = null;
        StreamWriter sw = null;
        try
        {
            Customer customer = new Customer();
            Console.WriteLine("Enter customer id..");
            customer.Custid = Convert.ToInt32(Console.ReadLine());
        }
        catch (CustomerNotFoundException ex)
        {
            fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(ex.Message);
            Console.WriteLine("Completed...");
        }
        finally
        {
            sw.Flush();
            sw.Close();
            fs.Close();
            fs.Dispose();
        }
    }
    private static void WorkingWithFileInfoAndDirInfo()
    {
        FileInfo fi = new FileInfo("C:\\Users\\CDAC\\Desktop\\PriyaDotNet\\DemoFiles\\NewDemoFiles\\file1.txt");
        Console.WriteLine(fi.FullName);
        Console.WriteLine(fi.Extension);
        Console.WriteLine(fi.CreationTime);
        Console.WriteLine(fi.DirectoryName);
        FileSecurity fs = fi.GetAccessControl();
        Console.WriteLine(fs.AuditRuleType);
        DirectoryInfo di = new DirectoryInfo("C:\\Users\\CDAC\\Desktop\\PriyaDotNet\\DemoFiles\\NewDemoFiles\\");
        Console.WriteLine(di.FullName);
        Console.WriteLine(di.Parent);
        Console.WriteLine(di.Name);
        Console.WriteLine(di.CreationTime);
        Console.WriteLine(di.Root);
    }

    private static void WorkingWithFilesAndDirs()
    {
        string path = "C:\\Users\\CDAC\\Desktop\\PriyaDotNet\\DemoFiles\\";

        // string path = @"C:\Users\CDAC\Desktop\PriyaDotNet\DemoFiles";
        // string path = "C:/Users/CDAC/Desktop/PriyaDotNet/DemoFiles";
        //string path = @"D:\Demofiles\";

        //File.Create(path + " file1.txt");
        // File.AppendAllText(path + "file1.txt", "This is a file demo");
        //string p = string.Concat(path + "file1.txt");
        //string despath = string.Concat(path + "file2.txt");
        // File.Copy(p, despath);
        //File.Delete(despath);
        //string contents =File.ReadAllText(p);
        //Console.WriteLine(contents);

        //string src = path + "file1.txt";
        //string dest = path + "NewDemoFiles\\file1.txt";
        //File.Move(src,dest);

        //Directory.CreateDirectory(path + "Dir1");
        //File.Move(path + "file2.txt", path + "Dir1\\file2.txt");
        string[] files = Directory.GetFiles(path + "Dir1\\");
        foreach (string file in files)
        {
            Console.WriteLine(file);
        }
        string fullpath = "C:\\Users\\CDAC\\Desktop\\PriyaDotNet\\FileHandlingDemo\\FileHandlingDemo\\FileHandlingDemo.csproj";
        IEnumerable<string> dirs = Directory.EnumerateDirectories(fullpath);
        foreach (var item in dirs)
        {
            Console.WriteLine(item);
        }
    }
}