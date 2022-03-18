using MIWithDefaultInterfaceMembers.Interfaces;

namespace MIWithDefaultInterfaceMembers.Classes
{
    public class Dragon : Organism, IBird, ILizard
    {
        public int Age { get; set; }
    }
}
