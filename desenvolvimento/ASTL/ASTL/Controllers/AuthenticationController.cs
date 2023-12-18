using ASTL.Data.Entities;
using ASTL.Data.Repositories;
using ASTL.Uteis;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASTL.Controllers
{
    public class AuthenticationController : Controller
    {
       private readonly ContaRepository _contaRepository;

        public AuthenticationController() 
        {
            _contaRepository = new ContaRepository();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(string email, string password)
        {
            UserData.Authenticated();
            UserData.ContaID = _contaRepository.Verify(email, password);
            if (UserData.Authenticated())
                return new JsonResult(new { status = 1, message = Url.Action("Index", "Admin") });
            else
                return new JsonResult(new { status = 0, message = "Usuario ou senha incorreta" });
        }

        [HttpPost]
        public ActionResult Registrar(string name, string email, string password ,string confirmPassword)
        {
            if(password == confirmPassword)
            {
                var ent = new Conta()
                {
                    Email = email,
                    Senha = password,
                    Usuario = name
                };

                if (_contaRepository.Register(ent))
                    return new JsonResult(new { status = 1, message = "Conta Criada com sucesso" });
                else
                    return new JsonResult(new { status = 0, message = "Email já cadastrado utilize outro" });

            }
            else
                return new JsonResult(new { status = 0, message = "Senhas diferente" });
        }
        
    }
}