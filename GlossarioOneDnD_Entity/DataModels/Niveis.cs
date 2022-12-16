using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlossarioOneDnD_Entity.DataModels
{
    internal class Niveis
    {
        public int NiveisID { get; set; }
        public int Nivel { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string VersoesAnteriores { get; set; }
        public virtual Classe Classe { get; set; }
    }
}
