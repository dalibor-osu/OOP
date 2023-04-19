using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11.EFCore
{
    internal class VyukaContex : DbContext
    {
        public DbSet<Hodnoceni> Hodnocenis { get; set; }
        public DbSet<Predmet> Predmets { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<ZapsanePredmety> ZapsanePredmets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;
                                            AttachDbFilename=C:\Users\drevo\source\repos\Lesson 11\Lesson 11\Vyuka.mdf;
                                            Connect Timeout=30");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hodnoceni>().HasKey(e => e.HodnoceniId);
            modelBuilder.Entity<Predmet>().HasKey(e => e.PredmetId);
            modelBuilder.Entity<Student>().HasKey(e => e.StudentId);
            modelBuilder.Entity<ZapsanePredmety>().HasKey(e => e.ZapsanePredmetyId);
        }
    }
}
