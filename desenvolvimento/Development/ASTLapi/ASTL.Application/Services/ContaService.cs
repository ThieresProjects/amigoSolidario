using ASTL.Domain.Interfaces.Repositories;
using ASTL.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTL.Application.Services
{
    public class ContaService : IContaService
    {
        private readonly IContaRepository _contaService;
        public ContaService(IContaRepository contaRepository)
        {
            _contaService = contaRepository;
        }

        public async Task<bool> VerifyAsync(string usuario, string password)
        {
            var ent = (await _contaService.ListarTodosAsync()).ToList().Where(x => x.Email == usuario &&
                                                             x.Senha == password)
                                                 .ToList();
            return ent.Count() == 1;
        }
    }
}