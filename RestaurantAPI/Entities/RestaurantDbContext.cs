﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Entities
{
    public class RestaurantDbContext : DbContext
    {
        //private string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=RestaurantDb;Trusted_Connection=True;";
        private string _connectionString = "Server=KAMILZAZULA\\SQLEXPRESS;Database=RestaurantDb;Trusted_Connection=True;";
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Dish> Dishes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Restaurant>()
                //.HasOne(a => a.Address)
                //.WithOne(a => a.Restaurant)
                //.HasForeignKey<Address>(c => c.RestaurantId);
            //modelBuilder.Entity<Restaurant>().ToTable("Restaurant");
            //modelBuilder.Entity<Address>().ToTable("Restaurant");

            modelBuilder.Entity<Restaurant>()
                .Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(25);

            modelBuilder.Entity<Dish>()
                .Property(r => r.Name)
                .IsRequired();

            modelBuilder.Entity<Address>()
                .Property(r => r.City)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Address>()
                .Property(r => r.Street)
                .IsRequired()
                .HasMaxLength(50);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
