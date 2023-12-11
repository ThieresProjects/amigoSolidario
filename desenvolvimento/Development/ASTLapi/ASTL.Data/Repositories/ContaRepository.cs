using ASTL.Domain.Entities;
using ASTL.Domain.Interfaces.Repositories;

namespace ASTL.Data.Repositories
{
    public class ContaRepository : RepositorioBase<Conta>, IContaRepository
    {
        public bool Verify(string user, string password)
        {
            return true;
        }
    }
}
