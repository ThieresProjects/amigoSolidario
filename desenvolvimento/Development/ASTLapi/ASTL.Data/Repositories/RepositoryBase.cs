using ASTL.Data.Context;
using ASTL.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ASTL.Data.Repositories
{
    public class RepositorioBase<T> : IRepositorioBase<T> where T : class
    {
        protected SqlSContext _contexto { get; }
        private DbSet<T> _entidade { get; }

        public RepositorioBase( )
        {
            _contexto = new SqlSContext();
            _entidade = _contexto.Set<T>();
        }

        public virtual T ListarUm(params object[] keys)
        {
            return _entidade.Find(keys);
        }

        public virtual Task<List<T>> ListarTodosAsync()
        {
            return _contexto
                .Set<T>()
                .ToListAsync();
        }

        public virtual List<T> ListarTodos()
        {
            return _contexto
                .Set<T>()
                .ToList();
        }

        public void Adicionar(T entidade, bool saveChanges = true)
        {
            _entidade.Add(entidade);

            if (saveChanges)
                SaveChanges();
        }

        public void Remover(T entidade, bool saveChanges = true)
        {
            _entidade.Remove(entidade);

            if (saveChanges)
                SaveChanges();
        }

        public void Atualizar(T entidade, bool saveChanges = true)
        {
            _entidade.Update(entidade);

            if (saveChanges)
                SaveChanges();
        }

        public void SaveChanges()
        {
            _contexto.SaveChanges();
        }

    }
}


