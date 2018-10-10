using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManage.Logic.Models
{
    class Race
    {
        public string name { get; private set; }
        public int attackpoints { get; private set; }
        public int healthPoints { get; private set; }
        public string description { get; private set; }
    }
}
