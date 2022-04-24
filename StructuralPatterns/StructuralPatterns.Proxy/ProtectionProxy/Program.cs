using ProtectionProxy.Classes;
using ProtectionProxy.Interfaces;

namespace ProtectionProxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICar car = new CarProxy(new Driver(12)); // 22
            car.Drive();
        }
    }
}
