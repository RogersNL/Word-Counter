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

    [TestMethod]
    public void CompareStringToArray_True()
    {
      //Arrange
      string input = "The last theme for the Wednesday talk was Pokemon.";
      string[] inputArray = {"The", "last", "theme", "for", "the", "Wednesday", "talk", "was", "Pokemon."};
      RepeatCounter newRepeatCounter = new RepeatCounter();

      //Act
      newRepeatCounter.SetUserCompareString(input);
      string[] result = newRepeatCounter.CompareStringToArray();

      //Assert
      CollectionAssert.AreEqual(inputArray, result);
    }
    [TestMethod]
    public void TidyArray_True()
    {
      //Arrange
      string[] inputArray = {"The", "last", "theme", "for", "the", "Wednesday", "talk", "was", "Pokemon."};
      string[] outputArray = {"the", "last", "theme", "for", "the", "wednesday", "talk", "was", "pokemon"};

      //Act
      string[] result = RepeatCounter.TidyArray(inputArray);

      //Assert
      CollectionAssert.AreEqual(outputArray, result);
    }
  }
}
