using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    // The line above is a route decorator -- it overrides needing to go to home/goodbye, instead just /goodbye
    public string Landing() { return "This is the landing page!"; }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/result")]
    public ActionResult Result(string name, string city)
    {
      MadLibGame madLib = new MadLibGame("DefaultName");
      madLib.Name = name;
      madLib.City = city;
      return View(madLib);
    }
  }
}