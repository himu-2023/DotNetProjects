using ExceptionProjectLibrary;
internal class Program
{
    private static void Main(string[] args)
    {
		Customer c = new Customer();
		try
		{
			Console.WriteLine("Enter the customer id");
			c.Custid = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the customer name");
			c.CustName = Console.ReadLine();
            Console.WriteLine("Enter the customer city");
            c.City = Console.ReadLine();
        }
		catch (ArgumentNullException ex)
		{
			Console.WriteLine(ex.Message);
			
		}
        catch (AccessViolationException ex)
        {
            Console.WriteLine(ex.Message);


        }
        catch (CustomerNotFoundException ex)
        {
            Console.WriteLine(ex.Message);

        }
        finally
		{
			Console.WriteLine("Finally block...");
		}
    }
}