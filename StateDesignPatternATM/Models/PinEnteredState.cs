using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternATM.Models
{
    public class PinEnteredState : IATM
    {
        public void Handle(ATMMachine Machine)
        {
            Console.WriteLine("Pin entered: Select a transaction");
            Machine.SetState(new TransactionSelectedState());
        }
    }
}
