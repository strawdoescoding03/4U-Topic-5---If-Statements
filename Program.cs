using System.Data;

namespace _4U_Topic_5___If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
           bool compassRun = false, parkingRun = false, hurricaneRun = false;

            while (!compassRun || !parkingRun || !hurricaneRun)
            {
                Console.WriteLine(Console.Title = "MAIN MENU");
                Console.WriteLine("===================================");

                Console.WriteLine("What program would you like to run?");
                Console.WriteLine("1. Compass Direction");
                Console.WriteLine("2. Parking Garage Cost");
                Console.WriteLine("3. Hurricane");
                Console.WriteLine("===================================");
                Console.Write("Your Choice: ");
                string userChoice = Console.ReadLine();
                Console.Clear();

                switch (userChoice)
                {
                    case "1":
                        if (!compassRun)
                        {
                            Compass();
                            compassRun = true;
                        }
                        else
                        {
                            Console.WriteLine("You have already used the compass.");
                        }
                        break;


                    case "2":
                        if (!parkingRun)
                        {
                            ParkingGarageCost();
                            parkingRun = true;
                        }
                        else
                        {
                            Console.WriteLine("You have already used the garage.");
                        }
                        break;

                    case "3":
                        if (!hurricaneRun)
                        {
                            hurricaneRun = true;
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                        return;
                }

                if (compassRun == true && parkingRun == true && hurricaneRun == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }


        public static void Compass()
        {
            int userDegree;
            string direction;

            Console.WriteLine(Console.Title = "COMPASS");
            Console.WriteLine("===================================");
            Console.WriteLine("Enter a degree between 0 and 360");

            while (!int.TryParse(Console.ReadLine(), out userDegree))
            {
                Console.WriteLine("Invalid input. Please enter a degree between 0 and 360.");
            }

            if (userDegree < 0 || userDegree > 360)
            {
                if (userDegree < 0)
                {
                    userDegree = 360 + (userDegree % 360);
                }
                else
                    userDegree = userDegree % 360;
              
            }

            if (userDegree >= 315 || userDegree < 45)
            {
                direction = "North";
            }
            else if (userDegree >= 45 && userDegree < 135)
            {
                direction = "East";
            }
            else if (userDegree >= 135 && userDegree < 225)
            {
                direction = "South";
            }
            else // userDegree >= 225 && userDegree < 315
            {
                direction = "West";
            }          
            Console.WriteLine($"{userDegree}° {direction}");            

        }

        public static void ParkingGarageCost()
        {

            Console.WriteLine(Console.Title = "THE GARAGE");
            Console.WriteLine("===================================");
            double maxCharge, hourlyRate, minutesParked, hoursParked, totalCost;

            hourlyRate = 2.00;
            maxCharge = 20.00;
            
            Console.WriteLine("Enter the number of minutes parked:");
            while (!double.TryParse(Console.ReadLine(), out minutesParked) || minutesParked < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid number of minutes parked:");
            }

            hoursParked = Math.Ceiling(minutesParked / 60);
            //hoursParked = Math.Round(hoursParked, 1);

            Console.WriteLine($"Hours parked (rounded up): {hoursParked}");

            totalCost = 2.00 + (hoursParked * hourlyRate);

            if (totalCost > maxCharge)
            {
                totalCost = maxCharge;
            }

            Console.WriteLine($"Total parking cost: {totalCost.ToString("C")}");
        }

        public static void Hurricane()
        {
            Console.WriteLine(Console.Title = "THE HURRICANE");
            Console.WriteLine("===================================");

            double windSpeedMin, windSpeedMax;
            int hurricaneCatagory;

            Console.WriteLine("What is the catagory of your hurricane?");
            

            while (!int.TryParse(Console.ReadLine(), out hurricaneCatagory) || hurricaneCatagory > 5 || hurricaneCatagory < 0)
            {
                Console.WriteLine("That is an invalid input. Please try again");
            }

            switch (hurricaneCatagory.ToString())
            {
                case "1":
                    {
                        windSpeedMin = 74;
                        windSpeedMax = 95;

                        Console.WriteLine($"The windspeed is between {windSpeedMin} MPH - {windSpeedMax} MPH ");

                    }
                    break;

                case "2":
                    {

                    }
                    break;

                case "3":
                    {

                    }
                    break;

                case "4":
                    {

                    }
                    break;

                case "5":
                    {

                    }
                    break;
            }

        }



    }
}
