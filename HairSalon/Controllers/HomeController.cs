using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")] //----NOT SURE IF NEEDED ANYMORE, WILL TEST WHEN PROJECT CAN RUN
    public ActionResult Index()
    {
      return View();
    }
  }
}