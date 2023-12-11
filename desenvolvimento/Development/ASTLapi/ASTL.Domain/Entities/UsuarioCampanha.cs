using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTL.Domain.Entities
{
    public class UsuarioCampanha
    {
        public int CampanhaID { get; set; }
        public int ContaID { get; set; }
        public int GrupoID { get; set; }
        public bool Admin { get; set; }
        public decimal Score { get; set; }

    }
}
