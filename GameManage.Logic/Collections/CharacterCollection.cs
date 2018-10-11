using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManage.DAL.DTOs;
using GameManage.Logic.Models;

namespace GameManage.Logic.Models
{
    class CharacterCollection
    {
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

        public void AddCharacter(Character character)
        {
            Characters.Add(new CharacterDTO(character.Name));
        }

        public void RemoveCharacter(Character character)
        {
            Characters.Remove(character);
        }
    }
}
