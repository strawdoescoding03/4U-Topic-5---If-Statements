using System.Data;
using System.Xml;

namespace _4U_Topic_5___If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool compassRun = false, parkingRun = false, hurricaneRun = false, done = false;
            string userChoice;

            while (!done)
            {
                while (!compassRun || !parkingRun || !hurricaneRun)
                {
                    Console.WriteLine(Console.Title = "MAIN MENU");
                    Console.WriteLine("===================================");

                    Console.WriteLine("What program would you like to run?");
                    Console.WriteLine("1. Compass Direction");
                    Console.WriteLine("2. Parking Garage Cost");
                    Console.WriteLine("3. Weather Machine");
                    Console.WriteLine("===================================");
                    Console.Write("Your Choice: ");
                    userChoice = Console.ReadLine();
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
                                Hurricane();
                                hurricaneRun = true;
                            }
                            else
                            {
                                Console.WriteLine("You have already used the weather machine.");
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                            break;
                    }

                }

                if (compassRun == true && parkingRun == true && hurricaneRun == true)
                {
                    Console.WriteLine(Console.Title = "GAME COMPLETE");
                    Console.WriteLine("===================================");
                    Console.WriteLine("You have completed every module!");
                    Console.WriteLine();
                    Console.WriteLine("Would you like to play again?");
                    userChoice = Console.ReadLine();
                    userChoice = userChoice.ToLower();

                    while (userChoice != "yes" || userChoice != "y" || userChoice != "no" || userChoice != "n")
                    {
                        {
                            Console.WriteLine("Please try again");
                            userChoice = Console.ReadLine();
                            userChoice = userChoice.ToLower();
                        }
                    }
                    
                    if (userChoice == "y" || userChoice == "yes")
                    {
                        compassRun = false;
                        parkingRun = false;
                        hurricaneRun = false;
                        Console.WriteLine("Press any key to continue");
                        Console.ReadLine();
                        Console.Clear();
                    }

                    else if (userChoice == "n" || userChoice == "no")
                    {
                        Console.WriteLine("Thanks for playing!");
                        done = true;
                    }

                   
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
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            Console.Clear();
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
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            Console.Clear();

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
                        //MPH
                        windSpeedMin = 74;
                        windSpeedMax = 95;
                        Console.WriteLine($"The windspeed is between {windSpeedMin} mph - {windSpeedMax} mph ");

                        //KM/HR CONVERSION

                        windSpeedMin = Math.Round((windSpeedMin * 1.61), 0);
                        windSpeedMax = Math.Round((windSpeedMax * 1.61), 0);
                        
                        Console.WriteLine($"The windspeed is between {windSpeedMin} km/hr - {windSpeedMax} km/hr");
                        //KT

                        windSpeedMin = Math.Round((windSpeedMin / 1.852), 0);
                        windSpeedMax = Math.Round((windSpeedMax / 1.852), 0);

                        Console.WriteLine($"The windspeed is between {windSpeedMin} kt - {windSpeedMax} kt ");
                    }
                    break;

                case "2":
                    {
                        windSpeedMin = 96;
                        windSpeedMax = 110;
                        Console.WriteLine($"The windspeed is between {windSpeedMin} mph - {windSpeedMax} mph ");

                        //KM/HR CONVERSION

                        windSpeedMin = Math.Round((windSpeedMin * 1.61), 0);
                        windSpeedMax = Math.Round((windSpeedMax * 1.61), 0);

                        Console.WriteLine($"The windspeed is between {windSpeedMin} km/hr - {windSpeedMax} km/hr");
                        //KT

                        windSpeedMin = Math.Round((windSpeedMin / 1.852), 0);
                        windSpeedMax = Math.Round((windSpeedMax / 1.852), 0);

                        Console.WriteLine($"The windspeed is between {windSpeedMin} kt - {windSpeedMax} kt ");
                    }
                    break;

                case "3":
                    {
                        windSpeedMin = 111;
                        windSpeedMax = 130;
                        Console.WriteLine($"The windspeed is between {windSpeedMin} mph - {windSpeedMax} mph ");

                        //KM/HR CONVERSION

                        windSpeedMin = Math.Round((windSpeedMin * 1.61), 0);
                        windSpeedMax = Math.Round((windSpeedMax * 1.61), 0);

                        Console.WriteLine($"The windspeed is between {windSpeedMin} km/hr - {windSpeedMax} km/hr");
                        //KT

                        windSpeedMin = Math.Round((windSpeedMin / 1.852), 0);
                        windSpeedMax = Math.Round((windSpeedMax / 1.852), 0);

                        Console.WriteLine($"The windspeed is between {windSpeedMin} kt - {windSpeedMax} kt ");
                    }
                    break;

                case "4":
                    {
                        windSpeedMin = 131;
                        windSpeedMax = 155;
                        Console.WriteLine($"The windspeed is between {windSpeedMin} mph - {windSpeedMax} mph ");

                        //KM/HR CONVERSION

                        windSpeedMin = Math.Round((windSpeedMin * 1.61), 0);
                        windSpeedMax = Math.Round((windSpeedMax * 1.61), 0);

                        Console.WriteLine($"The windspeed is between {windSpeedMin} km/hr - {windSpeedMax} km/hr");
                        //KT

                        windSpeedMin = Math.Round((windSpeedMin / 1.852), 0);
                        windSpeedMax = Math.Round((windSpeedMax / 1.852), 0);

                        Console.WriteLine($"The windspeed is between {windSpeedMin} kt - {windSpeedMax} kt ");
                    }
                    break;

                case "5":
                    {
                        windSpeedMin = 155;
                        Console.WriteLine($"The windspeed over {windSpeedMin} mph");

                        //KM/HR CONVERSION

                        windSpeedMin = Math.Round((windSpeedMin * 1.61), 0);

                        Console.WriteLine($"The windspeed is over {windSpeedMin} km/hr");
                        //KT

                        windSpeedMin = Math.Round((windSpeedMin / 1.852), 0);


                        Console.WriteLine($"The windspeed is over {windSpeedMin} kt");
                    }
                    break;

            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            Console.Clear();

        }



    }
}
