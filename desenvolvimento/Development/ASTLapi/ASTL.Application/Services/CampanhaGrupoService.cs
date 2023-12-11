using ASTL.Domain.Interfaces.Repositories;
using ASTL.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTL.Application.Services
{
    public class CampanhaGrupoService : ICampanhaGrupoService
    {
        private readonly ICampanhaGrupoRepository _campanhaGrupoService;
        public CampanhaGrupoService(ICampanhaGrupoRepository campanhaGrupoRepository)
        { 
            _campanhaGrupoService= campanhaGrupoRepository;
        }
    }
}