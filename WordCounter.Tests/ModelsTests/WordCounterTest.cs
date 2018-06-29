using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;
using System;
using System.Collections.Generic;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void SetUserInput_GetUserInput_True()
    {
      //Arrange
      string input = "the";
      RepeatCounter newRepeatCounter = new RepeatCounter();

      //Act
      newRepeatCounter.SetUserInput(input);
      string result = newRepeatCounter.GetUserInput();

      //Assert
      Assert.AreEqual(input, result);
    }
  }
}
