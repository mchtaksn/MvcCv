using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MvcDB.Models;

public partial class DbCvContext : DbContext
{
    public DbCvContext()
    {
    }

    public DbCvContext(DbContextOptions<DbCvContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Tbladmin> Tbladmins { get; set; }

    public virtual DbSet<Tbldeneyimlerim> Tbldeneyimlerims { get; set; }

    public virtual DbSet<Tblegitim> Tblegitims { get; set; }

    public virtual DbSet<Tblhakkimizdum> Tblhakkimizda { get; set; }

    public virtual DbSet<Tblhobilerim> Tblhobilerims { get; set; }

    public virtual DbSet<Tbliletisim> Tbliletisims { get; set; }

    public virtual DbSet<Tblsertifikalarim> Tblsertifikalarims { get; set; }

    public virtual DbSet<Tblsosyalmedya> Tblsosyalmedyas { get; set; }

    public virtual DbSet<Tblyeteneklerim> Tblyeteneklerims { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=DbCv;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tbladmin>(entity =>
        {
            entity.ToTable("TBLADMIN");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Kullaniciadi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KULLANICIADI");
            entity.Property(e => e.Sifre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SIFRE");
        });

        modelBuilder.Entity<Tbldeneyimlerim>(entity =>
        {
            entity.ToTable("TBLDENEYIMLERIM");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Altbaslik)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ALTBASLIK");
            entity.Property(e => e.Baslik)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BASLIK");
            entity.Property(e => e.Tarih)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<Tblegitim>(entity =>
        {
            entity.ToTable("TBLEGITIM");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Altbaslik1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ALTBASLIK1");
            entity.Property(e => e.Altbaslik2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ALTBASLIK2");
            entity.Property(e => e.Baslik)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BASLIK");
            entity.Property(e => e.Gno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GNO");
            entity.Property(e => e.Tarih)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<Tblhakkimizdum>(entity =>
        {
            entity.ToTable("TBLHAKKIMIZDA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AD");
            entity.Property(e => e.Adres)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ADRES");
            entity.Property(e => e.Mail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAIL");
            entity.Property(e => e.Resim)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RESIM");
            entity.Property(e => e.Soyad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SOYAD");
            entity.Property(e => e.Telefon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEFON");
        });

        modelBuilder.Entity<Tblhobilerim>(entity =>
        {
            entity.ToTable("TBLHOBILERIM");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aciklama2)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA2");
        });

        modelBuilder.Entity<Tbliletisim>(entity =>
        {
            entity.ToTable("TBLILETISIM");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adsoyad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ADSOYAD");
            entity.Property(e => e.Konu)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("KONU");
            entity.Property(e => e.Mail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAIL");
            entity.Property(e => e.Mesaj)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MESAJ");
            entity.Property(e => e.Tarih).HasColumnName("TARIH");
        });

        modelBuilder.Entity<Tblsertifikalarim>(entity =>
        {
            entity.ToTable("TBLSERTIFIKALARIM");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
        });

        modelBuilder.Entity<Tblsosyalmedya>(entity =>
        {
            entity.ToTable("TBLSOSYALMEDYA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AD");
            entity.Property(e => e.Ikon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ikon");
            entity.Property(e => e.Link)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LINK");
        });

        modelBuilder.Entity<Tblyeteneklerim>(entity =>
        {
            entity.ToTable("TBLYETENEKLERIM");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Yetenek)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("YETENEK");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
