using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_State
{
    public class Account
    {
        private readonly string owner;
        // Constructor
        public Account(string owner)
        {
            // New accounts are 'Silver' by default
            this.owner = owner;
            this.State = new SilverState(0.0, this);
        }
        // Gets the balance
        public double Balance
        {
            get { return State.Balance; }
        }
        // Gets or sets state
        public State State { get; set; }
        public void Deposit(double amount)
        {
            State.Deposit(amount);
            Console.WriteLine($"Owner: {owner}");
            Console.WriteLine("Deposited {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status  = {0}", this.State.GetType().Name);
            Console.WriteLine("");
        }
        public void Withdraw(double amount)
        {
            State.Withdraw(amount);
            Console.WriteLine($"Owner: {owner}");
            Console.WriteLine("Withdrew {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status  = {0}\n", this.State.GetType().Name);
        }
        public void PayInterest()
        {
            State.PayInterest();
            Console.WriteLine("Interest Paid --- ");
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status  = {0}\n", this.State.GetType().Name);
        }
    }
}
