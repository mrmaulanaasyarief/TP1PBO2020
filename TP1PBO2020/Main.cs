using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Color color = (Color)ColorConverter.ConvertFromString("#1F363D");

namespace TP1PBO2020
{
    public partial class Main : Form
    {
        Produk[] products = new Produk[10];

        Color color1 = ColorTranslator.FromHtml("#75B9BE");
        Color color2 = ColorTranslator.FromHtml("#A8CCC9");
        Color color3 = ColorTranslator.FromHtml("#B3D6C6");

        public Main()
        {
            InitializeComponent();
        }

        private void addProduct()
        {
            products[0] = new Produk("foto6.png", "TV Bagus", 2999999, "Elektronik");
            products[1] = new Produk("foto2.png", "Celana Bagus", 189000, "Baju");
            products[2] = new Produk("foto8.png", "Tempe Bagus", 100000, "Makanan");
            products[3] = new Produk("foto4.png", "Sepatu Bagus", 379000, "Baju");
            products[4] = new Produk("foto5.png", "Kulkas Bagus", 7599999, "Elektronik");
            products[5] = new Produk("foto10.png", "Telor Bagus", 100000, "Makanan");
            products[6] = new Produk("foto3.png", "Topi Bagus", 99000, "Baju");
            products[7] = new Produk("foto9.png", "Tahu Bagus", 100000, "Makanan");
            products[8] = new Produk("foto7.png", "Kipas Bagus", 229999, "Elektronik");
            products[9] = new Produk("foto1.png", "Baju Bagus", 219000, "Baju");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            cbJenisProduk.SelectedIndex = 0;
            cbHargaProduk.SelectedIndex = 0;

            pnlHeader.BackColor = color1;
            pnlSideBar.BackColor = color2;
            btLogout.BackColor = color1;

            addProduct();
            showProducts(null, 0);
        }

        private void showProducts(string jenis, int range)
        {
            PictureBox pbFoto = new PictureBox();
            Label lblNama = new Label();
            Label lblHarga = new Label();
            Button btBeli = new Button();

            if ((range == 0 && (jenis == "-Jenis Produk-" || jenis == null)))
            {
                foreach (var product in products)
                {
                    lblNama.Text = product.nama;
                    lblHarga.Text = product.harga.ToString();

                    Image image = Image.FromFile(@"..\..\Resources\" + product.foto);
                    pbFoto.Image = image;

                    Card_Item card_Item = new Card_Item(pbFoto, lblNama, lblHarga, btBeli);
                    card_Item.TopLevel = false;
                    card_Item.Visible = true;
                    card_Item.BackColor = color3;

                    flpMenuBeli.Controls.Add(card_Item);
                }
            }else if (range != 0)
            {
                if(jenis == "-Jenis Produk-")
                {
                    jenis = null;
                }

                int awal = 0, akhir = 999999999;
                if(range == 1)
                {
                    awal = 100000;
                    akhir = 200000;
                }
                else if (range == 2)
                {
                    awal = 200000;
                    akhir = 500000;
                }
                else if (range == 3)
                {
                    awal = 500000;
                    akhir = 1000000;
                }

                foreach (var product in products)
                {
                    lblNama.Text = product.nama;
                    lblHarga.Text = product.harga.ToString();

                    Card_Item card_Item = new Card_Item(pbFoto, lblNama, lblHarga, btBeli);
                    card_Item.TopLevel = false;
                    card_Item.Visible = true;
                    card_Item.BackColor = color3;

                    if (jenis == null)
                    {
                        if((product.harga >= awal && product.harga <= akhir))
                        {
                            flpMenuBeli.Controls.Add(card_Item);
                        }
                    }
                    else
                    {
                        if ((product.harga >= awal && product.harga <= akhir) && (product.jenis == jenis))
                        {
                            flpMenuBeli.Controls.Add(card_Item);
                        }
                    }
                }

            }
            else if (jenis != "-Jenis Produk-")
            {
                if (range != 0)
                {
                    int awal = 0, akhir = 999999999;
                    if (range == 1)
                    {
                        awal = 100000;
                        akhir = 200000;
                    }
                    else if (range == 2)
                    {
                        awal = 200000;
                        akhir = 500000;
                    }
                    else if (range == 3)
                    {
                        awal = 500000;
                        akhir = 1000000;
                    }

                    foreach (var product in products)
                    {
                        lblNama.Text = product.nama;
                        lblHarga.Text = product.harga.ToString();

                        Card_Item card_Item = new Card_Item(pbFoto, lblNama, lblHarga, btBeli);
                        card_Item.TopLevel = false;
                        card_Item.Visible = true;
                        card_Item.BackColor = color3;

                        if ((product.harga >= awal && product.harga <= akhir) && (product.jenis == jenis))
                        {
                            flpMenuBeli.Controls.Add(card_Item);
                        }
                    }
                }
                else
                {
                    foreach (var product in products)
                    {
                        lblNama.Text = product.nama;
                        lblHarga.Text = product.harga.ToString();

                        Card_Item card_Item = new Card_Item(pbFoto, lblNama, lblHarga, btBeli);
                        card_Item.TopLevel = false;
                        card_Item.Visible = true;
                        card_Item.BackColor = color3;

                        if ((product.jenis == jenis))
                        {
                            flpMenuBeli.Controls.Add(card_Item);
                        }
                    }
                }
            }
        }

        private void btCari_Click(object sender, EventArgs e)
        {
            flpMenuBeli.Controls.Clear();
            showProducts(cbJenisProduk.SelectedItem.ToString(), cbHargaProduk.SelectedIndex);
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btMenuBeli_Click(object sender, EventArgs e)
        {
            tcMenu.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tcMenu.SelectedIndex = 2;
        }
    }
}
