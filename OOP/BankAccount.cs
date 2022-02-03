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
    [Serializable]
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
        //[XmlElement("AccountNumber")]
        public long AccountNumber
        {
            get { return _AccountNumber; }
            set { }
        }
        //[XmlAttribute("Balance")]
        public double Balance { get => _Balance; set { } }
        //[XmlAttribute("TypeOfBankAccount")]
        public TypesOfBankAccount TypeOfBankAccount { get => _TypeOfBankAccount; set { } }

        public void DepositSum(double sum)
        {
            _Balance += sum;
        }

        public void TakeOutSum(double sum)
        {
            if (_Balance >= sum) _Balance -= sum;
            throw new ArgumentOutOfRangeException(nameof(_Balance), _Balance, "Нельзя снять сумму, которая больше, чем средств на счете.");
        }
        //Методы для заполнения и чтения (задание 1)
        //public long GetAccountNumber()
        //{
        //   return _AccountNumber;
        //}
        //public void SetAccountNumber(long value)
        //{
        //    _AccountNumber = value;
        //}
        //public double GetBalance()
        //{
        //    return _Balance;
        //}
        //public void SetBalance(double value)
        //{
        //    _Balance = value;
        //}
        //public TypesOfBankAccount GetTypeOfBankAccount()
        //{
        //    return _TypeOfBankAccount;
        //}
        //public void SetTypeOfBankAccount(TypesOfBankAccount value)
        //{
        //    _TypeOfBankAccount = value;
        //}
    }
}
