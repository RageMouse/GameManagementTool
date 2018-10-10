using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManage.Logic.Models
{
    class Specialization
    {
        public string name { get; private set; }
        public string Description { get; private set; }
        public int healthPoints { get; private set; }
        public int attackPoints { get; private set; }
    }
}
