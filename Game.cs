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
        Day day;




        //Constuctor (spawn)
        public Game()
        {
            day = new Day();
            store = new Store();
            player = new Player();
            inventory = new Inventory();
            days = new List<Day>();
            customer = new Customer();
            weather = new Weather();
            pitcher = new Pitcher();
            recipe = new Recipe();
        }
        //Member method (can do)
        public void DisplayRules()
        {
            Console.WriteLine("Your goal is to make as much money as you can in 7, 14, or 30 days by selling lemonade at your lemonade stand.\n" +
                " Buy cups, lemons, sugar, and ice cubes, then set your recipe based on the weather and conditions.\n " +
                "Start with the basic recipe, but try to vary the recipe and see if you can do better.\n " +
                "Lastly, set your price and sell your lemonade at the stand.\n " +
                "Try changing up the price based on the weather conditions as well.\n " +
                "At the end of the game, you'll see how much money you made.\n" +
                " Write it down and play again to try and beat your score!");
        }
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
            DisplayRules();
            Console.WriteLine("How many days would you like to play?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < userInput; i++)
            {
                Day day = new Day();
                GoToStore();
                recipe.SetRecipe();
                ProbilityToBuyLemonade();
                CustomerBuyLemonad();
            }
            //loop for how many days i want game to run
            //create day
            //create day's worth of game functionality
            //end of loop, start next day
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
