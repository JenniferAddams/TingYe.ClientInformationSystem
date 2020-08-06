using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq;
using ClientInformationSystem.Core.Entities;

namespace ClientInformationSystem.Infrastructure.Data
{
    public class ClientInformationSystemDbContext : DbContext
    {
        public ClientInformationSystemDbContext(DbContextOptions<ClientInformationSystemDbContext> option) : base(option)
        {
                    
    }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Employees> Employees  { get; set; }
        public DbSet<Interactions> Interactions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clients>(ConfigureClients);
            modelBuilder.Entity<Employees>(ConfigureEmployees);
            modelBuilder.Entity<Interactions>(ConfigureInteractions);
        }

        public void ConfigureInteractions(EntityTypeBuilder<Interactions> obj)
        {
            obj.ToTable("Interactions");
            obj.HasKey(i => i.Id);
            obj.Property(i => i.IntType).HasMaxLength(1);
            obj.Property(i => i.Remarks).HasMaxLength(500);
            obj.HasOne(i => i.Clients).WithMany(e=>e.Interactions).HasForeignKey(i => i.ClientId);
            obj.HasOne(i => i.Employees).WithMany(e=>e.Interactions).HasForeignKey(i => i.EmpId);
        }

        public void ConfigureEmployees(EntityTypeBuilder<Employees> obj)
        {
            obj.ToTable("Empolyees");
            obj.HasKey(e => e.Id);
            obj.Property(e => e.Name).HasMaxLength(50);
            obj.Property(e => e.Password).HasMaxLength(10);
            obj.Property(e => e.Designation).HasMaxLength(50);
        }

        public void ConfigureClients(EntityTypeBuilder<Clients> obj)
        {
            obj.ToTable("Clients");
            obj.HasKey(c => c.Id);
            obj.Property(c => c.Name).HasMaxLength(50);
            obj.Property(c => c.Email).HasMaxLength(50);
            obj.Property(c => c.Phones).HasMaxLength(30);
            obj.Property(c => c.Address).HasMaxLength(50);
        }
    }
}
