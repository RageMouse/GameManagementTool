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
        private readonly ICharacterContext _characterContext;

        public bool HasBeenAdded { get; set; }
        
        public List<CharacterDTO> Characters { get; private set; }

        //Constructors
        public CharacterCollection(ICharacterContext context)
        {
            _characterContext = context;
        }

        //Methods
        public bool AddCharacter(Character character)
        {
            int maxLength = 20;
            if (maxLength < character.Name.Length || string.IsNullOrEmpty(character.Name) || string.IsNullOrEmpty(character.SpecializationName))
            {
                throw new ArgumentOutOfRangeException();
            }

            _characterContext.AddCharacter(new CharacterDTO(character.Id, character.Name, character.CreatedOn, character.Score, character.Specialization_Id));

            return true;
        }

        public void RemoveCharacter(CharacterDTO character)
        {
            _characterContext.RemoveCharacter(character);
        }

        public Character ConvertCharacter(CharacterDTO character)
        {
            int maxLength = 20;
            if (maxLength < character.Name.Length || string.IsNullOrEmpty(character.Name) || string.IsNullOrEmpty(character.SpecializationName))
            {
                throw new ArgumentOutOfRangeException();
            }

            return new Character(character.SpecializationId, character.Name, character.CreatedOn, character.SpecializationName, character.Score);
        }

        public List<Character> GetAllCharacters()
        {
            List<Character> users = new List<Character>();

            foreach (CharacterDTO characterDto in _characterContext.GetCharacters())
            {
                Character character = ConvertCharacter(characterDto);
                users.Add(character);
            }

            return users;
        }
    }
}
