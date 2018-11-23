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
        public int Specialization_Id { get; private set; }
        public int Score { get; private set; }

        public Character(int id, string name, DateTime createdOn, int specialization_Id, int score)
        {
            Id = id;
            Name = name;
            CreatedOn = createdOn;
            Score = score;
            Specialization_Id = specialization_Id;
        }

        public Character(string name)
        {
            Name = name;
        }
    }
}
