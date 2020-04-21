using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game
    {
        //Member variables(has a)
        Player player;
        List<Day> days;
        int currentDay;
        Store store;
        Inventory inventory;
        Customer customer;
        Weather weather;
        Pitcher pitcher;




        //Constuctor (spawn)
        public Game()
        {
            store = new Store();
            player = new Player();
            inventory = new Inventory();
            days = new List<Day>();//each day should have its own class??
            customer = new Customer();
            weather = new Weather();
            pitcher = new Pitcher();
        }
        //Member method (can do)
        public void CustomerBuyLemonad()
        {
            if ((weather.condition == "sunny" || weather.temperature >= 60) && pitcher.cupsLeftInPitcher > 0)
            {
                customer.willBuyLemonade = true;
            }

        }

        public void Rungame()
        {
            GoToStore();
        }

        public void GoToStore()
        {
            store.SellLemons(player);
            store.SellSugarCubes(player);
            store.SellCups(player);
            store.SellIceCubes(player);
        }
    }
}
