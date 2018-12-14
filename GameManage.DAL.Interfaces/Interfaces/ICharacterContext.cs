using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManage.DAL;
using GameManage.DAL.Interfaces.DTOs;

namespace GameManage.DAL.Interfaces.Interfaces
{
    public interface ICharacterContext
    {
        List<CharacterDTO> GetCharacters();
        void AddCharacter(CharacterDTO character);
        void RemoveCharacter(CharacterDTO character);
        CharacterDTO GetById(int id);
        void Update(CharacterDTO character);
    }
}
