using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManage.DAL.Interfaces.DTOs
{
    public struct MonsterDTO
    {
        private readonly int Name;

        public MonsterDTO(int name)
        {
            Name = name;
        }
    }
}
