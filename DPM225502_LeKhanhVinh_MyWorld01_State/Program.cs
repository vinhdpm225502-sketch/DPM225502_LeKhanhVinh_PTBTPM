using System.Security.Principal;

namespace DPM225502_LeKhanhVinh_MyWorld01_State
{
    public class Program
    {
        public static void Main()
        {
            // Open a new account
            var account = new Account("Jim Johnson");
            // Apply financial transactions
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);
            // Wait for user
            Console.ReadKey();
        }
    }
}