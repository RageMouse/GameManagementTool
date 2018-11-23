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
            Character character = new Character(0, "John", DateTime.Now, 1, 200);
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
            Character character = new Character(0, "", DateTime.Now, 1, 200);
            //Act & Assert (Expects an Exception)
            characterCollection.AddCharacter(character);
        }
    }
}