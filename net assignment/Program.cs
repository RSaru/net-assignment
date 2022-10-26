using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Implements timers
using Timer = System.Timers.Timer;



namespace net_assignment
{
    internal class Program
    {
        //Defines the timer for cars arriving
        public static Timer carArrival;

        //Defines the Method for cars being generated
        public static void carPullUp()
        {
            //Sets the amount of time before a new car is made
            carArrival = new Timer(1500);
            carArrival.Elapsed += CarArrival_Elapsed;
            carArrival.AutoReset = true;
            carArrival.Enabled = true;
            carArrival.Start();
        }

        private static void CarArrival_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Car has arrived");
        }
        //Defines the timer for the cars leaving the pump
        public static Timer carLeave;
        //Defines the method for the cars leaving the pump
        public static void carGo()
        {
            //Sets the amount of time before a new car is made
            carLeave = new Timer(8000);
            carLeave.Elapsed += carLeave_Elapsed;
            carLeave.AutoReset = false;
            carLeave.Enabled = false;
            carLeave.Start();
        }

        private static void carLeave_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Car has arrived");
        }

        public static void pumps(string[] pumpsAvailable)

        {

            Console.WriteLine("Pump 1: " + pumpsAvailable[0] + "        Pump 2: " + pumpsAvailable[1] + "          Pump 3: " + pumpsAvailable[2]);
            Console.WriteLine("Pump 4: " + pumpsAvailable[3] + "        Pump 5: " + pumpsAvailable[4] + "          Pump 6: " + pumpsAvailable[5]);
            Console.WriteLine("Pump 7: " + pumpsAvailable[6] + "        Pump 8: " + pumpsAvailable[7] + "          Pump 9: " + pumpsAvailable[8]);
            Console.WriteLine("Current Cars: ");
            

        }


        static void pumpOne(string[] closedOne)
        {
            closedOne[0] = "Closed";
        }

        static void pumpTwo(string[] closedTwo)
        {
            closedTwo[0] = "Closed";
        }
        static void pumpThree(string[] closedThree)
        {
            closedThree[0] = "Closed";
        }
        static void pumpFour(string[] closedFour)
        {
            closedFour[0] = "Closed";
        }
        static void pumpFive(string[] closedFive)
        {
            closedFive[0] = "Closed";
        }
        static void pumpSix(string[] closedSix)
        {
            closedSix[0] = "Closed";
        }
        static void pumpSeven(string[] closedSeven)
        {
            closedSeven[0] = "Closed";
        }
        static void pumpEight(string[] closedEight)
        {
            closedEight[0] = "Closed";
        }
        static void pumpNine(string[] closedNine)
        {
            closedNine[0] = "Closed";
        }

        static void cars()
        {
            string[] carsQueue = new string[1];

            for (int i = 0; i < carsQueue.Length; i++)
            {
                carsQueue[i] = "1";
                Console.WriteLine(carsQueue[0]);
            }
        }


        static void pumpQuestion(string[] arr4)
        {
            int carSend;
            int i = 0;
            do
            {
                Console.WriteLine("Please choose a free pump");
                carSend = Convert.ToInt32(Console.ReadLine());

                if (carSend == 1)
                {
                    if (arr4[0] == "open")
                    {
                        Console.WriteLine("The car has been sent to pump 1");
                        arr4[0] = "Closed";

                        pumpOne(arr4);
                        pumps(arr4);

                    }
                    else if (arr4[0] == "Closed")
                    {
                        Console.WriteLine("That pump is occupied");

                    }
                }
                if (carSend == 2)
                {
                    if (arr4[1] == "open")
                    {
                        Console.WriteLine("The car has been sent to pump 2");
                        arr4[1] = "Closed";

                        pumpTwo(arr4);
                        pumps(arr4);
                    }
                    else
                    {
                        Console.WriteLine("That pump is occupied");
                    }
                }
                if (carSend == 3)
                {
                    if (arr4[2] == "open")
                    {
                        Console.WriteLine("The car has been sent to pump 3");
                        arr4[2] = "Closed";

                        pumpThree(arr4);
                        pumps(arr4);
                    }
                    else
                    {
                        Console.WriteLine("That pump is occupied");
                    }
                }
                if (carSend == 4)
                {
                    if (arr4[3] == "open")
                    {
                        Console.WriteLine("The car has been sent to pump 4");
                        arr4[3] = "Closed";

                        pumpFour(arr4);
                        pumps(arr4);
                    }
                    else
                    {
                        Console.WriteLine("That pump is occupied");
                    }
                }
                if (carSend == 5)
                {
                    if (arr4[4] == "open")
                    {
                        Console.WriteLine("The car has been sent to pump 5");
                        arr4[4] = "Closed";

                        pumpFive(arr4);
                        pumps(arr4);
                    }
                    else
                    {
                        Console.WriteLine("That pump is occupied");
                    }
                }
                if (carSend == 6)
                {
                    if (arr4[5] == "open")
                    {
                        Console.WriteLine("The car has been sent to pump 6");
                        arr4[5] = "Closed";

                        pumpSix(arr4);
                        pumps(arr4);
                    }
                    else
                    {
                        Console.WriteLine("That pump is occupied");
                    }
                }
                if (carSend == 7)
                {
                    if (arr4[6] == "open")
                    {
                        Console.WriteLine("The car has been sent to pump 7");
                        arr4[6] = "Closed";

                        pumpSeven(arr4);
                        pumps(arr4);
                    }
                    else
                    {
                        Console.WriteLine("That pump is occupied");
                    }
                }
                if (carSend == 8)
                {
                    if (arr4[7] == "open")
                    {
                        Console.WriteLine("The car has been sent to pump 8");
                        arr4[7] = "Closed";

                        pumpEight(arr4);
                        pumps(arr4);
                    }

                    else
                    {
                        Console.WriteLine("That pump is occupied");
                    }
                }
                if (carSend == 9)
                {
                    if (arr4[8] == "open")
                    {
                        Console.WriteLine("The car has been sent to pump 9");
                        arr4[8] = "Closed";

                        pumpNine(arr4);
                        pumps(arr4);
                    }
                    else
                    {
                        Console.WriteLine("That pump is occupied");
                    }
                }
            }
            while (i < 5);

        }




        static void Main(string[] args)
        {
            string[] pumpsAvailable = new string[9] { "open", "open", "open", "open", "open", "open", "open", "open", "open" };

            int i = 0;
            do
            {
                pumpQuestion(pumpsAvailable);
            }
            while (i < 9);

            Console.ReadKey();
        }
    }
}
