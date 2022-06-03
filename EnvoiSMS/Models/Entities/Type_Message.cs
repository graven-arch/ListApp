using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnvoiSMS.Models.Entities
{
    public class Type_Message
    {
        public int Id { get; set; }
        public String Libelle_Type { get; set; }
        public int Id_Utilisateur { get; set; }
        public Utilisateur Utilisateur { get; set; }
    }
}
