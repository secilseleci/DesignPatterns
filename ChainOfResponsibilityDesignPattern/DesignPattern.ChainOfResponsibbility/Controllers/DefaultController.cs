using DesignPattern.ChainOfResponsibbility.ChainOfResponsibility;
using DesignPattern.ChainOfResponsibbility.DAL;
using DesignPattern.ChainOfResponsibbility.Models;
using Microsoft.AspNetCore.Mvc;
using Employee = DesignPattern.ChainOfResponsibbility.ChainOfResponsibility.Employee;

namespace DesignPattern.ChainOfResponsibbility.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel model)
        {
            Employee treasurer = new Treasurer();
            Employee managerAssistant = new ManagerAssistant();
            Employee manager = new Manager();
            Employee areaDirector = new AreaDirector();

            treasurer.SetNextApprover(managerAssistant);
            managerAssistant.SetNextApprover(manager);
            manager.SetNextApprover(areaDirector);

            treasurer.ProcessRequest(model);
            return View();

            managerAssistant.ProcessRequest(model);
            manager.ProcessRequest(model);


        }
    }
}
