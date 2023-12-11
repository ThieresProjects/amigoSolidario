using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTL.Domain.Entities
{
    public class CampanhaScore
    {
        public int ScoreID { get; set; }
        public int CampanhaID { get; set; }
        public int ProdutoID { get; set; }
        public Produto Produto { get; set; }
        public int Pontuacao { get; set; }
    }
}
