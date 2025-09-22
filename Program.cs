using System.Data;

namespace _4U_Topic_5___If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Compass();
        }


        public static void Compass()
        {
            int userDegree;
            string direction;

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
    }
}
