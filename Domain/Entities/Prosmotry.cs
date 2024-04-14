using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Prosmotry : BaseEntity
    {
      
        public string Ocenki { get; set; }
        public string Kol_vo { get; set; }
        public User Users { get; set; }
        public int UserId { get; set; }
        public Films Films { get; set; }
        public int FilmsId { get; set; }
    }
}