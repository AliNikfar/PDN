using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PDN.Domain.Entities.Projects;
using PDN.Domain.Entities.Teams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = PDN.Domain.Entities.Tasks.Task;

namespace PDN.Infrastructure.DBContexts
{
    public  class PDNDBContext: DbContext
    {
        private readonly IConfiguration _configuration ;

        public PDNDBContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Task> Tasks { get; set; }

        public DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbConnetion = _configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(dbConnetion);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>()
                        .HasMany(e => e.Tasks)
                        .WithOne(e => e.Project)
                        .HasForeignKey(e => e.ProjectId);

            modelBuilder.Entity<PDN.Domain.Entities.Tasks.Task>()
                        .HasOne(e => e.Team)
                        .WithOne(e => e.Task)
                        .HasForeignKey<Team>(e => e.TaskId);

            modelBuilder.Entity<Project>()
                        .HasIndex(e => new { e.Id })
                        .IsUnique(true);

            modelBuilder.Entity<PDN.Domain.Entities.Tasks.Task>()
                        .HasIndex(e => new { e.Id })
                        .IsUnique(true);

            modelBuilder.Entity<Team>()
                        .HasIndex(e => new { e.Id })
                        .IsUnique(true);
        }
    }
}
