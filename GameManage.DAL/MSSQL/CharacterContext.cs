using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManage.DAL.Interfaces;
using GameManage.DAL.Interfaces.DTOs;
using GameManage.DAL.Interfaces.Interfaces;

namespace GameManage.DAL.MSSQL
{
    public class CharacterContext : ICharacterCollectionContext
    {
        public List<CharacterDTO> Characters { get; private set; }

        public List<CharacterDTO> GetCharacters(CharacterDTO characters)
        {   
            throw new NotImplementedException();
        }

        public void AddCharacter(CharacterDTO character)
        {
            Characters.Add(character);
        }

        public void RemoveCharacter(CharacterDTO character)
        {
            Characters.Remove(character);
        }
    }
}
