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
        public static string[] pumpsAvailable = new string[9] { "open", "open", "open", "open", "open", "open", "open", "open", "open" };
        public static int CurrentCar = 0;
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
        public static void carGo(int i)
        {
            //Sets the amount of time before a new car is made
            carLeave = new Timer(8000);
            //carLeave.Elapsed += carLeave_Elapsed;
            carLeave.AutoReset = false;
            carLeave.Enabled = false;
            carLeave.Start();
            CurrentCar = i;
        }

        private static void carLeave_Elapsed(object sender, System.Timers.ElapsedEventArgs e, int pumps)
        {
            Console.WriteLine("Car has left");
            pumpsAvailable[CurrentCar] = "open";
        }
        //Defines the pumps method with the pumpsAvailable string embedded
        public static void pumps(string[] pumpsAvailable)

        {
            //prints out all of the pumps with the value of the associated string balue
            Console.WriteLine("Pump 1: " + pumpsAvailable[0] + "        Pump 2: " + pumpsAvailable[1] + "          Pump 3: " + pumpsAvailable[2]);
            Console.WriteLine("Pump 4: " + pumpsAvailable[3] + "        Pump 5: " + pumpsAvailable[4] + "          Pump 6: " + pumpsAvailable[5]);
            Console.WriteLine("Pump 7: " + pumpsAvailable[6] + "        Pump 8: " + pumpsAvailable[7] + "          Pump 9: " + pumpsAvailable[8]);

        }

        //Defines the pumpOne method
        static void pumpOne(string[] closedOne)
        {
            //Sets the closedOne value to Closed
            closedOne[0] = "Closed";
        }
        //Defines the pumpTwo method
        static void pumpTwo(string[] closedTwo)
        {
            //Sets the closedTwo value to Closed
            closedTwo[0] = "Closed";
        }
        //Defines the pumpThree method
        static void pumpThree(string[] closedThree)
        {
            //Sets the closedThree value to Closed
            closedThree[0] = "Closed";
        }
        //Defines the pumpFour method
        static void pumpFour(string[] closedFour)
        {
            //Sets the closedFour value to Closed
            closedFour[0] = "Closed";
        }
        //Defines the pumpFive method
        static void pumpFive(string[] closedFive)
        {
            //Sets the closedFive value to Closed
            closedFive[0] = "Closed";
        }
        //Defines the pumpSix method
        static void pumpSix(string[] closedSix)
        {
            //Sets the closedSix value to Closed
            closedSix[0] = "Closed";
        }
        //Defines the pumpSeven method
        static void pumpSeven(string[] closedSeven)
        {
            //Sets the closedSeven value to Closed
            closedSeven[0] = "Closed";
        }
        //Defines the pumpEight method
        static void pumpEight(string[] closedEight)
        {
            //Sets the closedEight value to Closed
            closedEight[0] = "Closed";
        }
        //Defines the pumpNine method
        static void pumpNine(string[] closedNine)
        {
            //Sets the closedNine value to Closed
            closedNine[0] = "Closed";
        }
        //Defines the method cars
        static void cars()
        {
            //Creates an array called carsQueue
            string[] carsQueue = new string[1];
            //A For loop which continues until i is less than carsQueue
            for (int i = 0; i < carsQueue.Length; i++)
            {
                //This sets carsQueue to the value of 1
                carsQueue[i] = "1";
                //This prints the first entry of the carsQueue array
                Console.WriteLine(carsQueue[0]);
            }
        }

        //Defines the pumpQuestion method with the array "arr4" built in
        static void pumpQuestion(string[] arr4)
        {
            // Defines the variable carSend as an integer
            int carSend;
            //This sets i to 0
            int i = 0;
            //This initiates a while loop
            do
            {
                //This prints to the console and asks the user "Please choose a free pump" and records the input to the variable "carSend"
                Console.WriteLine("Please choose a free pump");
                carSend = Convert.ToInt32(Console.ReadLine());
                //If statement which looks for the user to input "1"
                if (carSend == 1)
                {
                    //If statement which looks to see if arr4[0] is set to "open"
                    if (arr4[0] == "open")
                    {
                        //Tells the user where the car has been sent to and also sets the corresponding pump value to "Closed"
                        Console.WriteLine("The car has been sent to pump 1");
                        arr4[0] = "Closed";

                        CarLeaving(arr4);

                        //Calls the pumpOne and pumps methods
                        //pumpOne(arr4);
                        //pumps(arr4);

                    }
                    //If the array value is set to "Closed", it tells the user that the pump is occupied 
                    else if (arr4[0] == "Closed")
                    {
                        Console.WriteLine("That pump is occupied");

                    }
                }
                //If statement which looks for the user to input "2"
                if (carSend == 2)
                {
                    //If statement which looks to see if arr4[1] is set to "open"
                    if (arr4[1] == "open")
                    {
                        //Tells the user where the car has been sent to and also sets the corresponding pump value to "Closed"
                        Console.WriteLine("The car has been sent to pump 2");
                        arr4[1] = "Closed";
                        CarLeaving2(arr4);
                        //Calls the pumpTwo and pumps methods
                        //pumpTwo(arr4);
                        //pumps(arr4);
                    }
                    //If the array value is set to "Closed", it tells the user that the pump is occupied
                    else
                    {
                        Console.WriteLine("That pump is occupied");
                    }
                }
                //If statement which looks for the user to input "3"
                if (carSend == 3)
                {
                    //If statement which looks to see if arr4[2] is set to "open"
                    if (arr4[2] == "open")
                    {
                        //Tells the user where the car has been sent to and also sets the corresponding pump value to "Closed"
                        Console.WriteLine("The car has been sent to pump 3");
                        arr4[2] = "Closed";
                        CarLeaving3(arr4);
                        //Calls the pumpThree and pumps methods
                        //pumpThree(arr4);
                        //pumps(arr4);
                    }
                    //If the array value is set to "Closed", it tells the user that the pump is occupied
                    else
                    {
                        Console.WriteLine("That pump is occupied");
                    }
                }
                //If statement which looks for the user to input "4"
                if (carSend == 4)
                {
                    //If statement which looks to see if arr4[3] is set to "open"
                    if (arr4[3] == "open")
                    {
                        //Tells the user where the car has been sent to and also sets the corresponding pump value to "Closed"
                        Console.WriteLine("The car has been sent to pump 4");
                        arr4[3] = "Closed";
                        CarLeaving4(arr4);
                        //Calls the pumpFour and pumps methods
                        //pumpFour(arr4);
                        //pumps(arr4);
                    }
                    //If the array value is set to "Closed", it tells the user that the pump is occupied
                    else
                    {
                        Console.WriteLine("That pump is occupied");
                    }
                }
                //If statement which looks for the user to input "5"
                if (carSend == 5)
                {
                    //If statement which looks to see if arr4[4] is set to "open"
                    if (arr4[4] == "open")
                    {
                        //Tells the user where the car has been sent to and also sets the corresponding pump value to "Closed"
                        Console.WriteLine("The car has been sent to pump 5");
                        arr4[4] = "Closed";
                        CarLeaving5(arr4);
                        //Calls the pumpFive and pumps methods
                        //pumpFive(arr4);
                        //pumps(arr4);
                    }
                    //If the array value is set to "Closed", it tells the user that the pump is occupied
                    else
                    {
                        Console.WriteLine("That pump is occupied");
                    }
                }
                //If statement which looks for the user to input "6"
                if (carSend == 6)
                {
                    //If statement which looks to see if arr4[5] is set to "open"
                    if (arr4[5] == "open")
                    {
                        //Tells the user where the car has been sent to and also sets the corresponding pump value to "Closed"
                        Console.WriteLine("The car has been sent to pump 6");
                        arr4[5] = "Closed";
                        CarLeaving6(arr4);
                        //Calls the pumpSix and pumps methods
                        //pumpSix(arr4);
                        //pumps(arr4);
                    }
                    //If the array value is set to "Closed", it tells the user that the pump is occupied
                    else
                    {
                        Console.WriteLine("That pump is occupied");
                    }
                }
                //If statement which looks for the user to input "7"
                if (carSend == 7)
                {
                    //If statement which looks to see if arr4[6] is set to "open"
                    if (arr4[6] == "open")
                    {
                        //Tells the user where the car has been sent to and also sets the corresponding pump value to "Closed"
                        Console.WriteLine("The car has been sent to pump 7");
                        arr4[6] = "Closed";
                        CarLeaving7(arr4);
                        //Calls the pumpSeven and pumps methods
                        //pumpSeven(arr4);
                        //pumps(arr4);
                    }
                    //If the array value is set to "Closed", it tells the user that the pump is occupied
                    else
                    {
                        Console.WriteLine("That pump is occupied");
                    }
                }
                //If statement which looks for the user to input "8"
                if (carSend == 8)
                {
                    //If statement which looks to see if arr4[7] is set to "open"
                    if (arr4[7] == "open")
                    {
                        //Tells the user where the car has been sent to and also sets the corresponding pump value to "Closed"
                        Console.WriteLine("The car has been sent to pump 8");
                        arr4[7] = "Closed";
                        CarLeaving8(arr4);
                        //Calls the pumpEight and pumps methods
                        //pumpEight(arr4);
                        //pumps(arr4);
                    }
                    //If the array value is set to "Closed", it tells the user that the pump is occupied
                    else
                    {
                        Console.WriteLine("That pump is occupied");
                    }
                }
                //If statement which looks for the user to input "9"
                if (carSend == 9)
                {
                    //If statement which looks to see if arr4[8] is set to "open"
                    if (arr4[8] == "open")
                    {
                        //Tells the user where the car has been sent to and also sets the corresponding pump value to "Closed"
                        Console.WriteLine("The car has been sent to pump 9");
                        arr4[8] = "Closed";
                        CarLeaving9(arr4);
                        //Calls the pumpNine and pumps methods
                        //pumpNine(arr4);
                        //pumps(arr4);
                    }
                    //If the array value is set to "Closed", it tells the user that the pump is occupied
                    else
                    {
                        Console.WriteLine("That pump is occupied");
                    }
                }
            }
            while (i < 5);

        }


       
        //Lines of code in the Main method will always run, and will run first so they will be at the top of the program when it starts
        static void Main(string[] args)
        {
            //Creates the pumpsAvailable array and sets all 9 values as "open"
            //string[] pumpsAvailable = new string[9] { "open", "open", "open", "open", "open", "open", "open", "open", "open" };
            //Prints an open message
            Console.WriteLine("*********** Welcome to the Petrol Station ***********");
            //Prints all of the pumps and their values
            Console.WriteLine("Pump 1: " + pumpsAvailable[0] + "        Pump 2: " + pumpsAvailable[1] + "          Pump 3: " + pumpsAvailable[2]);
            Console.WriteLine("Pump 4: " + pumpsAvailable[3] + "        Pump 5: " + pumpsAvailable[4] + "          Pump 6: " + pumpsAvailable[5]);
            Console.WriteLine("Pump 7: " + pumpsAvailable[6] + "        Pump 8: " + pumpsAvailable[7] + "          Pump 9: " + pumpsAvailable[8]);
            //Sets i to 0
            int i = 0;
            //initiates a while loop of the pumpQuestion method
            do
            {
                pumpQuestion(pumpsAvailable);
            }
            //Sets the parameters of the while loop
            while (i < 9);

            Console.ReadKey();
        }

        static async Task CarLeaving(string[] arr4)
        {
            await Task.Delay(8000);

            arr4[0] = "open";

            Console.WriteLine("Pump 1 is now free to be used.");

            pumps(arr4);

        }

        static async Task CarLeaving2(string[] arr4)
        {
            await Task.Delay(8000);

            arr4[1] = "open";

            Console.WriteLine("Pump 2 is now free to be used.");

            pumps(arr4);

        }

        static async Task CarLeaving3(string[] arr4)
        {
            await Task.Delay(8000);

            arr4[2] = "open";

            Console.WriteLine("Pump 3 is now free to be used.");

            pumps(arr4);

        }

        static async Task CarLeaving4(string[] arr4)
        {
            await Task.Delay(8000);

            arr4[3] = "open";

            Console.WriteLine("Pump 4 is now free to be used.");

            pumps(arr4);

        }
        static async Task CarLeaving5(string[] arr4)
        {
            await Task.Delay(8000);

            arr4[4] = "open";

            Console.WriteLine("Pump 5 is now free to be used.");

            pumps(arr4);

        }
        static async Task CarLeaving6(string[] arr4)
        {
            await Task.Delay(8000);

            arr4[5] = "open";

            Console.WriteLine("Pump 6 is now free to be used.");

            pumps(arr4);

        }
        static async Task CarLeaving7(string[] arr4)
        {
            await Task.Delay(8000);

            arr4[6] = "open";

            Console.WriteLine("Pump 7 is now free to be used.");

            pumps(arr4);

        }
        static async Task CarLeaving8(string[] arr4)
        {
            await Task.Delay(8000);

            arr4[7] = "open";

            Console.WriteLine("Pump 8 is now free to be used.");

            pumps(arr4);

        }
        static async Task CarLeaving9(string[] arr4)
        {
            await Task.Delay(8000);

            arr4[8] = "open";

            Console.WriteLine("Pump 9 is now free to be used.");

            pumps(arr4);

        }


    }
}
