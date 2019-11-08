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

        public User User { get; set; }
        public Promo Promo { get; set; }

        public  ICollection<User> Users { get; set; }
        public  ICollection<Promo>Promos { get; set; }

    }
}
