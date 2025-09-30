namespace DPM225502_LeKhanhVinh_MyDream01_Singleton
{
    public class Program
    {
        /// <summary>
        /// Singleton Design Pattern
        /// </summary>
        public static void Main()
        {
            var b1 = LoadBalancer.GetLoadBalancer();
            var b2 = LoadBalancer.GetLoadBalancer();
            var b3 = LoadBalancer.GetLoadBalancer();
            var b4 = LoadBalancer.GetLoadBalancer();
            // Confirm these are the same instance
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }
            var balancer = LoadBalancer.GetLoadBalancer();
            // Load balance 15 requests for a server
            for (int i = 0; i < 15; i++)
            {
                var server = balancer.NextServer.Name;
                Console.WriteLine("Dispatch request to: " + server);
            }
            // Wait for user
            Console.ReadKey();
        }
    }
}