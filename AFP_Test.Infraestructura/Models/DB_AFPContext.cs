﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AFP_Test.Infraestructura.Models
{
    public partial class DB_AFPContext : DbContext
    {
        public DB_AFPContext()
        {
        }

        public DB_AFPContext(DbContextOptions<DB_AFPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Departamentos> Departamentos { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAP-039\\MARCOMENDEZ;Initial Catalog=DB_AFP;Integrated Security=True, Trusted_Connection=True; TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamentos>(entity =>
            {
                entity.HasKey(e => e.IdDepartamento);

                entity.Property(e => e.NombreDepartamento)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.Property(e => e.Bitacora)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaDeRegistro).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDepartamentoNavigation)
                    .WithMany(p => p.Empresa)
                    .HasForeignKey(d => d.IdDepartamento)
                    .HasConstraintName("FK_Empresa_Departamentos");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}