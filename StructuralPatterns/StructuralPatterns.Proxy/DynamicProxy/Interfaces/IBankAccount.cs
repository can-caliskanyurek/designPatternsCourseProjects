namespace DynamicProxy.Interfaces
{
    public interface IBankAccount
    {
        void Deposit(int amount);
        bool Withdraw(int amount);
    }
}