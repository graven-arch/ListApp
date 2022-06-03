﻿using EnvoiSMS.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace EnvoiSMS.Models.EntitiesConfiguration
{
    public class P_RepertoireConfig : EntityTypeConfiguration<Param_Repertoire>
    {
        public P_RepertoireConfig()
        {
            HasKey(pr => pr.Id);
            HasRequired(pr => pr.Utilisateur)
                .WithMany(u => u.Param_Repertoires)
                .HasForeignKey(pr => pr.Id_Utilisateur);
        }
    }
}
