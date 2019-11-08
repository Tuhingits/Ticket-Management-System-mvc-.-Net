using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketManagementSystem.Models
{
    public class User
    {
        [Key]
        public int U_Id { get; set; }

        [Required]
        [Display(Name = "User Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(16, ErrorMessage = "Must be between 5 and 15 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }
    }
}
