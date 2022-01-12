using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoApp.BusinessLogic.Controllers;
using ToDoApp.Models;

namespace ToDoApp.Tests
{
    [TestClass]
    public class ToDoItemControllerTests
    {
        private readonly ToDoItemController _testController = new ToDoItemController();

        [TestMethod]
        public void Constructor_CreatesControllerInstance()
        {
            //Arrange & Act
            var testToDoItemController = new ToDoItemController();

            //Assert
            Assert.IsInstanceOfType(testToDoItemController, typeof(ToDoItemController));
        }

        [TestMethod]
        public void CreateNewToDoItem_NewItem_ShouldBeCreated()
        {
            //Arrange & Act
            var actualItem = _testController.CreateNewToDoItem(null);

            //Assert
            Assert.IsInstanceOfType(actualItem, typeof(ToDoItem));
        }

        [TestMethod]
        public void CreateNewToDoItem_NewItem_ShouldBeCreated_WithProperId()
        {
            //Arrange
            var expectedId = 2;
            _testController.CreateNewToDoItem(null);

            //Act
            var actualItem = _testController.CreateNewToDoItem(null);

            //Assert
            Assert.AreEqual(expectedId, actualItem.Id);
        }

        [TestMethod]
        public void CreateNewToDoItem_NewItem_ShouldBeCreated_WithExpectedName()
        {
            //Arrange
            var expectedName = "testName";

            //Act
            var actualItem = _testController.CreateNewToDoItem(expectedName);

            //Assert
            Assert.AreEqual(expectedName, actualItem.Name);
        }
    }
}
