using NHibernate;
using NHibernateMVC5_Demo.Models;
using NHibernateMVC5_Demo.NHibernateFiles;
using System.Linq;
using System.Web.Mvc;

namespace NHibernateMVC5_Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                var employees = session.Query<Employees>().ToList();
                return View(employees);
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