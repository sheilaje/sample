using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dice.Models;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace Dice.Tests
{
  [TestClass]
  public class UserTest
  // : IDispose
  {
    // public void Dispose()
    // {
    //
    // }
    //
    // public UserTest()
    // {
    //   DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=Dice_Test;";
    // }
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      User newUser = new User("test", 1, 1);
      Assert.AreEqual(typeof(User), newUser.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string name = "Walk the dog.";
      User newUser = new User(name, 1 , 1);

      //Act
      string result = newUser.GetName();

      //Assert
      Assert.AreEqual(name, result);
    }
  }
}
