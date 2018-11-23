using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManage.Logic.Models
{
    public class Specialization
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int HealthPoints { get; private set; }
        public int AttackPoints { get; private set; }

        //Constructor
        public Specialization(string name, string description, int healthPoints, int attackPoints)
        {
            Name = name;
            Description = description;
            HealthPoints = healthPoints;
            AttackPoints = attackPoints;
        }
    }
}
