﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject
{
    public class NetCoreWebAppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(@"I:\Leopold Docs\C#\Study\Advance\MyProject\MyProject")
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("NetCoreWebAppContext"));
        }

        public DbSet<Director> Directors { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Descry> Description { get; set; }
        public DbSet<Genre> Genres { get; set; }


    }
}
