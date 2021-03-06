﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class LmsDbContext : DbContext
    {
        public LmsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Teacher> Teachers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasIndex(x => x.Name);
            modelBuilder.Entity<Course>().HasIndex(x => x.Topic);
            modelBuilder.Entity<Course>().HasIndex(x => x.IsFree);

            modelBuilder.Entity<Teacher>().HasIndex(x => x.Name);
            modelBuilder.Entity<Teacher>().HasIndex(x => x.Phone);
            modelBuilder.Entity<Teacher>().HasIndex(x => x.Course);
        }
    }
}
