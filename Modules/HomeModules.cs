using System;
using Palindromes.Objects;
using Nancy;
using System.Collections.Generic;

namespace Palindromes.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        string result = "";
        return View["index.cshtml", result];
      };
      Post["/"] = _ => {
        PalindromeFinder newPalindromeFinder = new PalindromeFinder(Request.Form["input1"]);
        string result = newPalindromeFinder.GetResults();
        return View["index.cshtml", result];
      };
    }
  }
}
