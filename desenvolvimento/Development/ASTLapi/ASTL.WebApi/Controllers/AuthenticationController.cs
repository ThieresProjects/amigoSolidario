using ASTL.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASTL.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {
       private readonly IContaService _contaService;

        public AuthenticationController(IContaService contaService) 
        {
            _contaService = contaService;
        }

        [HttpPost]
        public ActionResult Login(string user, string password)
        {
            if (_contaService.Verify(user, password))
                return Redirect(Url.Action("",""));
            else
                return new JsonResult(new { status = 1, message = "Usuario ou senha incorreta" });
        }
    }
}