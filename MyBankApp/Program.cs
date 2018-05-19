using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp
{
    class Program
    {
        static void Main(string[] args)
        {   
            //instantiation
            var account = new Account();
            //account.AccountNumber = 12345;    user cannot set account number
            account.EmailAddress = "test@test.com";
            account.TypeOfAccount = "Checking";
            //account.Balance = 10000000; user cannot set balance
        }
    }
}
