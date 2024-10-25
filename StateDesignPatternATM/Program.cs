using StateDesignPatternATM.Models;

namespace StateDesignPatternATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATMMachine machine = new ATMMachine();
            machine.Change();
            machine.Change();
            machine.Change();
        }
    }
}
