using System;
using System.Collections.Generic;
using DevConnectTorloni.Models;
using Microsoft.EntityFrameworkCore;

namespace DevConnectTorloni.Contexts;

public partial class DevConnectContext : DbContext
{
    public DevConnectContext()
    {
    }

    public DevConnectContext(DbContextOptions<DevConnectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Comentario> Comentario { get; set; }

    public virtual DbSet<Curtida> Curtida { get; set; }

    public virtual DbSet<Publicacao> Publicacao { get; set; }

    public virtual DbSet<Usuario> Usuario { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DevCon_SA");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comentario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Comentar__3214EC076E2E0E5B");

            entity.HasOne(d => d.IdPublicacaoNavigation).WithMany(p => p.Comentario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Comentari__IdPub__5535A963");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Comentario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Comentari__IdUsu__5441852A");
        });

        modelBuilder.Entity<Curtida>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Curtida__3214EC07096CDAD0");

            entity.HasOne(d => d.IdPublicacaoNavigation).WithMany(p => p.Curtida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Curtida__IdPubli__5165187F");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Curtida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Curtida__IdUsuar__5070F446");
        });

        modelBuilder.Entity<Publicacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Publicac__3214EC077F3F2843");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Publicacao).HasConstraintName("FK__Publicaca__IdUsu__4D94879B");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3214EC073BCE5C59");

            entity.HasMany(d => d.IdUsuarioSeguidor).WithMany(p => p.IdUsuarioSeguir)
                .UsingEntity<Dictionary<string, object>>(
                    "Seguidor",
                    r => r.HasOne<Usuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguidor")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Seguidor__IdUsua__71D1E811"),
                    l => l.HasOne<Usuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguir")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Seguidor__IdUsua__70DDC3D8"),
                    j =>
                    {
                        j.HasKey("IdUsuarioSeguir", "IdUsuarioSeguidor").HasName("PK__Seguidor__F7FC5B25A18380E2");
                    });

            entity.HasMany(d => d.IdUsuarioSeguir).WithMany(p => p.IdUsuarioSeguidor)
                .UsingEntity<Dictionary<string, object>>(
                    "Seguidor",
                    r => r.HasOne<Usuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguir")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Seguidor__IdUsua__70DDC3D8"),
                    l => l.HasOne<Usuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguidor")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Seguidor__IdUsua__71D1E811"),
                    j =>
                    {
                        j.HasKey("IdUsuarioSeguir", "IdUsuarioSeguidor").HasName("PK__Seguidor__F7FC5B25A18380E2");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
