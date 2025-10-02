namespace DPM225502_LeKhanhVinh_MyWorld01_Proxy
{
    public class Program
    {
        public static void Main()
        {
            // Create math proxy
            var proxy = new MathProxy();
            // Do the math
            Console.WriteLine($"4 + 2 = {proxy.Add(4, 2)}");
            Console.WriteLine($"4 - 2 = {proxy.Sub(4, 2)}");
            Console.WriteLine($"4 * 2 = {proxy.Mul(4, 2)}");
            Console.WriteLine($"4 / 2 = {proxy.Div(4, 2)}");
            // Wait for user
            Console.ReadKey();
        }
    }
    /// <summary>
    /// The 'Subject' interface
    /// </summary>
    public interface IMath
    {
        double Add(double x, double y);
        double Sub(double x, double y);
        double Mul(double x, double y);
        double Div(double x, double y);
    }
}