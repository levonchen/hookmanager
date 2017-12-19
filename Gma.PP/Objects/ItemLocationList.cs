using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gma.PP.Objects
{
    public class ItemLocationList
    {

        public ItemLocationList()
        {
            Items = new Dictionary<String, ItemLocation>();

        }
        public Dictionary<String, ItemLocation> Items { get; set; }

        public void AddItem(ItemLocation loc)
        {
            Items[loc.Id] = loc;
        }

        public ItemLocation GetItem(String key)
        {
            return Items[key];
        }
    }
}
