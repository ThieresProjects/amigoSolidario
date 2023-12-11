using ASTL.Domain.Interfaces.Repositories;
using ASTL.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTL.Application.Services
{
    public class CampanhaService : ICampanhaService
    {
        private readonly ICampanhaRepository _campanhaService;
        public CampanhaService(ICampanhaRepository campanhaRepository)
        { 
            _campanhaService = campanhaRepository;
        }
    }
}