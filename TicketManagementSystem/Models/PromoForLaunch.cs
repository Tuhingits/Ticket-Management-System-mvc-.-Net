using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TicketManagementSystem.Models
{
    public class PromoForLaunch
    {
        [Key]
        public int PFL_Id { get; set; }
        [ForeignKey("Registration")]
        public int U_Id { get; set; }

        public Registation Registation { get; set; }
    }
}
