﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnvoiSMS.Models.Entities
{
    public class Param_Canal
    {
        public int Id { get; set; }
        public Utilisateur Utilisateur { get; set; }
        public int Id_Utilisateur { get; set; }
        public ICollection<PlagedeNumero> PlagedeNumeros { get; set; }
    }
}
