using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManage.Logic.Models
{
    class Monster
    {
        public int id { get; private set; }
        public string name { get; private set; }
        public DateTime CreatedOn { get; private set; }
    }
}
