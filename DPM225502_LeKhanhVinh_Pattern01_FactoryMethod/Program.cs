using DPM225502_LeKhanhVinh_Pattern01_FactoryMethod.CreatorClass;
using DPM225502_LeKhanhVinh_Pattern01_FactoryMethod.ProductClass;

namespace DPM225502_LeKhanhVinh_Pattern01_FactoryMethod
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Creator[] creators = new Creator[2];
            
            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            foreach (var creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}",
                  product.GetType().Name);
            }

            Console.ReadKey();
        }
    }
}