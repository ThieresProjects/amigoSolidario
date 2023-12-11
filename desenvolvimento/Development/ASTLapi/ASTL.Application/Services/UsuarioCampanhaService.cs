using ASTL.Domain.Interfaces.Repositories;
using ASTL.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTL.Application.Services
{
    public class UsuarioCampanhaService : IUsuarioCampanhaService
    {
        private readonly IUsuarioCampanhaRepository _usuarioCampanhaService;
        public UsuarioCampanhaService(IUsuarioCampanhaRepository usuarioCampanhaRepository)
        { 
            _usuarioCampanhaService = usuarioCampanhaRepository;
        }
    }
}