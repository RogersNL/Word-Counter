using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter
{
  public class RepeatCounter
  {
    private static int _counter = 0;
    private string _userInput;
    private string _userCompareString;


    public int GetCounter()
    {
      return _counter;
    }
    public void SetUserInput(string userInput)
    {
      if(userInput.All(Char.IsLetter))
      {
        _userInput = userInput;
      }
    }
    public string GetUserInput()
    {
      return _userInput;
    }
    public void SetUserCompareString(string userCompareString)
    {
      _userCompareString = userCompareString;
    }
    public string GetUserCompareString()
    {
      return _userCompareString;
    }
    public string[] CompareStringToArray()
    {
      return _userCompareString.Split(' ');
    }
    public static string[] TidyArray(string[] compareArray)
    {
      for (int i = 0; i < compareArray.Length; i ++)
      {
        if(compareArray[i].All(Char.IsLetter) == false)
        {
          string letterOnly = "";
          for (int j = 0; j < compareArray[i].Length; j ++)
          {
            if(Char.IsLetter(compareArray[i][j]))
            {
              letterOnly = letterOnly + compareArray[i][j];
            }
          }
          compareArray[i] = letterOnly;
        }
      compareArray[i] = compareArray[i].ToLower();
      }
      return compareArray;
    }
    public int WordCount(string[] toCompare)
    {
      foreach (string word in toCompare)
      {
        if(_userInput.ToLower() == word)
        {
          _counter++;
        }
      }
      return _counter;
    }
  }
}
