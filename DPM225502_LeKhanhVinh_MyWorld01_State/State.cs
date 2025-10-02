using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_State
{
    public abstract class State
    {
        protected double interest;
        protected double lowerLimit;
        protected double upperLimit;
        // Gets or sets the account
        public Account Account { get; set; } = null!;
        // Gets or sets the balance
        public double Balance { get; set; }
        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void PayInterest();
    }

}
