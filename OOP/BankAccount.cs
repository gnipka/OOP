using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        static private long _AccountNumberCount;
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

        static private long GetAccountNumber()
        {
            return _AccountNumberCount += 1;
        }
        public BankAccount(double Balance)
        {
            _AccountNumber = GetAccountNumber();
            _Balance = Balance;
            _TypeOfBankAccount = default;
        }
        public BankAccount(TypesOfBankAccount TypeOfBankAccount)
        {
            _AccountNumber = GetAccountNumber();
            _Balance = default;
            _TypeOfBankAccount = TypeOfBankAccount;
        }
        public BankAccount(double Balance, TypesOfBankAccount TypeOfBankAccount)
        {
            _AccountNumber = GetAccountNumber();
            _Balance = Balance;
            _TypeOfBankAccount = TypeOfBankAccount;
        }

        public long AccountNumber
        {
            get { return _AccountNumber; }
        }
        public double Balance { get => _Balance;}
        public TypesOfBankAccount TypeOfBankAccount { get => _TypeOfBankAccount;}
    }
}
