using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lesson2
{
    public class ListBankAccount
    {
        public List<BankAccount> BankAccounts { get; set; }
        public ListBankAccount() { }
    }
}
