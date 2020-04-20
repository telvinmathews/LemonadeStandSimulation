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

        //Constuctor (spawn)
        public Game()
        {
            store = new Store();
            player = new Player();
            inventory = new Inventory();

        }
        //Member method (can do)

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
