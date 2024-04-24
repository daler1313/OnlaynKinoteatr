using Domain.Enum;


namespace Domain.Entities
{
    public class Films : BaseEntity
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public string Strana { get; set; }
        public Reyting Reyting { get; set; }
        public Zhanr Zhanrs { get; set; }
        public int Zhanr_id { get; set; }
        public Producer Produccers { get; set; }
        public int Produccer_id { get; set; }
        public virtual ICollection<Prosmotry> Prosmotrys { get; set; }
    }
}