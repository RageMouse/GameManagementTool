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
        public List<Monster> Monsters { get; private set; }

        //Constructors
        public MonsterCollection(List<Monster> monsters)
        {
            Monsters = GetMonsters();
        }

        //Methods
        public List<Monster> GetMonsters()
        {
            throw new NotImplementedException();
        }
    }
}
