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
        Recipe recipe;




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
            recipe = new Recipe();
        }
        //Member method (can do)
        public void ProbilityToBuyLemonade()
        {
            //if weather is "sunny" && price per cup is > 25
                //chance of buying lemonade is decreased by 20 
                //willingness to pay decrease to 30
            //if weather is "rainnig  && price per cup is > 20
                //chance of buying lemonade is decreased by 50 
                //willingness to pay is 20
            // if weather is "cloudy" && price per cup is > 20
                //chance of buying lemonade is decreased by 30
                //willingness to pay is 25

            if (weather.condition == "sunny" && recipe.pricePerCup > 20)
            {
                customer.chanceOfBuyingLemonade = 80;
                customer.willingToPay = 30;
            }
            else if (weather.condition == "rainnig" && recipe.pricePerCup > 20)
            {
                customer.chanceOfBuyingLemonade = 50;
                customer.willingToPay = 20;
            }
            else if (weather.condition == "cloudy" && recipe.pricePerCup > 20)
            {
                customer.chanceOfBuyingLemonade = 70;
                customer.willingToPay = 25;
            }
            else
            {
                customer.chanceOfBuyingLemonade = 100;
                customer.willingToPay = 40;
            }
        }
        public void CustomerBuyLemonad()
        {
            if ((weather.condition == "sunny" || weather.temperature >= 65) && pitcher.cupsLeftInPitcher > 0 && recipe.pricePerCup <= 40)
            {
                customer.willBuyLemonade = true;
            }
            else if ((weather.condition == "raining" || weather.temperature < 65) && pitcher.cupsLeftInPitcher > 0 && recipe.pricePerCup <= 21)
            {
                customer.willBuyLemonade = true;
            }
            else if ((weather.condition == "cloudy" || weather.temperature >= 60) && pitcher.cupsLeftInPitcher > 0 && recipe.pricePerCup <= 30)
            {
                customer.willBuyLemonade = true;
            }
            else
            {
                customer.willBuyLemonade = false;
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
