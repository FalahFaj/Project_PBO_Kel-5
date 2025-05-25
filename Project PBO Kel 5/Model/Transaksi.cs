using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO_Kel_5.Model
{
    internal class Transaksi
    {
        [Key]
        public int id_transaksi { get; set; }
        public DateTime tanggal { get; set; }
        public decimal nominal { get; set; }
        public int id_customer { get; set; }
        public int id_item_transaksi { get; set; }
        public int id_metode_pembayaran { get; set; }
        public int id_penyewaan { get; set; }
    }
}
