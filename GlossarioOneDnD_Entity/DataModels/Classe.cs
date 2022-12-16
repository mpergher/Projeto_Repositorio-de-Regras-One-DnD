using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlossarioOneDnD_Entity.DataModels
{
    internal class Classe
    {
        public int ClasseID { get; set; }
        public string ClasseNome { get; set; }
        public virtual ICollection<Niveis> Niveis { get; set; }
    }
}
