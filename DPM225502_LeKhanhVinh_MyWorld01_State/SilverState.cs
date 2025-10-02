using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_State
{
    public class SilverState : State
    {
        // Overloaded constructors
        public SilverState(State state) :
            this(state.Balance, state.Account)
        {
        }
        public SilverState(double balance, Account account)
        {
            Balance = balance;
            Account = account;
            Initialize();
        }
        private void Initialize()
        {
            // Should come from a datasource
            interest = 0.0;
            lowerLimit = 0.0;
            upperLimit = 1000.0;
        }
        public override void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck();
        }
        public override void Withdraw(double amount)
        {
            Balance -= amount;
            StateChangeCheck();
        }
        public override void PayInterest()
        {
            Balance += interest * Balance;
            StateChangeCheck();
        }
        private void StateChangeCheck()
        {
            if (Balance < lowerLimit)
            {
                Account.State = new RedState(this);
            }
            else if (Balance > upperLimit)
            {
                Account.State = new GoldState(this);
            }
        }
    }
}
