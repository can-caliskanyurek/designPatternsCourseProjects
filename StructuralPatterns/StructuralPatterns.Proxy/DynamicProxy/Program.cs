using System;
using DynamicProxy.Classes;
using DynamicProxy.Interfaces;

namespace DynamicProxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            IBankAccount ba = Log<BankAccount>.As<IBankAccount>();

            ba.Deposit(100);
            ba.Withdraw(50);
            ba.Deposit(75);

            Console.WriteLine(ba);
        }
    }
}
