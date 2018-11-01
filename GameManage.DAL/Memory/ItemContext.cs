using System.Collections.Generic;
using GameManage.DAL.Interfaces.DTOs;
using GameManage.DAL.Interfaces.Interfaces;

namespace GameManage.DAL.Memory
{
    public class ItemContext : IItemContext
    {
        private List<ItemDTO> Items { get; set; }

        public List<ItemDTO> GetItems(ItemDTO items)
        {
            throw new System.NotImplementedException();
        }

        public void AddItem(ItemDTO item)
        {
            Items.Add(item);
        }

        public void RemoveItem(ItemDTO item)
        {
            Items.Remove(item);
        }
    }
}
