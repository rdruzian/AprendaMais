﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Model
{
    public class Pertence
    {
        [Required]
        public int ID_pergunta { get; set; }
        [Required]
        public int ID_texto { get; set; }
    }
}
