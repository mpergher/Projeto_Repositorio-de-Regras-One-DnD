namespace GlossarioOneDnD_MVC.Models
{
    public class Regra
    {
        public int RegraId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string VersoesAnteriores { get; set; }
        public virtual GlossarioRegras Glossario { get; set; }
    }
}
