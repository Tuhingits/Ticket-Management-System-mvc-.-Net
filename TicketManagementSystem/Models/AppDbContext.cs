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
        public DbSet<TicketManagementSystem.Models.FeedBack> FeedBacks{ get; set; }
        public DbSet<TicketManagementSystem.Models.CartLine> CartLines { get; set; }
        public DbSet<TicketManagementSystem.Models.Cart> Carts { get; set; }
        public DbSet<TicketManagementSystem.Models.CavinDetails> CavinDetails { get; set; }
        public DbSet<TicketManagementSystem.Models.PromoUser> PromoUsers { get; set; }
        public DbSet<TicketManagementSystem.Models.Launch> Launches { get; set; }
        public DbSet<TicketManagementSystem.Models.Owner> Owners { get; set; }
        public DbSet<TicketManagementSystem.Models.Payment> Payments { get; set; }
        public DbSet<TicketManagementSystem.Models.Promo> Promos { get; set; }
        public DbSet<TicketManagementSystem.Models.Schedul> Scheduls { get; set; }
        public DbSet<TicketManagementSystem.Models.PromoForLaunch> PromoForLaunches { get; set; }
        public DbSet<TicketManagementSystem.Models.PromoForUser> PromoForUsers { get; set; }
        public DbSet<TicketManagementSystem.Models.Registation> Registations { get; set; }
    }
}
