using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GameManage.Logic.Models;

namespace GameManagementTool.Models
{
    public class AddCharacterViewModel
    {
        [Display(Name = "Character Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name Required")]
        public string Name { get; set; }

        //[Display(Name = "Specialization")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "Specialization Required")]
        //public string Specialization { get; set; }

        public List<Specialization> AllSpecializations { get; set; }
    }
}
