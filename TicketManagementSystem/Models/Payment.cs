using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketManagementSystem.Models
{
    public class Payment
    {
        [Key]
        public int p_Id { get; set; }

        [Required]
        [Display(Name = "Payment Status")]
        public string  paymentStatus { get; set; }

        [Required]
        [Display(Name = "Payment Option")]
        public string paymentOption { get; set; }

        public User User { get; set; }
        public Cart Cart { get; set; }
    }
}
