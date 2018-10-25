using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManage.DAL.Interfaces.DTOs
{
    public struct ItemDTO
    {
        public readonly int Item_Id;
        public int Bonus;

        public ItemDTO(int item_Id ,int bonus)
        {
            Item_Id = item_Id;
            Bonus = bonus;
        }
    }
}
