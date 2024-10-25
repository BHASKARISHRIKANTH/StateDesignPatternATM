using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternATM.Models
{
    public class CardInsertedState : IATM
    {
        public void Handle(ATMMachine Machine)
        {
            Console.WriteLine("card inserted: Enter your pin");
            Machine.SetState( new PinEnteredState());
        }
    }
}
