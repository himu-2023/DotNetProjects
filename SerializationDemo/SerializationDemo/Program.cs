using CustomerLibrary;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("1.Binary Serialisation \n2.Binary Deserialisation \n3.XML Serialization \n4.XML Deserialization  \n5.JSON Serialization \n6.JSON Deserialization ");
        Console.WriteLine("Enter choice");
        int ch = Convert.ToInt32(Console.ReadLine());
        switch (ch)
        {
            case 1:
                FileStream fs = new FileStream("C:\\Users\\CDAC\\Desktop\\PriyaDotNet\\DemoFiles\\cust.dat", FileMode.Create, FileAccess.Write);
                Cust c = new Cust();
                c.CustId = (11);
                c.CustName = "Anil";
                c.Password = "password";
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, c);
                fs.Close();
                fs.Dispose();
                break;

            case 2:
                FileStream fs1 = new FileStream("C:\\Users\\CDAC\\Desktop\\PriyaDotNet\\DemoFiles\\cust.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf1 = new BinaryFormatter();
                Cust c1 = (Cust)bf1.Deserialize(fs1);
                Console.WriteLine(c1.CustId);
                Console.WriteLine(c1.CustName);
                Console.WriteLine(c1.Password);
                fs1.Close();
                fs1.Dispose();

                break;
            case 3:
                FileStream fs2 = new FileStream("C:\\Users\\CDAC\\Desktop\\PriyaDotNet\\DemoFiles\\custxmldata.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xser = new XmlSerializer(typeof(Cust));
                Cust c2 = new Cust();
                c2.CustId = 12;
                c2.CustName = "Neha";
                c2.Password = "password";
                xser.Serialize(fs2,c2);
                fs2.Close();
                break;
            case 4:
                FileStream fs3 = new FileStream("C:\\Users\\CDAC\\Desktop\\PriyaDotNet\\DemoFiles\\custxmldata.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xser1 = new XmlSerializer(typeof(Cust));
                Cust d = (Cust)xser1.Deserialize(fs3);
                Console.WriteLine(d.CustId);
                Console.WriteLine(d.CustName);
                Console.WriteLine(d.Password);
                fs3.Close();
                break;

            case 5:
                FileStream fs4 = new FileStream("C:\\Users\\CDAC\\Desktop\\PriyaDotNet\\DemoFiles\\custjsondata.json", FileMode.Create, FileAccess.Write);
                DataContractJsonSerializer data = new DataContractJsonSerializer(typeof(Cust));
                Cust d1 = new Cust();
                d1.CustId = 13;
                d1.CustName = "Siya";
                d1.Password = "password";
                MemoryStream ms = new MemoryStream();
                data.WriteObject(ms, d1);
                fs4.Write(ms.ToArray());
                fs4.Close();
                ms.Close();

                break;
            case 6:
                FileStream fs5 = new FileStream("C:\\Users\\CDAC\\Desktop\\PriyaDotNet\\DemoFiles\\custjsondata.json", FileMode.Open, FileAccess.Read);
                DataContractJsonSerializer data1 = new DataContractJsonSerializer(typeof(Cust));
                Cust d2 = (Cust)data1.ReadObject(fs5);
                Console.WriteLine(d2.CustId);
                Console.WriteLine(d2.CustName);
                Console.WriteLine(d2.Password);
                fs5.Close();
                break;
            default:
                break;

        }
    }
}