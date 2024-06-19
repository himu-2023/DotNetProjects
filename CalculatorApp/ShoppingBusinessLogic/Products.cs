using System.Xml.Linq;

namespace ShoppingBusinessLogic
{


    public class Products
    {

        //write only
        private string _pwd;
        public string Password { set { _pwd = value; } }

        //readonly
        public float GST
        { get { return 5.0f; }
            /* private set { }*/
        }

        private string _Prodname;

        public string ProductName
        {
            get { return _Prodname; }
            set { _Prodname = value; }
        }
        public double Price { get; set; } =1.0D;
        public string UnitOfMeaserement { get; set; } = "unknown";
        
        private int _prodid;
        public int ProductId
        {
            get
            {
                return _prodid;
            }
            set
            {
                if (value > 0)
                {
                    _prodid = value;
                }
                else
                {
                    Console.WriteLine("Product is not valid.");
                }
                _prodid = value;
            }
        }

    }

}

