using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO_Kel_5.Model
{
    internal class Produk
    {
        [Key]
        public int id_produk { get; set; }
        public string nama_produk { get; set; }
        public decimal harga { get; set; }
        public int stok { get; set; }
        public byte foto { get; set; }
        public int id_kategori { get; set; }
        public Kategori kategori { get; set; }

        public Produk(int id_produk, string nama_produk, decimal harga, int stok, byte foto, int id_kategori)
        {
            this.id_produk = id_produk;
            this.nama_produk = nama_produk;
            this.harga = harga;
            this.stok = stok;
            this.foto = foto;
            this.id_kategori = id_kategori;
        }
    }
}
