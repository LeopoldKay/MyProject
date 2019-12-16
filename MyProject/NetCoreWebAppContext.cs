using Microsoft.EntityFrameworkCore;
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
                .SetBasePath(@"G:\Leopold Docs\C#\Study\StudyRepository\CSharpProfessional\13.NetCore\NetCoreWebApp\NetCoreWebApp")
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("NetCoreWebAppContext"));
        }

        public DbSet<Director> Directors { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Actor> Actors { get; set; }
        
    }
}
