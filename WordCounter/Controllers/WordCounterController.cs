using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/items")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter ();
      newRepeatCounter.SetCounter(0);
      newRepeatCounter.SetUserInput(Request.Form["new-word"]);
      newRepeatCounter.SetUserCompareString(Request.Form["new-sentence"]);
      newRepeatCounter.SetCounter(newRepeatCounter.WordCount(RepeatCounter.TidyArray(newRepeatCounter.CompareStringToArray())));
      return View("Index", newRepeatCounter);
    }

  }
}
