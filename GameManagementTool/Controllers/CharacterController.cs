using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameManage.DAL.Factory;
using GameManage.Logic.Interfaces;
using GameManage.Logic.Models;
using GameManagementTool.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GameManagementTool.Controllers
{
    public class CharacterController : Controller
    {
        private readonly CharacterFactory _characterFactory;
        private readonly SpecializationFactory _specializationFactory;
        private readonly IConfiguration _configuration;

        public CharacterController(IConfiguration configuration)
        {
            _configuration = configuration;
            _characterFactory = new CharacterFactory(_configuration);
            _specializationFactory = new SpecializationFactory(_configuration);
        }

        public IActionResult Index()
        {
            AddCharacterViewModel model = new AddCharacterViewModel()
            {
                //todo make function
                //AllSpecializations = SpecializationCollection.GetAllSpecializations()
            };
            return View();
        }

        [HttpGet]
        public IActionResult AddNewCharacter()
        {

            ISpecializationCollection specializationCollection = _specializationFactory.SpecializationCollection();

            AddCharacterViewModel model = new AddCharacterViewModel()
            {
                AllSpecializations = specializationCollection.GetAll()
            };

            return View(model);
        }

        public IActionResult AddNewCharacter(AddCharacterViewModel model)
        {
            ICharacterCollection characterCollection = _characterFactory.CharacterCollection();
            characterCollection.AddCharacter(new Character(model.Name));
            return RedirectToAction("Index", "Character");
        }
    }
}