using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1PBO2020
{
    public partial class Card_Item : Form
    {
        public Card_Item()
        {
            InitializeComponent();
        }
        public Card_Item(PictureBox pbFoto, Label lblNama, Label lblHarga, Button btBeli)
        {
            InitializeComponent();

            this.pbFoto.Image = pbFoto.Image;
            this.lblNama.Text = lblNama.Text;
            this.lblHarga.Text = "Rp. " + lblHarga.Text;
            //this.btBeli = btBeli;
        }
    }
}
