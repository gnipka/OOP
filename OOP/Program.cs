using System;

namespace OOP_lesson2
{
    class Program
    {
        static string GetTypeBankAccount(TypesOfBankAccount typesOfBankAccount)
        {
            if (typesOfBankAccount == TypesOfBankAccount.Credit) 
                return "Кредитный";
            return "Дебетовый";
        }
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.AccountNumber = 1;
            bankAccount.Balance = 100000;
            bankAccount.TypeOfBankAccount = TypesOfBankAccount.Credit;

            Console.WriteLine($"Номер счета: {bankAccount.AccountNumber}    Баланс: {bankAccount.Balance}   Тип банковского счета: {GetTypeBankAccount(bankAccount.TypeOfBankAccount)}");
        }
    }
}
