namespace DPM225502_LeKhanhVinh_MyDream01_Facade
{
    public class Program
    {
        static void Main()
        {
            // Facade
            var mortgage = new Mortgage();
            // Evaluate mortgage eligibility for customer
            var customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);
            string result = eligible ? "Approved" : "Rejected";
            Console.WriteLine($"\n{customer.Name} has been {result}");
            // Wait for user
            Console.ReadKey();
        }
    }
    /// <summary>
    /// Customer class
    /// </summary>
    public record Customer(string Name);
}