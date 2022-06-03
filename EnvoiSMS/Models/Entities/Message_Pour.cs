using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnvoiSMS.Models.Entities
{
    public class Message_Pour
    {
        public int Id_Mess { get; set; }
        public int Id { get; set; }
        public Param_Message Param_Message { get; set; }
        public int Id_Groupe { get; set; }
        public GroupeContact GroupeContact { get; set; }
    }
}
