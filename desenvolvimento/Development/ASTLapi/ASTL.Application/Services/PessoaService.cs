using ASTL.Domain.Interfaces.Repositories;
using ASTL.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTL.Application.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaService;
        public PessoaService(IPessoaRepository pessoaRepository)
        { 
            _pessoaService= pessoaRepository;
        }
    }
}