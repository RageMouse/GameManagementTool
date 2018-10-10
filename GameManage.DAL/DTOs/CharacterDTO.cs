using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManage.DAL.DTOs
{
    public struct CharacterDTO
    {
        public readonly int Character_Id;
        public readonly string Name;
        public readonly int Score;

        public CharacterDTO(int character_Id, string name, int score)
        {
            Character_Id = character_Id;
            Name = name;
            Score = score;
        }
    }
}
