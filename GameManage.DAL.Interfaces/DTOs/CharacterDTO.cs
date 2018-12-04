using System;

namespace GameManage.DAL.Interfaces.DTOs
{
    public struct CharacterDTO
    {
        public readonly int Character_Id;
        public readonly string Name;
        public DateTime CreatedOn;
        public readonly int Specialization_Id;
        public readonly string Specialization_Name;
        public readonly int Score;

        public CharacterDTO(int character_Id, string name, DateTime createdOn, int score, int specialization_Id)
        {
            Character_Id = character_Id;
            Name = name;
            CreatedOn = DateTime.Now;
            Specialization_Id = specialization_Id;
            Score = score;
            Specialization_Name = null;
        }

        public CharacterDTO(int character_Id, string name, DateTime createdOn, int score, string specialization_Name)
        {
            Character_Id = character_Id;
            Name = name;
            CreatedOn = createdOn;
            Specialization_Id = 0;
            Score = score;
            Specialization_Name = specialization_Name;
        }
    }
}
