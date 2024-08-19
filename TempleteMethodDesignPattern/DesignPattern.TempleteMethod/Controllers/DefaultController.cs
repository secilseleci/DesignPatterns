using DesignPattern.TemplateMethod.TemplatePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.TemplateMethod.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            ViewBag.v1 = netflixPlans.PlanType("Temel Plan");
            ViewBag.v2 = netflixPlans.Content("Film-Dizi");
            ViewBag.v3 = netflixPlans.CountPerson(1);
            ViewBag.v4 = netflixPlans.Price(300);
            ViewBag.v5 = netflixPlans.Resolution("480px");
            return View();
        }
        public IActionResult StandardPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            ViewBag.v1 = netflixPlans.PlanType("Standart Plan");
            ViewBag.v2 = netflixPlans.Content("Film-Dizi-Belgesel-Podcast");
            ViewBag.v3 = netflixPlans.CountPerson(2);
            ViewBag.v4 = netflixPlans.Price(500);
            ViewBag.v5 = netflixPlans.Resolution("720px");
            return View();
        }
        public IActionResult UltraPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            ViewBag.v1 = netflixPlans.PlanType("Ultra Plan");
            ViewBag.v2 = netflixPlans.Content("Film-Dizi-Belgesel-Podcast-LigTv");
            ViewBag.v3 = netflixPlans.CountPerson(4);
            ViewBag.v4 = netflixPlans.Price(700);
            ViewBag.v5 = netflixPlans.Resolution("1080px");
            return View();
        }
    }
}
