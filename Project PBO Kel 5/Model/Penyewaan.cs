using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO_Kel_5.Model
{
    internal class Penyewaan
    {
        [Key]
        public int id_penyewaan { get; set; }
        public DateTime tanggal_sewa { get; set; }
        public DateTime tanggal_kembali { get; set; }
        public decimal pembayaran_dp { get; set; }
        public string status_dp { get; set; }
        public string status_peminjaman { get; set; }
        public int id_item_transaksi { get; set; }
        public Penyewaan(DateTime tanggal_sewa, DateTime tanggal_kembali, decimal pembayaran_dp, string status_dp, string status_peminjaman, int id_item_transaksi) 
        {
            this.tanggal_sewa = tanggal_sewa;
            this.tanggal_kembali = tanggal_kembali;
            this.pembayaran_dp = pembayaran_dp;
            this.status_dp = status_dp;
            this.status_peminjaman = status_peminjaman;
            this.id_item_transaksi = id_item_transaksi;
        }
    }
}
