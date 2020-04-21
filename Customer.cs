using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Customer
    {
        //member variable(has a)
        List<string> names;
        public string name;
        Random random = new Random();
        public bool willBuyLemonade;
        

        //conductor (spawn)

        public Customer()
        {
            names = new List<string>() {"pride", "envy", "greed"};
            name = names[random.Next(0,names.Count - 1)];
            willBuyLemonade = false;
            
        }

        //member method (can do)

       /* public bool BuyLemonade(Customer customer)
        {
            if (customer.willBuyLemonade == false)
            {
                customer.willBuyLemonade = true;
            }
            return customer.willBuyLemonade;
        }*/

        
    }
}
