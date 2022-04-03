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
            BankAccount firstBankAccount = new BankAccount(300000, (int)AccountTypes.Correspondent);
            BankAccount secondBankAccount = new BankAccount(400000, (int)AccountTypes.Correspondent);
            firstBankAccount.TransferMoney(100000, secondBankAccount);
            Console.ReadLine();

        }
    }

    class BankAccount
    {
        private int _balance;
        private int _accountType;
        public static int _generatedId; //статическое поле
        private int _accountId;

        public int AccountId { get; set; }
        public BankAccount()
        {
            GenerateId();
            this.AccountId = _generatedId;
        }
        public BankAccount(int newBalance, int newType)
        {
            this.Type = newType;
            this.Balance = newBalance;
            GenerateId();
            this.AccountId = _generatedId;
        }
         public static void GenerateId()
        {
            ++_generatedId;
        }
        public int Balance { get; set; }
        public int Type { get; set; }
        public void TransferMoney(int sum, BankAccount otherBankAccount)
        {
            if (this.Balance<sum)
            {
                Console.WriteLine("Transfer is not possible. You do not have enough money");
            }
            otherBankAccount.Balance += sum;
            this.Balance -= sum;
            Console.WriteLine($"Current ID {this.AccountId}. Balance: {this.Balance}. You transferred {sum} to other account");
            Console.WriteLine($"Other Account ID {otherBankAccount.AccountId}. Balance: {otherBankAccount.Balance}");
        }
    }
}
