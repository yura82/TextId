﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TextId.Models
{
    public class Person
    {[Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int PissitionId { get; set; }
         public ICollection<Possition> Possitions { get; set; }
    }
}
