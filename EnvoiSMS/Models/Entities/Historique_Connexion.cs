﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnvoiSMS.Models.Entities
{
    public class Historique_Connexion
    {
        public int Id_Historique { get; set; }
        public int Id_Utilisateur { get; set; }
        public Utilisateur Utilisateur { get; set; }
    }
}
