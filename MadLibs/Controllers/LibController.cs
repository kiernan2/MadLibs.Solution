using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class LibController : Controller
  {
    [Route("/")]
    public string Boo()
    {
      return "boo";
    }
  }
}