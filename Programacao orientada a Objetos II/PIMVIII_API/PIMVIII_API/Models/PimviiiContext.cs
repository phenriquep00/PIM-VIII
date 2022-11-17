using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PIMVIII_API.Models;

public partial class PimviiiContext : DbContext
{
    public PimviiiContext()
    {
    }

    public PimviiiContext(DbContextOptions<PimviiiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Endereco> Enderecos { get; set; }

    public virtual DbSet<Pessoa> Pessoas { get; set; }

    public virtual DbSet<PessoaTelefone> PessoaTelefones { get; set; }

    public virtual DbSet<Telefone> Telefones { get; set; }

    public virtual DbSet<TelefoneTipo> TelefoneTipos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=PIMVIII;Username=postgres;Password=33284202");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Endereco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("endereco_pkey");

            entity.ToTable("endereco");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id_");
            entity.Property(e => e.Bairro)
                .HasMaxLength(50)
                .HasColumnName("bairro");
            entity.Property(e => e.Cep).HasColumnName("cep");
            entity.Property(e => e.Cidade)
                .HasMaxLength(30)
                .HasColumnName("cidade");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasColumnName("estado");
            entity.Property(e => e.Logradouro)
                .HasMaxLength(256)
                .HasColumnName("logradouro");
            entity.Property(e => e.Numero).HasColumnName("numero");
        });

        modelBuilder.Entity<Pessoa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pessoa_pkey");

            entity.ToTable("pessoa");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id_");
            entity.Property(e => e.Cpf).HasColumnName("cpf");
            entity.Property(e => e.Endereco).HasColumnName("endereco");
            entity.Property(e => e.Nome)
                .HasMaxLength(256)
                .HasColumnName("nome");

            entity.HasOne(d => d.EnderecoNavigation).WithMany(p => p.Pessoas)
                .HasForeignKey(d => d.Endereco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("pessoa_endereco_fkey");
        });

        modelBuilder.Entity<PessoaTelefone>(entity =>
        {
            entity.HasKey(e => e.IdPessoa).HasName("pessoa_telefone_pkey");

            entity.ToTable("pessoa_telefone");

            entity.Property(e => e.IdPessoa)
                .ValueGeneratedNever()
                .HasColumnName("id_pessoa");
            entity.Property(e => e.IdTelefone).HasColumnName("id_telefone");

            entity.HasOne(d => d.IdPessoaNavigation).WithOne(p => p.PessoaTelefone)
                .HasForeignKey<PessoaTelefone>(d => d.IdPessoa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("pessoa_telefone_id_pessoa_fkey");

            entity.HasOne(d => d.IdTelefoneNavigation).WithMany(p => p.PessoaTelefones)
                .HasForeignKey(d => d.IdTelefone)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("pessoa_telefone_id_telefone_fkey");
        });

        modelBuilder.Entity<Telefone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("telefone_pkey");

            entity.ToTable("telefone");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id_");
            entity.Property(e => e.Ddd).HasColumnName("ddd");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.Tipo).HasColumnName("tipo");

            entity.HasOne(d => d.TipoNavigation).WithMany(p => p.Telefones)
                .HasForeignKey(d => d.Tipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("telefone_tipo_fkey");
        });

        modelBuilder.Entity<TelefoneTipo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("telefone_tipo_pkey");

            entity.ToTable("telefone_tipo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id_");
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .HasColumnName("tipo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
