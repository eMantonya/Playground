using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LVL24_The_Catacombs_of_the_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //point class
            //creates 2 new points on a grid and prints their location
            Point point1 = new Point(2, 3);
            Point point2 = new Point(-4, 0);
            Console.WriteLine($"{point1._xCoordinate},{point1._yCoordinate}");
            Console.WriteLine($"{point2._xCoordinate},{point2._yCoordinate}");

            //color class
            //creates a custom color and a specified color using RGB values then prints their RGB values
            Color newColor = new Color(128, 176, 89);
            newColor.PrintRGBValues();
            Color redColor = Color.Red;
            redColor.PrintRGBValues();

            //Card class
            //uses enum to create a deck of cards with a unique rank and color combo then prints each card out
            CardColor[] colors = new CardColor[] {CardColor.Red, CardColor.Green, CardColor.Blue, CardColor.Yellow};
            CardRank[] cardRanks = new CardRank[] { CardRank.One, CardRank.Two, CardRank.Three, CardRank.Three, CardRank.Four, CardRank.Five, CardRank.Six, CardRank.Seven, CardRank.Eight, CardRank.Nine, CardRank.Ten, CardRank.DollarSign, CardRank.Percent, CardRank.Caret, CardRank.Ampersand };

            foreach (CardColor color in colors)
            {
                foreach (CardRank rank in cardRanks)
                {
                    Card card = new Card(rank, color);
                    Console.WriteLine($"The {card._Rank} of {card._Color}.");
                }
            }

            //Door class
            //creates a new door initialized with a passcode (verified with method against passcode requirements)
            //using that passcode, the user can unlock the door, open, and close as much as they want untill the type exit           
            long pass = GetDoorPass();
            var myDoor = new Door(pass);
            ManipulateDoor(myDoor);

            //PasswordValidator Class
            //once instance is created, all password verification logic is handled and hidden in a private class method
            //password is printed once the password given is valid
            var myPass = new PasswordValidator();
            Console.WriteLine($"Your password has been set to {myPass.Password}");
        }

        //NOTE: better security would be to make the GetDoorPass a private method inside the class so only the class can access it
        static long GetDoorPass()
        {
            while (true)
            {
                long pass = 0;
                try
                {
                    Console.WriteLine("Please enter a six digit passcode:");
                    pass = long.Parse(Console.ReadLine());
                    if (pass > 999999 || pass < 9999)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    continue;
                }
                return pass;
            }
        }
        //using that passcode, the user can unlock the door, open, and close as much as they want until they type exit
        static void ManipulateDoor(Door myDoor)
        {
            while (true)
            {
                Console.WriteLine($"The door is {myDoor.DoorStatus}. What would you like to do?");
                string input = Console.ReadLine().ToLower();

                if (input == "unlock") { myDoor.Unlock(); }
                else if (input == "lock") { myDoor.Lock(); }
                else if (input == "close") { myDoor.Close(); }
                else if (input == "open") { myDoor.Open(); }
                else if (input == "change pass") { myDoor.ChangePass(); }
                else if (input == "exit") { break; }
                else { Console.WriteLine("I can't do that.."); }
            }
        }

        
    }
}
