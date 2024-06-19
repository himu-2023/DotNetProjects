//using System.Runtime.Serialization.Json;
//using System.Xml.Serialization;
//using System.Runtime.Serialization.Formatters.Binary;


namespace ExceptionProjectLibrary
{
    public class Customer
    {
        int _custid;
        string _custname;
        string _city;
        public int Custid
        {
            get 
            { 
                
                return _custid;
            }
            set 
            {
                if (value > 0 && (value < 2000))
                {
                    _custid = value;
                   
                    
                }
                else if (value>2000)
                {
                    throw new CustomerNotFoundException("This is invalid");
                }
                else
                {
                    throw new ArgumentNullException("Customer id must be a +ve number");                                                                            
                }
               
            } 
        }
        public string CustName
        { 
            get
            { 
                return _custname;
            } 
                set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Customer name can not be null or empty");
                }
                else if (value.StartsWith(" "))
                {
                    throw new AccessViolationException("Name cannot starts with space");
                }
                else
                {
                    _custname = value;
                }
              
            }
        }
        public string City 
        {
            get
            {
                return _city;
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("City can not be empty");
                }
                else
                {
                    _city = value;
                }
               
            }
        }

    }
}
