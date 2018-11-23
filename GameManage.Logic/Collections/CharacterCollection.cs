using System;
using System.Collections.Generic;
using GameManage.DAL.Interfaces.DTOs;
using GameManage.DAL.Interfaces.Interfaces;
using GameManage.Logic.Interfaces;

namespace GameManage.Logic.Models
{
    public class CharacterCollection : ICharacterCollection
    {
        //Properties
        private ICharacterContext characterContext;

        public bool HasBeenAdded { get; set; }
        
        public List<CharacterDTO> Characters { get; private set; }

        //Constructors
        public CharacterCollection()
        {
            Characters = new List<CharacterDTO>();
        }

        public CharacterCollection(ICharacterContext context)
        {
            characterContext = context;
        }

        //Methods
        public bool AddCharacter(Character character)
        {
            int maxLength = 20;
            if (maxLength < character.Name.Length || string.IsNullOrEmpty(character.Name))
            {
                throw new ArgumentOutOfRangeException();
            }

            characterContext.AddCharacter(new CharacterDTO(character.Id, character.Name, character.CreatedOn, character.Score, character.Specialization_Id));

            return HasBeenAdded = true;
        }

        public void RemoveCharacter(CharacterDTO character)
        {
            characterContext.RemoveCharacter(character);
        }

        public List<CharacterDTO> GetCharacters(CharacterDTO characters)
        {
            throw new NotImplementedException();
        }
    }
}
