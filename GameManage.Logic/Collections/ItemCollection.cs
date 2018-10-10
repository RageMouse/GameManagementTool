using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManage.Logic.Models
{
    class ItemCollection
    {
        //Properties
        public List<Item> Items { get; private set; }

        //Constructors
        public ItemCollection(List<Item> items)
        {
            Items = GetItems();
        }

        //Methods
        public List<Item> GetItems()
        {
            throw new NotImplementedException();
        }
    }
}
