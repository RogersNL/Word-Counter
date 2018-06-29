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

    public static void ClearAll()
    {
      _userInput.Clear();
      _userCompareString.Clear();
    }
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
    public string[] CompareStringToArray ()
    {
    //  return _userCompareString.Split(' ');
    }
  }
}
