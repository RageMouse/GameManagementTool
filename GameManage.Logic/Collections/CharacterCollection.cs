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

        internal Character ConvertCharacter(CharacterDTO character)
        {
            int maxLength = 20;
            if (maxLength < character.Name.Length || string.IsNullOrEmpty(character.Name) || string.IsNullOrEmpty(character.SpecializationName))
            {
                throw new ArgumentOutOfRangeException();
            }

            return new Character(character.CharacterId, character.Name, character.CreatedOn, character.SpecializationName, character.Score);
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

        public Character GetById(int id)
        {
            CharacterDTO characterDto = _characterContext.GetById(id);

            return new Character(characterDto.CharacterId, characterDto.Name, characterDto.SpecializationName);
        }

        public void Update(Character character)
        {
            _characterContext.Update(new CharacterDTO(character.Id, character.Name, character.Specialization_Id, character.SpecializationName));
        }
    }
}
