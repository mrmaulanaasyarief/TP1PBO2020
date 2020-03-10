using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1PBO2020
{
    class Produk
    {
        public string foto { get; set; }
        public string nama { get; set; }
        public int harga { get; set; }
        public string jenis { get; set; }

        public Produk(string foto, string nama, int harga, string jenis)
        {
            this.foto = foto;
            this.nama = nama;
            this.harga = harga;
            this.jenis = jenis;
        }

        public Produk()
        {
        }
    }
}
