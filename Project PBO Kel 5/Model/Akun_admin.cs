using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO_Kel_5.Model
{
    public class Akun_admin
    {
        [Key]
        public int id_admin { get; set; }
        public string nama { get; set; }
        public string no_hp { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Akun_admin() { }
        public Akun_admin(int id_admin, string nama, string no_hp, string username, string password)
        {
            this.id_admin = id_admin;
            this.nama = nama;
            this.no_hp = no_hp;
            this.username = username;
            this.password = password;
        }
    }
}
