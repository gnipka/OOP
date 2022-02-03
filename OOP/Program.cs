using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace OOP_lesson2
{
    class Program
    {

        static void Main(string[] args)
        {
            var bankAccount1 = new BankAccount
            {
                AccountNumber = 1,
                TypeOfBankAccount = TypesOfBankAccount.Credit,
                Balance = 40000
            };
            var bankAccount2 = new BankAccount
            {
                AccountNumber = 1,
                TypeOfBankAccount = TypesOfBankAccount.Credit,
                Balance = 60000
            };
            var bankAccount3 = new BankAccount
            {
                AccountNumber = 2,
                TypeOfBankAccount = TypesOfBankAccount.Credit,
                Balance = 60000
            };
            bankAccount1.Equals(bankAccount2);
            bankAccount1.Equals(bankAccount3);
            bankAccount1.GetHashCode();
            bankAccount2.GetHashCode();
            bankAccount3.GetHashCode();
            Console.WriteLine(bankAccount1.ToString());
        }
    }
}
