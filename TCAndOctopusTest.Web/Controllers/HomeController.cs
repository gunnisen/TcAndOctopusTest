using System.Web.Mvc;
using TCAndOctopusTest.Db;

namespace TCAndOctopusTestWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new MyDbContext())
            {
                var albums = db.Albums.Include("Artist");
                return View(albums);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}