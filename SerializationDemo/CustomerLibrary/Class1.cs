using System.Runtime.Serialization;

namespace CustomerLibrary
{

    [Serializable]
    public class Cust
    {

        public int CustId { get; set; }
        public string CustName { get; set; }

        [NonSerialized]
        private string _Pwd;
        public string Password
        {
            get { return _Pwd; }
            set { _Pwd = value; }
        }
    }
}
