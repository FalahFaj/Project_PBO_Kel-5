using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO_Kel_5.Model
{
    internal class Item_transaksi
    {
        [Key]
        public int id_item_transaksi { get; set; }
        public int id_produk { get; set; }
        public int jumlah { get; set; }
        public Item_transaksi(int id_item_transaksi, int id_produk, int jumlah)
        {
            this.id_item_transaksi = id_item_transaksi;
            this.id_produk = id_produk;
            this.jumlah = jumlah;
        }
    }
}
