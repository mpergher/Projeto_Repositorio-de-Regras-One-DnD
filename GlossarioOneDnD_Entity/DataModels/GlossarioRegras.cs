﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlossarioOneDnD_Entity.DataModels
{
    internal class GlossarioRegras
    {
        public int GlossarioRegrasId { get; set; }
        public string Versao { get; set; }
        public virtual ICollection<Regra> Regras { get; set; }
    }
}
