using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketManagementSystem.Models
{
    public class PromoForUser
    {
        [Key]
        public int PFU_Id { get; set; }

        public Launch Launch { get; set; }
        public Promo Promo { get; set; }

        public  ICollection<Launch>Launches { get; set; }
        public  ICollection<Promo>Promos { get; set; }


    }
}
