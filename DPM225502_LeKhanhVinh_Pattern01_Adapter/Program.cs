namespace DPM225502_LeKhanhVinh_Pattern01_Adapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create adapter and place a request
            Target target = new Adapter();
            target.Request();
            // Wait for user
            Console.ReadKey();
        }
    }
}