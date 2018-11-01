using System;
using System.Collections.Generic;
using GameManage.DAL.Interfaces.DTOs;
using GameManage.DAL.Interfaces.Interfaces;

namespace GameManage.DAL.Memory
{
    public class MonsterContext : IMonsterContext
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
