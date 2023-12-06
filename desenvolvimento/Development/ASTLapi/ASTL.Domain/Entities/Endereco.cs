using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTL.Domain.Entities
{
    public class Endereco
    {
        public string CEP { get; set; }   
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Numero { get; set; }
        public string Pais { get; set; }
        public string Complemento { get; set; }
    }
}
