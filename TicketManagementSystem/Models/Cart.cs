using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketManagementSystem.Models
{
    public class Cart
    {
        public int c_Id { get; set; }

        [Required]
        [Display(Name = "Date")]
        public string Date { get; set; }

        [Required]
        [Display(Name = "Total Amount ")]
        public string totalTk { get; set; }

        public User User { get; set; }
        public Promo Promo { get; set; }
    }
}
