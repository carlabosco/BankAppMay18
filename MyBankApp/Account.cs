using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp
{
    #region Properties
    class Account
    {
        public int AccountNumber { get; private set; }
        public string EmailAddress { get; set; }
        public decimal Balance { get; private set; }
        public string TypeOfAccount { get; set; }
        public DateTime CreatedDate { get; set; }

        #region Methods
        /// <summary>
        /// Deposit money into account
        /// </summary>
        /// <param name="amount">Amount to deposit</param>
        /// <returns>Updated balance</returns>
        public decimal Deposit(decimal amount)
        {
            Balance += amount;
            return Balance;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        #endregion
    }
    #endregion
}
