using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Zhanr: BaseEntity
    {
       
        public string Nazvanie { get; set;}
        public virtual ICollection<Films> Films { get; set; }
    }
}