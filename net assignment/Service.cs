using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_assignment
{
    class Service
    {
        public static int carsServiced = 0;
        
        public static int carsLeft = 0;

        public static int cost = 0;

        public static int carsInQueue = 0;

        static async Task CarArriving()
        {
            await Task.Delay(1500);

            carsInQueue++;

        }



    }
}
