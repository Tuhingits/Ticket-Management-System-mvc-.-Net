using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketManagementSystem.Models;

namespace TicketManagementSystem.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<TicketManagementSystem.Models.User> User { get; set; }
        public DbSet<TicketManagementSystem.Models.FeedBack> FeedBack { get; set; }
    }
}
