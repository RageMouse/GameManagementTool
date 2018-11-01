using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManage.Logic.Models
{
    public class Character
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public DateTime CreatedOn { get; private set; }
        public int Score { get; private set; }

        public Character(int id, string name, DateTime createdOn, int score)
        {
            Id = id;
            Name = name;
            CreatedOn = createdOn;
            Score = score;
        }
    }
}
