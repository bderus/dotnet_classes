using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoApp.BusinessLogic.Controllers;
using ToDoApp.Models;
using System.Collections.Generic;

namespace ToDoApp.Tests
{
    [TestClass]
    public class ToDoListControllerTests
      
    {
        private readonly ToDoListController _testListController = new ToDoListController();

        [TestMethod]

        public void CreateNewToDoList_ToDoList_ShouldBeCreated()
        {
            //Arrange & Act
            var actualList = _testListController.CreateNewToDoList(null);
      
            //Assert

            Assert.IsInstanceOfType(actualList, typeof(ToDoList));
        }

        [TestMethod]
        public void CreateNewToDoList_ToDoList_ShouldBeCreated_WithProperNameList()
        {
            //Arrange
            var expectedListName = "TestListName";

            //Act
            var actualList = _testListController.CreateNewToDoList(expectedListName);

            //Assert

            Assert.AreEqual(expectedListName, actualList.Name);
        }
        [TestMethod]
        public void CreateNewToDoList_ToDoList_ShouldBeCreated_WithProperId()
        {
            //Arrange
            var expectedListId = 1;

            //Act
            var actualList = _testListController.CreateNewToDoList(null);

            //Assert
            Assert.AreEqual(expectedListId, actualList.Id);
        }

        [TestMethod]

        public void CreateNewToDoList_ToDoList_ShouldBeCreated_WithProperInsideObjectType()
        {

            //Arrange & Act
            var actualListItem = _testListController.CreateNewToDoList(null);
            //Assert
            Assert.IsInstanceOfType(actualListItem.ToDoItems, typeof(List<ToDoItem>));
        }

        [TestMethod]
        public void CreateNewToDoList_ToDoList_ShouldBeAddedToProperty_ToDoLists()
        {
            //Arrange
            var expectedListId = 1;
            var expectedListName = "lista1";
            _testListController.CreateNewToDoList(expectedListName);

            //Act
            var actualList = _testListController.ToDoLists[0];

            //Assert
            Assert.AreEqual(expectedListId, actualList.Id);
            Assert.AreEqual(expectedListName, actualList.Name);

        }

        [TestMethod]
        public void AddNewItemToList_ShouldBeTypeOfBool()
        {
            //Arrange & Act
            var actualItem = _testListController.AddNewItemToList(0, null);

            //Assert
            Assert.IsInstanceOfType(actualItem, typeof(bool));
        }

        [TestMethod]

        public void AddNewItemToList_ShouldBeAddedToList()
        {
            //Arrange
            var expectedId = 1;
            var expectedItemName = "item1";
            _testListController.CreateNewToDoList(null);
            _testListController.AddNewItemToList(expectedId, expectedItemName);
            var listItems = _testListController.ToDoLists[0].ToDoItems;

            //Act
            var actualItem = listItems[0];

            //Assert
            Assert.AreEqual(expectedId, actualItem.Id);
            Assert.AreEqual(expectedItemName, actualItem.Name);

        }


    }
}
