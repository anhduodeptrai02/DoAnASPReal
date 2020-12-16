﻿// <auto-generated />
using System;
using DoAnASP1.Areas.Admin.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DoAnASP1.Migrations
{
    [DbContext(typeof(DPcontext))]
    partial class DPcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("DoAnASP1.Areas.Admin.Models.CTHoaDon", b =>
                {
                    b.Property<int>("MaCTHD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("HoaDonMaHD")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MaSP")
                        .HasColumnType("int");

                    b.Property<int?>("SanPhamMaSP")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int>("ThanhTien")
                        .HasColumnType("int");

                    b.HasKey("MaCTHD");

                    b.HasIndex("HoaDonMaHD");

                    b.HasIndex("SanPhamMaSP");

                    b.ToTable("CTHoaDon");
                });

            modelBuilder.Entity("DoAnASP1.Areas.Admin.Models.HoaDon", b =>
                {
                    b.Property<string>("MaHD")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MaCTHD")
                        .HasColumnType("int");

                    b.Property<string>("TongTien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("MaHD");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("DoAnASP1.Areas.Admin.Models.LoaiSPModels", b =>
                {
                    b.Property<int>("MaLoai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("MaNCC")
                        .HasColumnType("int");

                    b.Property<int?>("NCCID")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaLoai");

                    b.HasIndex("NCCID");

                    b.ToTable("LoaiSanPham");
                });

            modelBuilder.Entity("DoAnASP1.Areas.Admin.Models.NCC", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNCC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("NCC");
                });

            modelBuilder.Entity("DoAnASP1.Areas.Admin.Models.SanPhamModels", b =>
                {
                    b.Property<int>("MaSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Hinh")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("MaLoai")
                        .HasColumnType("int");

                    b.Property<int?>("MaNCC")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySX")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenSP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("MaSP");

                    b.HasIndex("MaLoai");

                    b.HasIndex("MaNCC");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("DoAnASP1.Areas.Admin.Models.CTHoaDon", b =>
                {
                    b.HasOne("DoAnASP1.Areas.Admin.Models.HoaDon", "HoaDon")
                        .WithMany("CTHoaDon")
                        .HasForeignKey("HoaDonMaHD");

                    b.HasOne("DoAnASP1.Areas.Admin.Models.SanPhamModels", "SanPham")
                        .WithMany("lstChiTietHoaDon")
                        .HasForeignKey("SanPhamMaSP");

                    b.Navigation("HoaDon");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("DoAnASP1.Areas.Admin.Models.LoaiSPModels", b =>
                {
                    b.HasOne("DoAnASP1.Areas.Admin.Models.NCC", "NCC")
                        .WithMany("LSP")
                        .HasForeignKey("NCCID");

                    b.Navigation("NCC");
                });

            modelBuilder.Entity("DoAnASP1.Areas.Admin.Models.SanPhamModels", b =>
                {
                    b.HasOne("DoAnASP1.Areas.Admin.Models.LoaiSPModels", "LoaiSP")
                        .WithMany()
                        .HasForeignKey("MaLoai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoAnASP1.Areas.Admin.Models.LoaiSPModels", null)
                        .WithMany("LstSanPham")
                        .HasForeignKey("MaNCC");

                    b.Navigation("LoaiSP");
                });

            modelBuilder.Entity("DoAnASP1.Areas.Admin.Models.HoaDon", b =>
                {
                    b.Navigation("CTHoaDon");
                });

            modelBuilder.Entity("DoAnASP1.Areas.Admin.Models.LoaiSPModels", b =>
                {
                    b.Navigation("LstSanPham");
                });

            modelBuilder.Entity("DoAnASP1.Areas.Admin.Models.NCC", b =>
                {
                    b.Navigation("LSP");
                });

            modelBuilder.Entity("DoAnASP1.Areas.Admin.Models.SanPhamModels", b =>
                {
                    b.Navigation("lstChiTietHoaDon");
                });
#pragma warning restore 612, 618
        }
    }
}
