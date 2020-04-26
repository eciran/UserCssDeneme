using System.Web.Mvc;

namespace UserPageDeneme.Controllers
{
	public class HomeController : Controller
	{
		// GET: Home
		public ActionResult Index()
		{
			return View();
		}
		public ActionResult Login()
		{
			return View();
		}
		public ActionResult Product()
		{
			return  View();
		}
		public ActionResult ContactForm()
		{
			return View();
		}
	}
}