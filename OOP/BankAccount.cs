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
        private long _AccountNumber;
        /// <summary>
        /// Баланс
        /// </summary>
        private double _Balance;
        /// <summary>
        /// Тип банковского счета (переменная)
        /// </summary>
        private TypesOfBankAccount _TypeOfBankAccount;
        /// <summary>
        /// Генерирует номер банковского счета
        /// </summary>
        /// <returns></returns>
        static private long GetAccountNumberPlusOne()
        {
            return _AccountNumberCount += 1;
        }
        public BankAccount() { }
        public BankAccount(double Balance)
        {
            _AccountNumber = GetAccountNumberPlusOne();
            _Balance = Balance;
            _TypeOfBankAccount = default;
        }
        public BankAccount(TypesOfBankAccount TypeOfBankAccount)
        {
            _AccountNumber = GetAccountNumberPlusOne();
            _Balance = default;
            _TypeOfBankAccount = TypeOfBankAccount;
        }
        public BankAccount(double Balance, TypesOfBankAccount TypeOfBankAccount)
        {
            _AccountNumber = GetAccountNumberPlusOne();
            _Balance = Balance;
            _TypeOfBankAccount = TypeOfBankAccount;
        }

        public double Balance { get => _Balance; set => _Balance = value; }
        public TypesOfBankAccount TypeOfBankAccount { get => _TypeOfBankAccount; set => _TypeOfBankAccount = value; }
        public long AccountNumber { get => _AccountNumber; set => _AccountNumber = value; } 

        public void DepositSum(double sum)
        {
            _Balance += sum;
        }

        public void TakeOutSum(double sum)
        {
            if (_Balance >= sum) _Balance -= sum;
            throw new ArgumentOutOfRangeException(nameof(_Balance), _Balance, "Нельзя снять сумму, которая больше, чем средств на счете.");
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
    }
}
