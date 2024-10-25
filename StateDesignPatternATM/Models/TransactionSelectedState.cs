using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternATM.Models
{
    public  class TransactionSelectedState : IATM
    {
        public void Handle(ATMMachine Machine)
        {
            Console.WriteLine("Transaction Selected: Take your cash");
            Machine.SetState(new CardInsertedState());
        }
    }
}
