using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVL16_Simula_s_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            chestStatus current = chestStatus.locked;
            while (true)
            {
                Console.WriteLine($"The chest is {current}. What do you want to do? ");
                string action = Console.ReadLine();

                switch (action)
                {
                    case "unlock":
                        current = chestStatus.unlocked; 
                        break;
                    case "open":
                        if (current == chestStatus.locked)
                        {
                            Console.WriteLine("Nothing happens..");
                            break;
                        }
                        else
                        {
                            current = chestStatus.open;
                            break;
                        }
                    case "close":
                        current = chestStatus.closed;
                        break;
                    case "lock":
                        if (current == chestStatus.open)
                        {
                            Console.WriteLine("The open chest does not lock..");
                            break;
                        }
                        else
                        {
                            current = chestStatus.locked;
                            break;
                        }
                    default:
                        Console.WriteLine("You can't do that.");
                        break;
                }
            }
            
        }
    }
    enum chestStatus { open, closed, unlocked, locked };
}
