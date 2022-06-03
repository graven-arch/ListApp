using EnvoiSMS.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace EnvoiSMS.Models.EntitiesConfiguration
{
    public class P_CanalConfig : EntityTypeConfiguration<Param_Canal>
    {
        public P_CanalConfig()
        {
            HasKey(pc => pc.Id);
            HasRequired(pc => pc.Utilisateur)
                .WithMany(u => u.Param_Canals)
                .HasForeignKey(pc => pc.Id_Utilisateur);
            //Plage numero1 
            HasMany(pc => pc.PlagedeNumeros)
                .WithRequired(pl => pl.Param_Canal);
        }
    }
}