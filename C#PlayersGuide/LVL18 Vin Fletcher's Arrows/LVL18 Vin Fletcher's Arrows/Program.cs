using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVL18_Vin_Fletcher_s_Arrows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arrowHead = null;
            float length = 0;
            string fletchingMats = null;
            bool custom = false;

            Console.WriteLine("Welcome to Vin Fletcher's Arrows!");
            Console.WriteLine("I will aid you in choosing the perfect set of arrows");
            Console.WriteLine("Would you like one of our pre-built arrows or customize your own?\n 1. Pre-built Arrow 2. Custom Arrow");
            if (Console.ReadLine() == "2")
            {
                custom = true;
            }

            if (custom)
            {
                while (arrowHead == null)
                {
                    Console.WriteLine("Please choose the type of Arrowhead.\n1. Steel = 10g 2. Wood = 3g 3. Obsidian = 5g");
                    arrowHead = Console.ReadLine();
                    switch (arrowHead)
                    {
                        case "1":
                            arrowHead = "Steel";
                            break;
                        case "2":
                            arrowHead = "Wood";
                            break;
                        case "3":
                            arrowHead = "Obsidian";
                            break;
                        default:
                            Console.WriteLine("Please choose a number: 1, 2, or 3..");
                            arrowHead = null;
                            break;
                    }
                }

                Console.WriteLine("Thanks! Now please choose the length of the arrows from 60cm to 100cm.\nPlease note, the cost is 0.05g per centimeter");

                while (length == 0)
                {
                    length = float.Parse(Console.ReadLine());
                    if (length > 100)
                    {
                        Console.WriteLine("An arrow that long will not fly right.. Please choose between 60 - 100 cm.");
                        length = 0;
                        continue;
                    }
                    else if (length < 60)
                    {
                        Console.WriteLine("Unfortunately, an arrow that short will not fit on any bow.. Please choose between 60 - 100 cm.");
                        length = 0;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Excellent!");
                    }
                }

                while (fletchingMats == null)
                {
                    Console.WriteLine("Now please choose the fletching type.\n1. Plastic = 10g 2. Turkey Feathers = 5g 3. Goose Feathers = 3g");
                    fletchingMats = Console.ReadLine();
                    switch (fletchingMats)
                    {
                        case "1":
                            fletchingMats = "Plastic";
                            break;
                        case "2":
                            fletchingMats = "Turkey Feathers";
                            break;
                        case "3":
                            fletchingMats = "Goose Feathers";
                            break;
                        default:
                            Console.WriteLine("Please choose a number: 1, 2, or 3..");
                            fletchingMats = null;
                            break;
                    }
                }
                Arrow CustomArrow = new Arrow(arrowHead, length, fletchingMats);
                CustomArrow.FinishedArrow();
            }
            else
            {
                Console.WriteLine("Excellent! Which arrow would you like?\n1. Elite Arrow 2. Beginner Arrow 3. Marksman Arrow");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Arrow EliteArrow = Arrow.CreateEliteArrow();
                        EliteArrow.FinishedArrow();
                        break;
                    case 2:
                        Arrow BeginnerArrow = Arrow.CreateBeginnerArrow();
                        BeginnerArrow.FinishedArrow();
                        break;
                    case 3:
                        Arrow MarksmanArrow = Arrow.CreateMarksmanArrow();
                        MarksmanArrow.FinishedArrow();
                        break;

                }
            }
        }
    }
}
