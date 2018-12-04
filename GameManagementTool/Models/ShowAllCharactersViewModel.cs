using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameManage.Logic.Models;

namespace GameManagementTool.Models
{
    public class ShowAllCharactersViewModel
    {
        public List<Character> Characters { get; set; }

        public ShowAllCharactersViewModel()
        {

        }

        public ShowAllCharactersViewModel(List<Character> characters)
        {
            Characters = characters;
        }
    }
}
