using ASTL.Data.Repositories;
using ASTL.Uteis;
using ASTL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASTL.Controllers
{
    public class AdminController : Controller
    {
        private readonly ContaRepository _contaRepository;
        private readonly CampanhaRepository _campanhaRepository;
        private readonly UsuarioScoreRepository _usuarioScoreRepository;
        private readonly CampanhaGrupoRepository _campanhaGrupoRepository;
        private readonly CampanhaPremioRepository _campanhaPremioRepository;
        private readonly ProdutoCampanhaRepository _produtoCampanhaRepository;
        private readonly UsuarioCampanhaRepository _usuarioCampanhaRepository;

        public AdminController() 
        {
            _contaRepository = new ContaRepository();
            _campanhaRepository = new CampanhaRepository();
            _usuarioScoreRepository = new UsuarioScoreRepository();
            _campanhaGrupoRepository = new CampanhaGrupoRepository();
            _campanhaPremioRepository = new CampanhaPremioRepository();
            _usuarioCampanhaRepository = new UsuarioCampanhaRepository();
            _produtoCampanhaRepository = new ProdutoCampanhaRepository();

        }

        public ActionResult Index()
        {
            var listCampUser = _usuarioCampanhaRepository
                .ListarTodos()
                .Where(x => x.ContaID == UserData.ContaID)
                .ToList();

            var ents = _campanhaRepository
                .ListarTodos()
                .Where(x => listCampUser.Where(y => y.CampanhaID == x.CampanhaID).Any())
                .ToList();

            return View(ents);
        }

        [Route("/Campanha/{campanhaId:int}")]
        public ActionResult Campanha([FromRoute]int campanhaId)
        {
            var Users = new List<UsuarioCampanhaViewModel>();
            var user = _contaRepository.ListarUm(UserData.ContaID); 

            var campanha = _campanhaRepository
                    .ListarUm(campanhaId);

            var listGrupos = _campanhaGrupoRepository
                                .ListarTodos()
                                .Where(x => x.CampanhaID == campanhaId)
                                .ToList();

            var produtos = _produtoCampanhaRepository
                                .ListarTodos()
                                .Where(x => x.CampanhaID == campanhaId)
                                .ToList();

            var premios = _campanhaPremioRepository
                            .ListarTodos()  
                            .Where(x => x.CampanhaID == campanhaId)
                            .ToList();

            _usuarioCampanhaRepository
                .ListarTodos()
                .Where(x => x.CampanhaID == campanhaId)
                .ToList()
                .ForEach(item => {

                    Users.Add(
                        new UsuarioCampanhaViewModel(){ 
                            CampanhaID = item.CampanhaID,
                            ContaID= item.ContaID,
                            GrupoID= item.GrupoID,
                            Score= item.Score,
                            Admin = item.Admin,
                            Usuario = _contaRepository.ListarUm(item.ContaID),
                            Grupo = _campanhaGrupoRepository.ListarUm(item.GrupoID),
                            Scores = _usuarioScoreRepository
                                        .ListarTodos()
                                        .Where(x => x.CampanhaID == item.CampanhaID)
                        }
                    );

                });

            var ent = new CampanhaViewModel()
            {
                CampanhaID = campanhaId,
                Nome = campanha.Nome,
                Descricao = campanha.Descricao,
                Grupos = listGrupos,
                Produtos = produtos,
                Premios = premios,
                usuarios = Users
            };
            return View(ent);
        }
    }
}