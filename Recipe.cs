using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Recipe
    {
        //member variables (has a)
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;
        //condutor (spawns)
        public Recipe()
        {

        }
        //member methods (can do)

        public void SetRecipe()
        {
            Console.WriteLine("How many lemons would you like per pitcher?");
            amountOfLemons = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( "How many sugar cubes would you like per pitcher?");
            amountOfSugarCubes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many Ice cubes would you like per pitcher?");
            amountOfIceCubes = Convert.ToInt32(Console.ReadLine());
        }
    }
}
