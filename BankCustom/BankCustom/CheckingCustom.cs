using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankCustom
{
    class CheckingCustom :Custom
    {
        static int newAccountNumber = 0;
        public CheckingCustom(double AccountBalance, string AccountName,int Accountnum)
        {
            this.accountBalance = AccountBalance;
            this.accountName = AccountName;
            //设置用户号合法性判断
            if(Accountnum<0||Accountnum>4999)
            {
                return;
            }
            CheckingCustom.newAccountNumber++;
        }
        public new void Withdraw(double DrawMoney)
        {
            accountBalance = accountBalance + accountBalance * 0.005;
            accountBalance = accountBalance - DrawMoney;
        }

    }
}
