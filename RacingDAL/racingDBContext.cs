﻿using RacingDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingDAL
{
    public class RacingDBContext : DbContext
    {
        public RacingDBContext() : base("Racing")
        {
            Database.SetInitializer<RacingDBContext>(new CreateDatabaseIfNotExists<RacingDBContext>());
            Configuration.LazyLoadingEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Engine>().ToTable("Engines");
            modelBuilder.Entity<Brake>().ToTable("Brakes");
            modelBuilder.Entity<RacingCar>().ToTable("RacingCars");
            modelBuilder.Entity<Suspention>().ToTable("Suspentions");
        }
        //public DbSet<Brake> Brakes { get; set; }
        //public DbSet<Engine> Engines { get; set; }
        //public DbSet<RacingCar> RacingCars { get; set; }
        //public DbSet<Suspention> Suspentions { get; set; }
    }
}

