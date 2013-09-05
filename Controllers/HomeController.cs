using System.Linq;
using System.Web.Mvc;
using PeerBeerAwards.Context;
using PeerBeerAwards.Models;

namespace PeerBeerAwards.Controllers
{
    public class HomeController : Controller
    {
        private readonly PeerBeerAwardsContext context = new PeerBeerAwardsContext();

        public ActionResult Index()
        {
            var nominees = context.Nominees.ToList();

            return View(nominees);
        }

        public ActionResult AddNominee(Nominee newNominee)
        {
            context.Nominees.Add(newNominee);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult AwardNominee(int nomineeId)
        {
            var nominee = context.Nominees.Find(nomineeId);
            nominee.Awards += 1;
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            context.Dispose();
        }
    }
}
