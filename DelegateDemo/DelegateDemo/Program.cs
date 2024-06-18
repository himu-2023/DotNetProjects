
using DelegatesLibrary;
internal class Program
{
    private static void Main(string[] args)
    {
        Products p = new Products();
        ProductIDGeneration delObj = new ProductIDGeneration(p.GenerateId);
        int productid =delObj.Invoke();

        Console.WriteLine(productid);
        Console.WriteLine("=================================");
        productid = delObj.Invoke();
        Console.WriteLine(productid);
        Console.WriteLine("=================================");
        WorkingWithProductData[] delObj1 = new WorkingWithProductData[2] { p.AddProduct, p.UpdateProduct };
        WorkingWithProductData del=(WorkingWithProductData)MulticastDelegate.Combine(delObj1);
        del();


    }
}