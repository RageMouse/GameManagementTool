using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManage.DAL.Interfaces.Interfaces;
using GameManage.DAL.MSSQL;

namespace GameManage.DAL.Factory
{
    class MonsterFactory
    {
        public static IMonsterCollectionContext GetItemCollectionContext()
        {
            return new MonsterContext();
        }
    }
}
