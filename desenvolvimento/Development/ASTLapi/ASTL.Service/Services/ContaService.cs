using ASTL.Domain.Interfaces.Repositories;
using ASTL.Domain.Interfaces.Services;

namespace ASTL.Service.Services
{
    public class ContaService : IContaService
    {
        private readonly IContaRepository _contaRepository;
        public ContaService(IContaRepository contaRepository)
        {
            _contaRepository = contaRepository;
        }

        public bool Verify(string usuario, string password)
        {
            return _contaRepository.Verify(usuario, password);
        }
    }
}