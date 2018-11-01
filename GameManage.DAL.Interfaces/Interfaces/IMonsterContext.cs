using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManage.DAL.Interfaces.DTOs;

namespace GameManage.DAL.Interfaces.Interfaces
{
    public interface IMonsterContext
    {
        List<MonsterDTO> GetMonsters(MonsterDTO monsters);
        void AddMonster(MonsterDTO monster);
        void RemoveMonster(MonsterDTO monster);
    }
}
