using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManage.DAL.Interfaces.DTOs;
using GameManage.DAL.Interfaces.Interfaces;

namespace GameManage.DAL.MSSQL
{
    public class ItemContext : IItemCollectionContext
    {
        public List<ItemDTO> GetItems(ItemDTO items)
        {
            throw new System.NotImplementedException();
        }

        public void AddItem(ItemDTO item)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveItem(ItemDTO item)
        {
            throw new System.NotImplementedException();
        }
    }
}
