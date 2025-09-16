using DPM225502_LeKhanhVinh_Pattern01_AbstractFactory.Factories;

namespace DPM225502_LeKhanhVinh_Pattern01_AbstractFactory
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();
            // Abstract factory #2
            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();
            // Wait for user input
            Console.ReadKey();
        }
    }
}