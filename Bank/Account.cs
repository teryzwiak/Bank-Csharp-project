using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    abstract class Account
    {
        public int Id { get; }
        public string AccountNumber { get;  }
        public decimal Balance { get; protected set; }
        public string FirstName { get; }
        public string LastName { get; }
        public long Pesel { get; }

        public Account(int id, string firstName, string lastName, long pesel)
        {
            Id = id;
            AccountNumber = genearteAccountNumber(id);
            Balance = 0.0M;
            FirstName = firstName;
            LastName = lastName;
            Pesel = pesel;
        }

        public abstract string TypeName();

        public string GetFullName()
        {
            string fullName = string.Format("{0} {1}", FirstName, LastName);

            return fullName;
        }

        public string GetBalance()
        {
            string balance = string.Format("{0}zł", Balance);

            return balance;
        }

        public void ChangeBalance(decimal value)
        {
            Balance += value;
        }

        private string genearteAccountNumber(int id)
        {
            var accountNumber = string.Format("94{0:D10}", id);

            return accountNumber;
        }
    }
}