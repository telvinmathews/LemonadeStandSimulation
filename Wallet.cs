using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Wallet
    {
        private double money;
        // public double Money; come back to later gives an error?

        public double Money
        {
            get
            {
                return money;
            }
        }

        public Wallet()
        {
            money = 20.00;
        }

        public void PayMoneyForItems(double transactionAmount)
        {
            money -= transactionAmount;
        }
    }
}
