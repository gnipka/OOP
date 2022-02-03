using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOP_lesson2
{
    /// <summary>
    /// Тип банковского счета (перечислимый тип)
    /// </summary>
    public enum TypesOfBankAccount { Debit, Credit };
    /// <summary>
    /// счет в банке
    /// </summary>
    public class BankAccount
    {
        /// <summary>
        /// Номер счета (счетчик)
        /// </summary>
        private static long _AccountNumberCount;
        /// <summary>
        /// Номер счета
        /// </summary>
        public long AccountNumber { get; set; }
        /// <summary>
        /// Баланс
        /// </summary>
        public double Balance { get; set; }
        /// <summary>
        /// Тип банковского счета (переменная)
        /// </summary>
        public TypesOfBankAccount TypeOfBankAccount { get; set; }
        /// <summary>
        /// Генерирует номер банковского счета
        /// </summary>
        /// <returns></returns>
        static private long GetAccountNumberPlusOne()
        {
            return _AccountNumberCount += 1;
        }
        public BankAccount() { }
        public BankAccount(double balance)
        {
            AccountNumber = GetAccountNumberPlusOne();
            Balance = balance;
            TypeOfBankAccount = default;
        }
        public BankAccount(TypesOfBankAccount typeOfBankAccount)
        {
            AccountNumber = GetAccountNumberPlusOne();
            Balance = default;
            TypeOfBankAccount = TypeOfBankAccount;
        }
        public BankAccount(double balance, TypesOfBankAccount typeOfBankAccount)
        {
            AccountNumber = GetAccountNumberPlusOne();
            Balance = balance;
            TypeOfBankAccount = typeOfBankAccount;
        }
        public BankAccount(int accountNumber, double balance, TypesOfBankAccount typeOfBankAccount)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            TypeOfBankAccount = typeOfBankAccount;
        }
        public void DepositSum(double sum)
        {
            Balance += sum;
        }
        public void TakeOutSum(double sum)
        {
            if (Balance >= sum) Balance -= sum;
            throw new ArgumentOutOfRangeException(nameof(Balance), Balance, "Нельзя снять сумму, которая больше, чем средств на счете.");
        }
        /// <summary>
        /// Перевод денег с одного счета на другой
        /// </summary>
        /// <param name="bankAccountA"></param>
        /// <param name="bankAccountB"></param>
        public void MoneyTransfer(BankAccount bankAccountA, BankAccount bankAccountB )
        {
            bankAccountB.Balance += bankAccountA.Balance;
            bankAccountA.Balance = 0;
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (GetType() != obj.GetType()) return false;
            var otherBankAccount = (BankAccount)obj;
            return otherBankAccount.AccountNumber == AccountNumber;

        }
        public override string ToString() => "";
    }
}
