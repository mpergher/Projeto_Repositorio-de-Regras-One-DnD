using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlossarioOneDnD_Entity.DataModels
{
    internal class Regra
    {
        public int RegraId { get; set; } 
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string VersoesAnteriores { get; set; }
        public virtual GlossarioRegras Glossario { get; set; }
    }
}
