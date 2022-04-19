using _20aprel_task_.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace _20aprel_task_.Data.DAL
{
    internal class FootballDbContext: DbContext
    {
        public DbSet<Stadion> Stadions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-I5QTI09;Database=Football;Trusted_Connection=TRUE;");
        }
    }
}
