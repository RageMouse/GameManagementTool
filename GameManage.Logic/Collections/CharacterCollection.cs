using System;
using System.Collections.Generic;
using GameManage.DAL.DTOs;
using GameManage.DAL.Factory;
using GameManage.DAL.Interfaces.Interfaces;

namespace GameManage.Logic.Models
{
    class CharacterCollection
    {
        private readonly ICharacterCollectionContext database = CharacterFactory.GetCharacterCollectionContext();

        //Properties
        public List<Character> Characters { get; private set; }

        //Constructors
        public CharacterCollection()
        {
            Characters = GetCharacters();
        }

        //Methods
        public List<Character> GetCharacters()
        {
            throw new NotImplementedException();
        }

        public void AddCharacter(CharacterDTO character)
        {
            database.AddCharacter(character);
        }

        public void RemoveCharacter(CharacterDTO character)
        {
            database.RemoveCharacter(character);
        }
    }
}
