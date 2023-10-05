using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVL25_Packing_Inventory
{
    internal class Pack
    {
        private float _weightCapacity;
        private float _volumeCapacity;
        private int _itemCapacity;
        private float _currentWeight;
        private float _currentVolume;
        private int _currentNoOfItems;

        public float CurrentWeight { get => _currentWeight; }
        public float CurrentVolume { get => _currentWeight; }
        public int CurrentNoOfItems { get => _currentNoOfItems; }
        public float WeightCapacity { get => _weightCapacity; }
        public float VolumeCapacity { get => _volumeCapacity; }
        public int ItemCapacity { get => _itemCapacity; }

        public InventoryItem[] Inventory { get; set; }

        public Pack(float weightCap, float volCap, int itemCap) 
        {
            _weightCapacity= weightCap;
            _volumeCapacity= volCap;
            _itemCapacity= itemCap;
            Inventory = new InventoryItem[itemCap];
        }

        public bool Add(InventoryItem item)
        {
            if (item.weight + _currentWeight > _weightCapacity)
            {
                Console.WriteLine("Overweight..");
                return false;
            }
            else if (item.volume + _currentVolume > _volumeCapacity)
            {
                Console.WriteLine("Over volume..");
                return false;
            }
            else if (_currentNoOfItems + 1 > _itemCapacity)
            {
                Console.WriteLine("Too many items..");
                return false;
            }
            else
            {
                Inventory.Append(item);
                _currentWeight += item.weight;
                _currentVolume += item.volume;
                _currentNoOfItems++;
                Console.WriteLine($"{item.GetType()} was added to the pack!");
                return true;
            }            
        }
    }
}
