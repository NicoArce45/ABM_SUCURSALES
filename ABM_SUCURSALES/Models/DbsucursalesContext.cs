using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ABM_SUCURSALES.Models;

public partial class DbsucursalesContext : DbContext
{
    public DbsucursalesContext()
    {
    }

    public DbsucursalesContext(DbContextOptions<DbsucursalesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Sucursale> Sucursales { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            //        => optionsBuilder.UseSqlServer("server=localhost; database=DBSUCURSALES; integrated security=true; TrustServerCertificate=Yes;");
        }

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sucursale>(entity =>
        {
            entity.HasKey(e => e.IdSucursales).HasName("PK__SUCURSAL__3414F61DAE9C74CD");

            entity.ToTable("SUCURSALES");

            entity.Property(e => e.IdSucursales).HasColumnName("Id_Sucursales");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
