using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Project_PBO_Kel_5.Model;

namespace Project_PBO_Kel_5
{
    internal class KoneksiDB : DbContext
    {
        public DbSet<Produk> produk { get; set; }
        public DbSet<Customer> customer { get; set; }
        public DbSet<Daftar_transaksi> daftar_transaksi { get; set; }
        public DbSet<Kategori> kategori { get; set; }
        public DbSet<Alamat> alamat { get; set; }
        public DbSet<Penyewaan> penyewaan { get; set; }
        public DbSet<Item_transaksi> item_transaksi { get; set; }
        public DbSet<Metode_pembayaran> metode_pembayaran { get; set; }
        public DbSet<Transaksi> transaksi { get; set; }
        public DbSet<Laporan> laporan { get; set; }
        public DbSet<Data_chat> data_chat { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string koneksiDB = ConfigurationManager.ConnectionStrings["KoneksiDB"].ConnectionString;
            optionsBuilder.UseNpgsql(koneksiDB)
                .LogTo(Console.WriteLine, LogLevel.Information);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategori>()
                .HasKey(k => k.id_kategori);

            modelBuilder.Entity<Produk>()
                .HasOne(p => p.kategori)
                .WithMany(k => k.produk)
                .HasForeignKey(p => p.id_kategori);

            modelBuilder.Entity<Alamat>()
                .HasKey(a => a.id_alamat);

            modelBuilder.Entity<Customer>()
                .HasOne(k => k.alamat)
                .WithMany(d => d.customer)
                .HasForeignKey(c => c.id_alamat);

            modelBuilder.Entity<Data_chat>()
                .HasOne(dc => dc.customer)
                .WithMany(c => c.data_chat)
                .HasForeignKey(dc => dc.id_customer);
        }
    }
}
