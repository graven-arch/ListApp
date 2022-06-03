using EnvoiSMS.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace EnvoiSMS.Models.EntitiesConfiguration
{
    public class ContactConfig : EntityTypeConfiguration<Contact>
    {
        public ContactConfig()
        {
            HasKey(co => co.Id);
            HasRequired(co => co.GroupeContact)
                .WithMany(g => g.Contacts)
                .HasForeignKey(co => co.Id_Groupe);
        }
    }
}

