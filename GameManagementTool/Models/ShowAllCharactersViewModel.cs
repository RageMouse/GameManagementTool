using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GameManage.Logic.Models;

namespace GameManagementTool.Models
{
    public class ShowAllCharactersViewModel
    {
        public int CharacterId { get; set; }

        public int SpecializationId { get; set; }
        public List<Specialization> AllSpecializations { get; set; }

        [Display(Name = "Character Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name Required")]
        public string Name { get; set; }

        [Display(Name = "Specialization Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Specialization Name Required")]
        public string SpecializationName { get; set; }


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
