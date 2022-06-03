using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnvoiSMS.Models.Entities
{
    public class Profil
    {
        public int Id_Profil { get; set; }
        public int Libelle_Profil { get; set; }
        public ICollection<Utilisateur> Utilisateurs { get; set; }
    }
}
