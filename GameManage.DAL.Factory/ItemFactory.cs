using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManage.DAL.Interfaces.Interfaces;
using GameManage.DAL.MSSQL;

namespace GameManage.DAL.Factory
{
    public static class ItemFactory
    {
        public static IItemCollectionContext GetItemCollectionContext()
        {
            return new ItemContext();
        }
    }
}
