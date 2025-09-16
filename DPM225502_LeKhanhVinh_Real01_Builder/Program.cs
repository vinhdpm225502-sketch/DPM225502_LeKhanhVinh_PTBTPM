
using DPM225502_LeKhanhVinh_Real01_Builder.VehicleProduct;

namespace DPM225502_LeKhanhVinh_Real01_Builder
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            VehicleBuilder builder;
            // Create shop with vehicle builders
            Shop shop = new Shop();
            // Construct and display vehicles
            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            // Wait for user
            Console.ReadKey();
        }
    }
}