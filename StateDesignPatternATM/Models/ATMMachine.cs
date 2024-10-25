using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternATM.Models
{
    public class ATMMachine
    {
        private IATM aTM;

        public ATMMachine() 
        {
            aTM = new CardInsertedState();
        }
        public void SetState(IATM atm)
        {
            aTM = atm;

        }
        public void Change()
        {
            aTM.Handle(this);
        }

    }
}
