using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameManage.DAL.Factory;
using GameManage.DAL.Interfaces.DTOs;
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

        public CharacterController(IConfiguration configuration)
        {
            _characterFactory = new CharacterFactory(configuration);
            _specializationFactory = new SpecializationFactory(configuration);
        }

        public IActionResult Index()
        {
            ShowAllCharactersViewModel model = new ShowAllCharactersViewModel();
            model.Characters = _characterFactory.CharacterCollection().GetAllCharacters();

            return View(model);
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
            characterCollection.AddCharacter(new Character(model.Name, model.SpecializationId));
            return RedirectToAction("Index", "Character");
        }

        public IActionResult Edit(int id)
        {
            Character character = _characterFactory.CharacterCollection().GetById(id);
            ISpecializationCollection specializationCollection = _specializationFactory.SpecializationCollection();

            ShowAllCharactersViewModel model = new ShowAllCharactersViewModel()
            {
                CharacterId = id,
                Name = character.Name,
                SpecializationName = character.SpecializationName,
                AllSpecializations = specializationCollection.GetAll()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult SaveEdit(ShowAllCharactersViewModel model)
        {
            ICharacterCollection characterCollection = _characterFactory.CharacterCollection();
            characterCollection.Update(new Character(model.Name, model.SpecializationId));

            return RedirectToAction("Index", "Character");
        }
    }
}