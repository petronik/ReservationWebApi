using Microsoft.EntityFrameworkCore;
using ReservationWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationWebApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt) { }

        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<MenuItem> MenuItem { get; set; }
        public DbSet<ReservationMenuItem> ReservationMenuItem { get; set; }
    }
}
