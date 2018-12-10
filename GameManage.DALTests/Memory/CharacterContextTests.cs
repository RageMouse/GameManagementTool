using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManage.Logic.Models;
using GameManage.DAL;
using GameManage.DAL.Interfaces.DTOs;
using GameManage.DAL.Memory;

namespace GameManage.Memory.Tests
{
    [TestClass]
    public class CharacterContextTests
    {
        [TestMethod]
        public void AddCharacterTest()
        {
            //Arrange
            CharacterCollection characterCollection = new CharacterCollection(new CharacterMemoryContext());
            Character character = new Character(0, "John", DateTime.Now, "Paladin", 200);
            //Act
            characterCollection.AddCharacter(character);
            //Assert
            bool addCharacter = characterCollection.AddCharacter(character);
            Assert.AreEqual(addCharacter, true);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddCharacterNoNameTest()
        {
            //Arrange
            CharacterCollection characterCollection = new CharacterCollection(new CharacterMemoryContext());
            Character character = new Character(0, "", DateTime.Now, "Paladin", 200);
            //Act & Assert (Expects an Exception)
            characterCollection.AddCharacter(character);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddCharacterNoSpecializationTest()
        {
            //Arrange
            CharacterCollection characterCollection = new CharacterCollection(new CharacterMemoryContext());
            Character character = new Character(0, "John", DateTime.Now, "", 200);
            //Act & Assert (Expects an Exception)
            characterCollection.AddCharacter(character);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddCharacterNameTooLongTest()
        {
            //Arrange
            CharacterCollection characterCollection = new CharacterCollection(new CharacterMemoryContext());
            Character character = new Character(0, Guid.NewGuid().ToString(), DateTime.Now, "Paladin", 200);
            //Act & Assert (Expects an Exception)
            characterCollection.AddCharacter(character);
        }

        [TestMethod]
        public void ConvertCharacterDTOTest()
        {
            //Arrange
            CharacterCollection characterCollection = new CharacterCollection(new CharacterMemoryContext());
            DateTime date = DateTime.Now;
            CharacterDTO character = new CharacterDTO(0, "John", date, "Paladin", 200);
            //Act
            Character convertedCharacter = characterCollection.ConvertCharacter(character);
            //Assert
            Assert.AreEqual(new Character(0, "John", date, "Paladin", 200), convertedCharacter);
        }

        [TestMethod]
        public void ConvertCharacterDTOFailTest()
        {
            //Arrange
            CharacterCollection characterCollection = new CharacterCollection(new CharacterMemoryContext());
            DateTime date = DateTime.Now;
            CharacterDTO character = new CharacterDTO(0, "John", date, "Paladin", 200);
            //Act
            Character convertedCharacter = characterCollection.ConvertCharacter(character);
            //Assert
            Assert.AreNotEqual(new Character(0, "John", date, "Wizard", 200), convertedCharacter);
        }
    }
}