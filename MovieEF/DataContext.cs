using Microsoft.EntityFrameworkCore;
using MovieEF.Entities.Configurations;
using MovieEF.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEF
{
    public class DataContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-UGDKHCT;Initial Catalog=MovieEF.DB;Integrated Security=True;Connect Timeout=60;Encrypt=False;Trust Server Certificate=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MovieConfig());
        }
    }
}
