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
        public int pfu_id { get; set; }

        public Launch Launch { get; set; }
        public Promo Promo { get; set; }
    }
}
