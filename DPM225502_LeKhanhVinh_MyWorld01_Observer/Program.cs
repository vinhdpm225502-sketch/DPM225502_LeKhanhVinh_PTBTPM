﻿namespace DPM225502_LeKhanhVinh_MyWorld01_Observer
{
    public class Program
    {
        public static void Main()
        {
            // Create IBM stock and attach investors
            var ibm = new IBM(120.00);
            // Attach 'listeners', i.e. Investors
            ibm.Attach(new Investor { Name = "Sorros" });
            ibm.Attach(new Investor { Name = "Berkshire" });
            // Fluctuating prices will notify listening investors
            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;
            // Wait for user
            Console.ReadKey();
        }
    }
    public interface IInvestor
    {
        void Update(object sender, ChangeEventArgs e);
    }
}