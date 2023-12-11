using ASTL.Domain.Interfaces.Repositories;
using ASTL.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTL.Application.Services
{
    public class CampanhaScoreService : ICampanhaScoreService
    {
        private readonly ICampanhaScoreRepository _campanhaScoreService;
        public CampanhaScoreService(ICampanhaScoreRepository campanhaScoreRepository)
        { 
            _campanhaScoreService= campanhaScoreRepository;
        }
    }
}