﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {
        //Member Variables (has a)
        public Weather weather;
        public List<Customer> customers;

        //conductor (spawns)
        public Day()
        {
            weather = new Weather();
            customers = new List<Customer>();
        }
        //Member methods (can do)
    }
}
