﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTL.Domain.Entities
{
    public class CampanhaGrupo
    {
        public int CampanhaID { get; set; }
        public int GrupoID { get; set; }
        public string Nome { get; set; }
        public decimal ScoreGroup { get; set; }
    }
}