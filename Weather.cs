using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    {
        // Member variables (has a)
        public string condition;
        public int temperature;
        private List<string> weatherConditions;

        //Conductor (spawns)

        public Weather()
        {
            weatherConditions = new List<string>() { "sunny", "raining", "cloudy" };
            GenerateRandomTemperature();
            GenrateRandomCondition();
        }


        // Member methods (can do)

        //random temperature generator
        public void GenerateRandomTemperature()
        {
            //generate a random number bettween 0 and 120 and display it
            Random random = new Random();
            temperature = random.Next(120);
            Console.WriteLine(temperature); 
        }

        //get condition

        public void GenrateRandomCondition()
        {
            Random random = new Random();
            int index = random.Next(weatherConditions.Count);
            condition = weatherConditions[index];
            Console.WriteLine(condition);
        }


    }
}
