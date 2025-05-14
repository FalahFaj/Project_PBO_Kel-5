using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO_Kel_5.Model
{
    internal class Laporan
    {
        [Key]
        public int id_laporan { get; set; }
        public DateTime tanggal { get; set; }
        public int total_transaksi { get; set; }
        public double total_pendapatan { get; set; }
        public int id_daftar_transaksi { get; set; }
        public Laporan(int id_laporan, DateTime tanggal, int total_transaksi, double total_pendapatan)
        {
            this.id_laporan = id_laporan;
            this.tanggal = tanggal;
            this.total_transaksi = total_transaksi;
            this.total_pendapatan = total_pendapatan;
        }
    }
}
