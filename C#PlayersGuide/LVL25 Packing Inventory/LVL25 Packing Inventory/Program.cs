using LVL25_Packing_Inventory;
using System.Diagnostics.CodeAnalysis;

Pack myPack = new Pack(40.5f, 47.5f, 100);
Sword mySword = new Sword();
Console.WriteLine($"{mySword.weight}, {mySword.volume}");

ManipulatePack();

void ManipulatePack()
{
    Console.WriteLine($"Your new pack has {myPack.WeightCapacity} weight cap, {myPack.VolumeCapacity} volume cap , and a {myPack.ItemCapacity} item cap.");
    while (true)
    {
        bool exit = false;
        Console.WriteLine("What would you like to add?: Sword, Food, Water, Bow, Arrow, or Rope -- \"Exit\" when done..");
        string? response = Console.ReadLine().ToLower();
        switch (response)
        {
            case "sword":
                myPack.Add(new Sword());
                break;
            case "food":
                myPack.Add(new Food());
                break;
            case "water":
                myPack.Add(new Water());
                break;
            case "bow":
                myPack.Add(new Bow());
                break;
            case "arrow":
                byte arrowsToAdd = 0;
                Console.WriteLine("How many arrows?");
                try
                {
                    arrowsToAdd = byte.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Try again..");
                    break;
                }
                for (int i = 0; i < arrowsToAdd; i++)
                {
                    if (!myPack.Add(new Arrow())) 
                    {
                        Console.WriteLine($"You could only add {i} arrows");
                        break; 
                    }                           
                }
                break;
            case "rope":
                myPack.Add(new Rope());
                break;
            case "exit":
                exit = true;
                break;
            default:
                Console.WriteLine("Try again..");
                break;
        }
        Console.WriteLine($"Weight: {myPack.CurrentWeight}/{myPack.WeightCapacity}\tVolume: {myPack.CurrentVolume}/{myPack.VolumeCapacity}\tItems: {myPack.CurrentNoOfItems}/{myPack.ItemCapacity}");
        if (exit) { break; }
    }
}