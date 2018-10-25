using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManage.DAL.Factory;
using GameManage.DAL.Interfaces.Interfaces;

namespace GameManage.Logic.Models
{
    class ItemCollection
    {
        private readonly IItemCollectionContext database = ItemFactory.GetItemCollectionContext();

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

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void AddMonster(Item item)
        {
            Items.Add(item);
        }
    }
}
