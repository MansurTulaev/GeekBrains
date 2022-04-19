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
            Console.WriteLine($"Сравнение с методом Equals: {firstBankAccount.Equals(secondBankAccount)}");
            Console.WriteLine($"Сравнение с методом ==: {firstBankAccount==secondBankAccount}");
            Console.WriteLine($"Сравнение с методом !=: {firstBankAccount != secondBankAccount}");
            Console.WriteLine(firstBankAccount.ToString());
            Console.WriteLine(firstBankAccount.GetHashCode());
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

        public static bool operator ==(BankAccount firstAccount, BankAccount secondAccount)
        {
            if (firstAccount.Balance == secondAccount.Balance && firstAccount.Type == secondAccount.Type) return true;
            else return false;
        }

        public static bool operator !=(BankAccount firstAccount, BankAccount secondAccount)
        {
            if (firstAccount.Balance == secondAccount.Balance && firstAccount.Type == secondAccount.Type) return false;
            else return true;
        }

        public override string ToString()
        {
            return $"Номер аккаунта: {this.AccountId}. Тип: {this.Type}. Баланс: {this.Balance}";
        }

        public bool Equals(BankAccount otherObject)
        {
            if (this.Balance == otherObject.Balance && this.Type == otherObject.Type) return true;
            else return false; ;
        }

        public string GetHashCode()
        {
            return this.AccountId.ToString()+DateTime.Today.ToString("ddMMyyyy");
        }
    }
}
