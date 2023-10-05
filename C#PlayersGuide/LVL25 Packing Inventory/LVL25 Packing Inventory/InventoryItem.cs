using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVL25_Packing_Inventory
{
    internal class InventoryItem
    {
        internal float weight;
        internal float volume;

        internal InventoryItem(float w, float v)
        {
            weight = w;
            volume = v;
        }
    }
}
