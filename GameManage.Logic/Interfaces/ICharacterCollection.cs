using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManage.Logic.Models;

namespace GameManage.Logic.Interfaces
{
    public interface ICharacterCollection
    {
        bool AddCharacter(Character character);
        List<Character> GetAllCharacters();
        Character GetById(int id);
        void Update(Character character);
    }
}