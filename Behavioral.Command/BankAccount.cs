using System;

namespace Behavioral.Command
{
    public class BankAccount
    {
        private readonly int overdraftLimit = -500;
        private int _balance;

        public void Deposit(int amount)
        {
            _balance += amount;
            Console.WriteLine($"Deposited ${amount}, balance is now {_balance}");
        }

        public bool Withdraw(int amount)
        {
            if (_balance - amount >= overdraftLimit)
            {
                _balance -= amount;
                Console.WriteLine($"Withdrew ${amount}, balance is now {_balance}");
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"{nameof(_balance)}: {_balance}";
        }
    }
}