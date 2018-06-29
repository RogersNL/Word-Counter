using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    private static int _counter = 0;
    private string _userInput;

    public int GetCounter()
    {
      return _counter;
    }
    public void SetUserInput(string userInput)
    {
      _userInput = userInput;
    }
    public string GetUserInput()
    {
      // return _userInput;
    }
  }
}
