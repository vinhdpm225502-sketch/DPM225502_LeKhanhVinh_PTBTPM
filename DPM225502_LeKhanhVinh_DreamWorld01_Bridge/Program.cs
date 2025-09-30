namespace DPM225502_LeKhanhVinh_DreamWorld01_Bridge
{
    public class Program
    {
        public static void Main()
        {
            // Create RefinedAbstraction and
            // set ConcreteImplementor
            var customers = new Customers(
                new CustomersData("Chicago"));
            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");
            customers.ShowAll();
            // Wait for user
            Console.ReadKey();
        }
    }
}