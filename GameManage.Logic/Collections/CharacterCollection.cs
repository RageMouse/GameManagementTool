using System;
using System.Collections.Generic;
using GameManage.DAL.Factory;
using GameManage.DAL.Interfaces.DTOs;
using GameManage.DAL.Interfaces.Interfaces;
using GameManage.Logic.Interfaces;

namespace GameManage.Logic.Models
{
    public class CharacterCollection : ICharacterCollection
    {
        private readonly ICharacterContext database = CharacterFactory.GetCharacterCollection();
        public bool HasBeenAdded { get; set; }

        //Properties
        public List<CharacterDTO> Characters { get; private set; }

        //Constructors
        public CharacterCollection()
        {
            Characters = new List<CharacterDTO>();
        }

        //Methods

        public bool AddCharacter(Character character)
        {
            int maxLength = 20;
            if (maxLength <= character.Name.Length || string.IsNullOrEmpty(character.Name))
            {
                throw new ArgumentOutOfRangeException();
            }

            database.AddCharacter(new CharacterDTO(character.Id, character.Name, character.CreatedOn, character.Score));

            return HasBeenAdded = true;
        }

        public void RemoveCharacter(CharacterDTO character)
        {
            database.RemoveCharacter(character);
        }

        public List<CharacterDTO> GetCharacters(CharacterDTO characters)
        {
            throw new NotImplementedException();
        }
    }
}
