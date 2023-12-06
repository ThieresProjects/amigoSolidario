using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTL.Domain.Entities
{
    public class Objeto
    {
        public int ObjetoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public bool Ativo { get; set; }
        public string Quantidade { get; set; }
        public int EnderecoId { get; set; }
        public int TipoObjetoId { get; set; }
        public Endereco Endereco { get; set; }
        public TipoObjeto TipoObjeto { get; set; }

    }
}
