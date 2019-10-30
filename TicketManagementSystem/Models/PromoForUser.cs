using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketManagementSystem.Models
{
    public class PromoForUser
    {
        
        public int pfu_id { get; set; }

        public Launch Launch { get; set; }
        public Promo Promo { get; set; }
    }
}
