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
    public static string[] TidyAndSort(string[] CompareArray)
    {
      foreach(string word in CompareArray)
      {
        if(word.All(Char.IsLetter) == false)
        {
          foreach(char letter in word)
          {
            if(Char.IsLetter(letter))
            {
              word = word + letter;
            }
          }
        }
        word = word.ToLower();
      }
      return Array.Sort(CompareArray);
    }
  }
}
