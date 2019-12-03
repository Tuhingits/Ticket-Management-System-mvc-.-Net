using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketManagementSystem.Models
{
    public class PromoForLaunch
    {
        [Key]
        public int PFL_Id { get; set; }

        public Registation Registation { get; set; }
        public Promo Promo { get; set; }

        public  ICollection<Registation> Registations { get; set; }
        public  ICollection<Promo>Promos { get; set; }

    }
}
