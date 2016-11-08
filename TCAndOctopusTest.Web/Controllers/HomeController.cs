using System.Linq;
using System.Web.Mvc;
using TCAndOctopusTest.Db;

namespace TCAndOctopusTestWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyDbContext _db = new MyDbContext();

        public ActionResult Index()
        {
            var albums = _db.Albums.Include("Artist").ToList();
            return View(albums);
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