using ASTL.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ASTL.Controllers
{
    public class AdminController : Controller
    {
       private readonly ContaRepository _contaRepository;

        public AdminController() 
        {
            _contaRepository = new ContaRepository();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}