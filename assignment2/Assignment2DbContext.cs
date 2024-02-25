using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assignment2.Models;
using Microsoft.EntityFrameworkCore;


namespace assignment2
{
    public class Assignment2DbContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Email> Email { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<PhoneNumber> PhoneNumber { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server = localhost ; database=assignment2; user id=sa; password=74euW1Njse3T0-a ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Person>().HasOne(p => p.Address).WithOne(a => a.Person).HasForeignKey<Address>(a => a.PersonId);

            modelBuilder.Entity<Person>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Address>().Property(a => a.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<PhoneNumber>().HasOne(pn => pn.Person).WithMany(p => p.PhoneNumbers).HasForeignKey(pn => pn.PersonId);

            modelBuilder.Entity<Email>().HasOne(e => e.Person).WithMany(p => p.Emails).HasForeignKey(e => e.PersonId);

            modelBuilder.Entity<PersonEvent>().HasKey(pe => new { pe.PersonId, pe.EventId });
            modelBuilder.Entity<PersonEvent>().HasOne(pe => pe.Person).WithMany(p => p.PersonEvents).HasForeignKey(pe => pe.PersonId);

            modelBuilder.Entity<PersonEvent>().HasOne(pe => pe.Event).WithMany(e => e.PersonEvents).HasForeignKey(pe => pe.EventId);

        }
    }
}