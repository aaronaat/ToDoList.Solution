using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Controllers;
using ToDoList.Models;

namespace ToDoList.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
      [TestMethod]
      public void Index_ReturnsCorrectView_True()
      {
          //Arrange
          HomeController controller = new HomeController();

          //Act
          ActionResult indexView = controller.Index();

          //Assert
          Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }
      [TestMethod]
      public void Index_HasCorrrectModelType_ItemList()
      {
        ViewResult indexView = new HomeController().Index() as ViewREsult;
        var result = indexView.ViewData.Model;
        Assert.IsInstanceOfType(result, typeof(List<Item>));
      }

    }
}
