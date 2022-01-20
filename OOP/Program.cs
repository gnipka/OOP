using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

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

        public static void SerializeToXml(ListBankAccount listBankAccount, string pathName)
        {
            StringWriter stringWriterNewIsDone = new StringWriter();
            XmlSerializer serializerNewIsDone = new XmlSerializer(typeof(ListBankAccount));
            serializerNewIsDone.Serialize(stringWriterNewIsDone, listBankAccount);
            string xmlNewIsDone = stringWriterNewIsDone.ToString();
            File.WriteAllText(pathName, xmlNewIsDone);
        }

        public static ListBankAccount DeserializeFromXml(string pathName)
        {

            string xmlText = File.ReadAllText(pathName);
            StringReader stringReader = new StringReader(xmlText);
            XmlSerializer serializer = new XmlSerializer(typeof(ListBankAccount));
            return (ListBankAccount)serializer.Deserialize(stringReader);

        }

        public static bool IsNum(string str)
        {
            int num;
            bool isNum = int.TryParse(str, out num);
            if (isNum)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Введенное значение не является числом.");
                return false;
            }
        }

        static void Main(string[] args)
        {
            //Задание 1
            //BankAccount bankAccount = new BankAccount();
            //bankAccount.AccountNumber = 1;
            //bankAccount.Balance = 100000;
            //bankAccount.TypeOfBankAccount = TypesOfBankAccount.Credit;

            //Console.WriteLine($"Номер счета: {bankAccount.AccountNumber}    Баланс: {bankAccount.Balance}   Тип банковского счета: {GetTypeBankAccount(bankAccount.TypeOfBankAccount)}");

            //Задание 3

            //BankAccount bankAccountA = new BankAccount(100000, TypesOfBankAccount.Credit);
            //BankAccount bankAccountB = new BankAccount(TypesOfBankAccount.Debit);
            //BankAccount bankAccountC = new BankAccount(200000);

            //Console.WriteLine($"Номер счета: {bankAccountA.AccountNumber}    Баланс: {bankAccountA.Balance}   Тип банковского счета: {GetTypeBankAccount(bankAccountA.TypeOfBankAccount)}");
            //Console.WriteLine($"Номер счета: {bankAccountB.AccountNumber}    Баланс: {bankAccountB.Balance}   Тип банковского счета: {GetTypeBankAccount(bankAccountB.TypeOfBankAccount)}");
            //Console.WriteLine($"Номер счета: {bankAccountC.AccountNumber}    Баланс: {bankAccountC.Balance}   Тип банковского счета: {GetTypeBankAccount(bankAccountC.TypeOfBankAccount)}");

            while (true)
            {
                Console.WriteLine("0. Выйти из программы");
                Console.WriteLine("1. Показать список банковских счетов");
                Console.WriteLine("2. Добавить банковский счет");
                Console.WriteLine("3. Снять со счета");
                Console.WriteLine("4. Положить на счет");
                string answer = Console.ReadLine();
                string pathName = "BankAccounts.xml";

                ListBankAccount listBankAccount = new ListBankAccount();

                switch (answer.Trim())
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        if (listBankAccount.BankAccounts != null)
                        {
                            listBankAccount.BankAccounts.Clear();
                        }
                        if (File.Exists(pathName))
                        {
                            listBankAccount = DeserializeFromXml(pathName);
                            for (int i = 0; i < listBankAccount.BankAccounts.Count; i++)
                            {
                                Console.WriteLine($"Номер банковского счета: {listBankAccount.BankAccounts[i].AccountNumber}    Баланс: {listBankAccount.BankAccounts[i].Balance}   Тип банковского счета: {GetTypeBankAccount(listBankAccount.BankAccounts[i].TypeOfBankAccount)}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Список банковских счетов пуст.");
                        }
                        break;
                    case "2":
                        if (listBankAccount.BankAccounts != null)
                        {
                            listBankAccount.BankAccounts.Clear();
                        }
                        listBankAccount.BankAccounts = new List<BankAccount>();
                        if (File.Exists(pathName))
                        {
                            listBankAccount = DeserializeFromXml(pathName);
                        }
                        Console.WriteLine("Введите баланс на банковском счете: ");
                        string balance = Console.ReadLine();
                        while (!IsNum(balance))
                        {

                        }
                        Console.WriteLine("Введите 1 - Кредитный, 2 - Дебетовый");
                        string typeOfBankAccount = Console.ReadLine();
                        TypesOfBankAccount typesOfBankAccount = new TypesOfBankAccount();
                        while (true)
                        {
                            if(typeOfBankAccount.Trim() == "1")
                            {
                                typesOfBankAccount = TypesOfBankAccount.Credit;
                                break;
                            }
                            else if(typeOfBankAccount.Trim() == "2")
                            {
                                typesOfBankAccount = TypesOfBankAccount.Debit;
                                break;
                            }
                            Console.WriteLine("Введите 1 - Кредитный, 2 - Дебетовый");
                        }
                        BankAccount bankAccount = new BankAccount(Convert.ToDouble(balance), typesOfBankAccount);
                        listBankAccount.BankAccounts.Add(bankAccount);
                        SerializeToXml(listBankAccount, pathName);
                        break;
                    case "3":
                        if (listBankAccount.BankAccounts != null)
                        {
                            listBankAccount.BankAccounts.Clear();
                        };
                        if (File.Exists(pathName))
                        {
                            listBankAccount = DeserializeFromXml(pathName);
                            for (int i = 0; i < listBankAccount.BankAccounts.Count; i++)
                            {
                                Console.WriteLine($"Номер банковского счета: {listBankAccount.BankAccounts[i].AccountNumber}    Баланс: {listBankAccount.BankAccounts[i].Balance}   Тип банковского счета: {GetTypeBankAccount(listBankAccount.BankAccounts[i].TypeOfBankAccount)}");
                            }
                            Console.WriteLine("Введите номер счета с которого необходимо снять деньги");
                            string number = Console.ReadLine();
                            BankAccount bankAccountDeposit;
                            if (IsNum(number))
                            {
                                bankAccountDeposit = listBankAccount.BankAccounts.Find(x => x.AccountNumber == Convert.ToInt64(number));
                                if (bankAccountDeposit != null)
                                {
                                    Console.WriteLine("Введите сумму, которую необходимо снять со счета: ");
                                    string sum = Console.ReadLine();
                                    if (IsNum(number))
                                    {
                                        bankAccountDeposit.TakeOutSum(Convert.ToDouble(number));
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"Банковского счета с номером {number} не существует");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Список банковских счетов пуст.");
                        }
                        break;

                }
            }
        }
    }
}
