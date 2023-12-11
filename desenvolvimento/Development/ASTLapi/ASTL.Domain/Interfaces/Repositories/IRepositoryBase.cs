using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTL.Domain.Interfaces.Repositories
{
    public interface IRepositorioBase<T> where T : class
    {
        T ListarUm(params object[] keys);
        Task<List<T>> ListarTodosAsync();
        List<T> ListarTodos();
        void Adicionar(T entidade, bool saveChanges = true);
        void Remover(T entidade, bool saveChanges = true);
        void Atualizar(T entidade, bool saveChanges = true);
        void SaveChanges();
    }
}
