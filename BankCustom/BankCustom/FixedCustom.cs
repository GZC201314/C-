using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCustom
{
    class FixedCustom:Custom
    {
        public FixedCustom(double AccountBalance, string AccountName,int Accountnum)
        {
            this.accountBalance = AccountBalance;
            this.accountName = AccountName;
            if(Accountnum<5000||Accountnum>9999)
            {
                return;
            }
            else
                this.accountNumber = Accountnum;
        }
        public new void Withdraw(double DrawMoney)
        {
            if(accountBalance<500)
            {
                accountBalance = accountBalance + accountBalance * 0.03;
                accountBalance = accountBalance - DrawMoney;
            }
            else
            {
                accountBalance = accountBalance + accountBalance * 0.06;
                accountBalance = accountBalance - DrawMoney;
            }
        }

        public int accountNumber { get; set; }

        public int accountBalance { get; set; }
    }
}
