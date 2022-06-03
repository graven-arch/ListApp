﻿using EnvoiSMS.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace EnvoiSMS.Models.EntitiesConfiguration
{
    public class H_EnvoiConfig : EntityTypeConfiguration<Historique_Envoi>
    {
        public H_EnvoiConfig()
        {
            HasKey(he => he.Id_HistoriqueMessage);
            HasMany(he => he.Param_Messages)
                .WithRequired(pm => pm.Historique_Envoi);
        }
    }
}
