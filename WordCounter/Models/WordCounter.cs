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
    public static string[] TidyArray(string[] CompareArray)
    {
      for (int i = 0; i < CompareArray.Length; i ++)
      {
        if(CompareArray[i].All(Char.IsLetter) == false)
        {
          string letterOnly = "";
          for (int j = 0; j < CompareArray[i].Length; j ++)
          {
            if(Char.IsLetter(CompareArray[i][j]))
            {
              letterOnly = letterOnly + CompareArray[i][j];
            }
          }
          CompareArray[i] = letterOnly;
        }
      CompareArray[i] = CompareArray[i].ToLower();
      }
      return CompareArray;
    }
  }
}
