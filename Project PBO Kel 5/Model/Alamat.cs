using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO_Kel_5.Model
{
    internal class Alamat
    {
        [Key]
        public int id_alamat { get; set; }
        public string Jalan { get; set; }
        public string RT { get; set; }
        public string RW { get; set; }
        public string Kelurahan { get; set; }
        public string Kecamatan { get; set; }
        public string Kota { get; set; }
        public string Provinsi { get; set; }
        public string KodePos { get; set; }
        public ICollection<Customer> customer { get; set; }
        //public Alamat(string jalan, string rt, string rw, string kelurahan, string kecamatan, string kota, string provinsi, string kodePos)
        //{
        //    Jalan = jalan;
        //    RT = rt;
        //    RW = rw;
        //    Kelurahan = kelurahan;
        //    Kecamatan = kecamatan;
        //    Kota = kota;
        //    Provinsi = provinsi;
        //    KodePos = kodePos;
        //}
        public Alamat() { }
    }
}
