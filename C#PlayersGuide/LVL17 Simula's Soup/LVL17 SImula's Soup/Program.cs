using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LVL17_SImula_s_Soup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var soup = (
                food.Soup,
                mainIngredient.Chicken,
                seasoning.Salty
            );

            Console.WriteLine("What type of food would you like? 1 = Soup, 2 = Stew, 3 = Gumbo" );
            int foodType = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What main ingredient would you like? 1 = Mushrooms, 2 = Chicken, 3 = Carrots, 4 = Potatoes");
            int ingredientType = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What seasoning sounds best? 1 = Spicy, 2 = Salty, 3 = Sweet");
            int seasoingType = Convert.ToInt32(Console.ReadLine());

            var userDish = ((seasoning)seasoingType, (mainIngredient)ingredientType, (food)foodType);
            Console.WriteLine("One minute please...");
            PlayTreasureJingle();
            Console.WriteLine($"Done! This {(seasoning)seasoingType} {(mainIngredient)ingredientType} {(food)foodType} looks delicious!");
        }

        static void PlayTreasureJingle()
        {
            int[] frequencies = { 659, 783, 880, 987, 1175 };
            int[] durations = { 200, 200, 200, 200, 400 };

            for (int i = 0; i < frequencies.Length; i++)
            {
                Console.Beep(frequencies[i], durations[i]);
                Thread.Sleep(durations[i]);
            }
        }
    }
    enum food {Soup = 1, Stew, Gumbo};
    enum mainIngredient {Mushroom = 1, Chicken, Carrot, Potato};
    enum seasoning {Spicy = 1, Salty, Sweet};

}
