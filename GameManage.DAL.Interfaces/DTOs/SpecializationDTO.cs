using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManage.DAL.Interfaces.DTOs
{
    public struct SpecializationDTO
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int HealthPoints { get; private set; }
        public int AttackPoints { get; private set; }

        public SpecializationDTO(int id, string name, string description, int healthPoints, int attackPoints)
        {
            Id = id;
            Name = name;
            Description = description;
            HealthPoints = healthPoints;
            AttackPoints = attackPoints;
        }
    }
}
