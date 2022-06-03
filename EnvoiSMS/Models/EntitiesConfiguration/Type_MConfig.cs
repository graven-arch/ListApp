using EnvoiSMS.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace EnvoiSMS.Models.EntitiesConfiguration
{
    public class Type_MConfig : EntityTypeConfiguration<Type_Message>
    {
        public Type_MConfig()
        {
            HasKey(t => t.Id);
            HasRequired(t => t.Utilisateur)
                .WithMany(u => u.Type_Messages)
                .HasForeignKey(t => t.Id_Utilisateur);
        }

    }
}