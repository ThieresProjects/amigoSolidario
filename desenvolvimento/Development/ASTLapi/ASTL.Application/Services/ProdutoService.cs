using ASTL.Domain.Interfaces.Repositories;
using ASTL.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTL.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoService;
        public ProdutoService(IProdutoRepository produtoRepository)
        { 
            _produtoService = produtoRepository;
        }
    }
}