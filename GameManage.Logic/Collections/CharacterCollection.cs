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
            if (maxLength < character.Name.Length || string.IsNullOrEmpty(character.Name))
            {
                throw new ArgumentOutOfRangeException();
            }

            _characterContext.AddCharacter(new CharacterDTO(character.Id, character.Name, character.CreatedOn, character.Score, character.Specialization_Id));

            return HasBeenAdded = true;
        }

        public void RemoveCharacter(CharacterDTO character)
        {
            _characterContext.RemoveCharacter(character);
        }

        private Character ConvertCharacter(CharacterDTO character)
        {
            return new Character(character.Specialization_Id, character.Name, character.CreatedOn, character.Specialization_Name, character.Score);
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
