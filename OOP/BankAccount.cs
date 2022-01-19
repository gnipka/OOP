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

        public long AccountNumber
        {
            get { return _AccountNumber; }
            set
            {
                if(value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), value, "Значение номера счета не может быть меньше нуля!");
                _AccountNumber = value;
            }
        }
        public double Balance { get => _Balance; set => _Balance = value; }
        public TypesOfBankAccount TypeOfBankAccount { get => _TypeOfBankAccount; set => _TypeOfBankAccount = value; }  
    }
}
