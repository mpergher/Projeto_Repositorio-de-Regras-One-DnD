namespace GlossarioOneDnD_MVC.Models
{
    public class GlossarioRegras
    {
        public int GlossarioRegrasId { get; set; }
        public string Versao { get; set; }
        public virtual ICollection<Regra> Regras { get; set; }
    }
}
