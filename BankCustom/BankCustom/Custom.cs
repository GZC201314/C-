using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCustom
{
    class Custom
    {
        public string accountName;
        public int accountNumber;
        public double accountBalance;
        public void Deposit(double SaveMoney)
        {
            accountBalance = accountBalance + SaveMoney;
        }
        public void SetName(string Name)
        {
            this.accountName = Name;
        }
        public string GetName()
        {
            return(this.accountName);
        }
        public void SetBalance(double Balance)
        {
            this.accountBalance = Balance;
        }
        public double GetBalance()
        {
            return(this.accountBalance);
        }


        public void Withdraw(double DrawMoney)
        {
            accountBalance = accountBalance - DrawMoney;
        }

    }
}
