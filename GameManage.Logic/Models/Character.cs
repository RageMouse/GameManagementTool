using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManage.Logic.Models
{
    class Character
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public DateTime CreatedOn { get; private set; }
    }
}
