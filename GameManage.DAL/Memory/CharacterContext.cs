using System;
using System.Collections.Generic;
using GameManage.DAL.Interfaces.DTOs;
using GameManage.DAL.Interfaces.Interfaces;

namespace GameManage.DAL.Memory
{
    public class CharacterContext : ICharacterContext
    {
        private ICharacterContext Context { get; }

        List<CharacterDTO> character = new List<CharacterDTO>();

        public List<CharacterDTO> GetCharacters(CharacterDTO characters)
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
    }
}
