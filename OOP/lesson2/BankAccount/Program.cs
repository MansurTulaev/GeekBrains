using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
   //создание перечисления тип аккаунтов
   enum AccountTypes
    {
        Correspondent,
        Personal,
        Retirement
    }

    class Program
    {
        static void Main(string[] args)
        {
            //создание экземпляра класса, заполнение полей и вывод на экран
            BankAccount myBankAccount = new BankAccount();
            //myBankAccount.AccountId = 123; присвоение номера аккаунта до генерации уникальных номеров
            myBankAccount.Balance = 1000;
            myBankAccount.Type = (int)AccountTypes.Retirement;
            //Console.WriteLine($"Информация о счете. ID: {myBankAccount.AccountId}; Баланс: {myBankAccount.Balance}; Тип: {myBankAccount.Type}");
            Console.WriteLine($"Информация о счете. ID: {BankAccount._generatedId}; Баланс: {myBankAccount.Balance}; Тип: {myBankAccount.Type}");
            BankAccount bankAccount = new BankAccount();
            bankAccount.Balance = 2000;
            bankAccount.Type = (int)AccountTypes.Personal;
            Console.WriteLine($"Информация о счете. ID: {BankAccount._generatedId}; Баланс: {bankAccount.Balance}; Тип: {bankAccount.Type}");
            BankAccount constructorBankAccount = new BankAccount(300000, (int)AccountTypes.Correspondent);
            Console.WriteLine($"Информация о счете. ID: {BankAccount._generatedId}; Баланс: {constructorBankAccount.Balance}; Тип: {constructorBankAccount.Type}");
            Console.ReadKey();
        }
    }

    class BankAccount
    {
        //private int _accountId;
        private int _balance;
        private int _accountType;
        public static int _generatedId; //статическое поле

        /*Getter через метод
        * public int GetAccountId ()
        * { 
        * return _accountId;
        * }
        */

        /*Setter через метод
         * public int SetAccountId(int newAccountId)
         * {
         * this._accountId = newAccountId;
         * }
         */

        //Аналогичные методы для других полей

        //при инициализации увеличивается Id аккаунта
        public BankAccount()
        {
            GenerateId();
        }
        public BankAccount(int newBalance, int newType)
        {
            this._accountType = newType;
            this._balance = newBalance;
            GenerateId();
        }
         public static void GenerateId()
        {
            ++_generatedId;
        }

        /*public int AccountId
        {
            get 
            {
                return this._accountId;
            }

            set
            {
                this._accountId = value;
            }
        }
        */

        public int Balance
        {
            get
            {
                return this._balance;
            }

            set
            {
                this._balance = value;
            }
        }

        public int Type
        {
            get
            {
                return _accountType;
            }

            set
            {
                this._accountType = value;
            }
        }
    }
}
