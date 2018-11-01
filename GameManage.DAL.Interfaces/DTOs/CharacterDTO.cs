using System;

namespace GameManage.DAL.Interfaces.DTOs
{
    public struct CharacterDTO
    {
        public readonly int Character_Id;
        public readonly string Name;
        public DateTime CreatedOn;
        public readonly int Score;

        public CharacterDTO(int character_Id, string name, DateTime createdOn, int score)
        {
            Character_Id = character_Id;
            Name = name;
            CreatedOn = createdOn;
            Score = score;
        }
    }
}
