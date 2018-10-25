using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManage.DAL.Interfaces.DTOs;
using GameManage.DAL.Interfaces.Interfaces;

namespace GameManage.DAL.MSSQL
{
    public class MonsterContext : IMonsterCollectionContext
    {
        public List<MonsterDTO> GetMonsters(MonsterDTO monsters)
        {
            throw new NotImplementedException();
        }

        public void AddMonster(MonsterDTO monster)
        {
            throw new NotImplementedException();
        }

        public void RemoveMonster(MonsterDTO monster)
        {
            throw new NotImplementedException();
        }
    }
}
