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
            //Задание 1

            //BankAccount bankAccount = new BankAccount();
            //bankAccount.AccountNumber = 1;
            //bankAccount.Balance = 100000;
            //bankAccount.TypeOfBankAccount = TypesOfBankAccount.Credit;

            //Console.WriteLine($"Номер счета: {bankAccount.AccountNumber}    Баланс: {bankAccount.Balance}   Тип банковского счета: {GetTypeBankAccount(bankAccount.TypeOfBankAccount)}");

            //Задание 2

            BankAccount bankAccountA = new BankAccount(100000, TypesOfBankAccount.Credit);
            BankAccount bankAccountB = new BankAccount(TypesOfBankAccount.Debit);
            BankAccount bankAccountC = new BankAccount(200000);

            Console.WriteLine($"Номер счета: {bankAccountA.AccountNumber}    Баланс: {bankAccountA.Balance}   Тип банковского счета: {GetTypeBankAccount(bankAccountA.TypeOfBankAccount)}");
            Console.WriteLine($"Номер счета: {bankAccountB.AccountNumber}    Баланс: {bankAccountB.Balance}   Тип банковского счета: {GetTypeBankAccount(bankAccountB.TypeOfBankAccount)}");
            Console.WriteLine($"Номер счета: {bankAccountC.AccountNumber}    Баланс: {bankAccountC.Balance}   Тип банковского счета: {GetTypeBankAccount(bankAccountC.TypeOfBankAccount)}");

        }
    }
}
