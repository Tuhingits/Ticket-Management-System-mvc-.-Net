using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketManagementSystem.Models
{
    public class CartLine
    {
        [Key]
        public int CL_Id { get; set; }

        [Required]
        [Display(Name = "Price")]
        public string Price { get; set; }


        [Required]
        [Display(Name = "Catagory")]
        public string Catarory { get; set; }

        public Cart Cart { get; set; }
        public CavinDetails CavinDetails { get; set; }

        public  ICollection<Cart> Carts { get; set; }
        public ICollection<CavinDetails> Cavins { get; set; }

    }
}
