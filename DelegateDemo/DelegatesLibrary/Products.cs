namespace DelegatesLibrary
{
    public  delegate int ProductIDGeneration();
    public delegate void WorkingWithProductData();
    public class Products
    {
        static int cnt = 0;
        public int GenerateId()
        {
            return ++cnt;
        }
        public void AddProduct()
        {
            Console.WriteLine("Product addd called");
        }
        public void UpdateProduct()
        {
            Console.WriteLine("Update Product called");
        }
    }
}
