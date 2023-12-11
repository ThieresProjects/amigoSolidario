using ASTL.Domain.Entities;

namespace ASTL.Domain.Interfaces.Repositories
{
    public interface IContaRepository : IRepositorioBase<Conta>
    {
        bool Verify(string usuario, string password);
    }
}
