using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTL.Domain.Entities
{
    public class Endereco
    {
        public string cep { get; set; }   
        public string cidade { get; set; }
        public string estado { get; set; }
        public int numero { get; set; }
        public string pais { get; set; }
        public string complemento { get; set; }
    }
}
