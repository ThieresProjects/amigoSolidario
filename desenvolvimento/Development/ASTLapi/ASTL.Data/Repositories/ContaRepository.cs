using ASTL.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTL.Data.Repositories
{
    public class ContaRepository: IContaRepository
    {
        public bool Verify(string user, string password)
        {
            return true;
        }
    }
}
