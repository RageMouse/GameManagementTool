using System;
using System.Collections.Generic;
using GameManage.DAL.Interfaces.DTOs;
using GameManage.DAL.Interfaces.Interfaces;

namespace GameManage.DAL.Memory
{
    public class CharacterMemoryContext : ICharacterContext
    {
        private ICharacterContext Context { get; }

        List<CharacterDTO> character = new List<CharacterDTO>();

        public List<CharacterDTO> GetCharacters()
        {
            throw new NotImplementedException();
        }

        public void AddCharacter(CharacterDTO characterDTO)
        {
            character.Add(characterDTO);
        }

        public void RemoveCharacter(CharacterDTO characterDTO)
        {
            character.Remove(characterDTO);
        }

        public CharacterDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(CharacterDTO character)
        {
            throw new NotImplementedException();
        }
    }
}
