using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PH48831_phunghuytruong.Models;

public partial class BaitapPh48831Context : DbContext
{
    public BaitapPh48831Context()
    {
    }

    public BaitapPh48831Context(DbContextOptions<BaitapPh48831Context> options)
        : base(options)
    {
    }

    public virtual DbSet<LopHoc> LopHocs { get; set; }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=PHUNGHUYTRUONG\\SQLEXPRESS01;Database=Baitap_PH48831;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LopHoc>(entity =>
        {
            entity.HasKey(e => e.MaLop).HasName("PK__LopHoc__3B98D273A8D7596B");

            entity.ToTable("LopHoc");

            entity.Property(e => e.MaLop).HasMaxLength(50);
            entity.Property(e => e.TenLop).HasMaxLength(100);
        });

        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SinhVien__3214EC276C16BF8B");

            entity.ToTable("SinhVien");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("ID");
            entity.Property(e => e.MaLop).HasMaxLength(50);
            entity.Property(e => e.Nganh).HasMaxLength(100);
            entity.Property(e => e.Ten).HasMaxLength(100);

            entity.HasOne(d => d.MaLopNavigation).WithMany(p => p.SinhViens)
                .HasForeignKey(d => d.MaLop)
                .HasConstraintName("FK__SinhVien__MaLop__3C69FB99");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
