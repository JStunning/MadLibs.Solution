using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/result")]
    public ActionResult Result(string noun, string verb, string adjective, string noun2, string verb2, string exclamation)
    {
      MadLibGame madLib = new MadLibGame(noun, verb, adjective, noun2, verb2, exclamation);
      return View(madLib);
    }
  }
}