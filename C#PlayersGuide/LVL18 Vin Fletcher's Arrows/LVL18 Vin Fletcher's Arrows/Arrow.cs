using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LVL18_Vin_Fletcher_s_Arrows
{
    internal class Arrow
    {
        private string _arrowHead;
        private float _length;
        private string _fletching;

        public string ArrowHead { get => _arrowHead; }
    
        public float Length { get => _length; }
    
        public string Fletching { get => _fletching; }
    
        public Arrow(string arrowHead, float length, string fletching)
        {
            _arrowHead = arrowHead;
            _length = length;
            _fletching = fletching;
        }

        //2 different ways of defining the create arrow functions, 1st and 3rd shown is shorter
        //main will call the function based on users choice and return an arrow based on that choice
        public static Arrow CreateEliteArrow() => new Arrow("Steel", 95, "Plastic");
        //below function is longer way of the first
        public static Arrow CreateBeginnerArrow()
        {
            return new Arrow("Wood", 75, "Goose Feathers");
        }
        public static Arrow CreateMarksmanArrow() => new Arrow("Steel", 65, "Goose Feathers");


        public float GetCost()
        {
            float cost = 0;
            switch (_arrowHead)
            {
                case "Steel":
                    cost += 10;
                    break;
                case "Wood":
                    cost += 3;
                    break;
                case "Obsidian":
                    cost += 5;
                    break;
            }

            switch (_fletching)
            {
                case "Plastic":
                    cost += 10;
                    break;
                case "Turkey Feathers":
                    cost += 5;
                    break;
                case "Goose Feathers":
                    cost += 3;
                    break;
            }

            return cost + (_length * 0.05f);
        }
        public void FinishedArrow()
        {
            Console.WriteLine("Great! One moment please..");
            Console.WriteLine("Done!");
            Console.WriteLine($"Your {ArrowHead} arrows with {Fletching} fletching and a length of {Length}cm are ready!");
            Console.WriteLine($"The total cost comes to {GetCost()} gold.");
        }

    }
}
