using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO_Kel_5.Model
{
    internal class Customer
    {
        [Key]
        public int id_customer { get; set; }
        public string nama { get; set; }
        public string no_hp { get; set; }
        public string email_address { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int id_alamat { get; set; }
        [ForeignKey("id_alamat")]
        public Alamat alamat { get; set; }
        public ICollection<Transaksi> transaksi { get; set; }
        public ICollection<Data_chat> data_chat { get; set; }

    }
}
