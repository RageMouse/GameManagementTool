using System;

namespace GameManage.DAL.Interfaces.DTOs
{
    public struct CharacterDTO
    {
        public readonly int CharacterId;
        public readonly string Name;
        public DateTime CreatedOn;
        public readonly int SpecializationId;
        public readonly string SpecializationName;
        public readonly int Score;

        public CharacterDTO(int characterId, string name, DateTime createdOn, int score, int specializationId)
        {
            CharacterId = characterId;
            Name = name;
            CreatedOn = DateTime.Now;
            SpecializationId = specializationId;
            Score = score;
            SpecializationName = null;
        }

        public CharacterDTO(int characterId, string name, DateTime createdOn, string specializationName, int score)
        {
            CharacterId = characterId;
            Name = name;
            CreatedOn = createdOn;
            SpecializationId = 0;
            SpecializationName = specializationName;
            Score = score;
        }

        public CharacterDTO(int characterId, string name, string specializationName)
        {
            CharacterId = characterId;
            Name = name;
            CreatedOn = DateTime.Now;
            SpecializationId = 0;
            SpecializationName = specializationName;
            Score = 0;
        }
    }
}
