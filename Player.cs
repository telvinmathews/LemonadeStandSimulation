using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Player
    {
        // member variables (HAS A)
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;


        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            pitcher = new Pitcher();
        }

        // member methods (CAN DO)

        public void SetRecipe()
        {
            Console.WriteLine("How many lemons would you like per pitcher?");
            recipe.amountOfLemons = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many sugar cubes would you like per pitcher?");
            recipe.amountOfSugarCubes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many Ice cubes would you like per pitcher?");
            recipe.amountOfIceCubes = Convert.ToInt32(Console.ReadLine());
        }


    }
}
