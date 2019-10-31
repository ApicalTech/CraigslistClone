﻿using System;
using System.Collections.Generic;
using System.Text;
using CraigslistClone.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CraigslistClone.Data.Seeds;

namespace CraigslistClone.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Add new entities here if needed
        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Thread> Threads { get; set; }
        public DbSet<Listing> Listings { get; set; }
    }
}
