﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Producer: BaseEntity
    {
        
        public string Name { get; set; }
        public string Tematika { get; set; }
        public string StazhRaboty { get; set; }
        public virtual ICollection<Films> Films { get; set; }
    }
}