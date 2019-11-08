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
        public int P_Id { get; set; }

        [Required]
        [Display(Name = "Payment Status")]
        public string  PaymentStatus { get; set; }

        [Required]
        [Display(Name = "Payment Option")]
        public string PaymentOption { get; set; }

        public User User { get; set; }
        public Cart Cart { get; set; }

        public ICollection<Cart> Carts { get; set; }
        public ICollection<User> Users { get; set; }

    }
}
