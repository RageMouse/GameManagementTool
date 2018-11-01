using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManage.DAL.Interfaces.Interfaces;
using GameManage.DAL.Memory;

namespace GameManage.DAL.Factory
{
    class MonsterFactory
    {
        public static IMonsterContext GetItemCollectionContext()
        {
            return new MonsterContext();
        }
    }
}
