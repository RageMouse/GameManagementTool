using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManage.Logic.Models
{
    class MonsterCollection
    {
        //Properties
        private List<Monster> Monsters { get; set; }

        //Constructors
        public MonsterCollection(List<Monster> monsters)
        {
            Monsters = GetMonsters();
        }

        //Methods
        private List<Monster> GetMonsters()
        {
            throw new NotImplementedException();
        }

        public void AddMonster(Monster monster)
        {
            Monsters.Add(monster);
        }

        public void RemoveMonster(Monster monster)
        {
            Monsters.Remove(monster);
        }
    }
}
